using BackEndComedores.Entidades;
using BackEndComedores.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Web.Http;
using System.Web.Http.Cors;

namespace BackEndComedores.Controllers
{
    [AllowAnonymous]
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [RoutePrefix("api/login")]
    public class LoginController : ApiController
    {
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        [HttpGet]
        [Route("echoping")]
        public IHttpActionResult EchoPing()
        {
            return Ok(true);
        }

        [EnableCors(origins: "*", headers: "*", methods: "*")]
        [HttpGet]
        [Route("echouser")]
        public IHttpActionResult EchoUser()
        {
            var identity = Thread.CurrentPrincipal.Identity;
            return Ok($" IPrincipal-user: {identity.Name} - IsAuthenticated: {identity.IsAuthenticated}");
        }

     //   [EnableCors(origins: "*", headers: "*", methods: "*")]
        [HttpPost]
        [Route("authenticate")]
        public IHttpActionResult Authenticate(LoginRequest login)
        {
            if (login == null)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            //TODO: Validate credentials Correctly, this code is only for demo !!
            LogicBL logicBL = new LogicBL();
            SystemUser usere = logicBL.LoginCredentialsJWT(login.Username, login.Password);
           
          //  bool isCredentialValid = (login.Password == "123456");
            if (usere!=null)
            {

                CompleteVerificationUserEntity completeUser = new CompleteVerificationUserEntity();
                completeUser.Name = usere.Name;
                completeUser.LastName = usere.LastName;
                completeUser.ID = usere.ID;
                completeUser.Username = usere.Username;
                completeUser.UserType = usere.UserType;
                completeUser.provider = logicBL.ExtractByIdProvider(usere.ProviderID);
                



                var token = TokenGenerator.GenerateTokenJwt(login.Username);
                completeUser.token = token;

                return Ok(completeUser);
            }
            else
            {
                return Unauthorized();
            }
        }
    }
}