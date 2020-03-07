using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BackEndComedoresEntities;

namespace BackEndComedoresDAL
{
   public  class ComedorDAL
    {
        public bool InsertarComedor(Comedor comedor)
        {
            int result;

            using (var context = new ProyectoMaestriaEntities())
            {
                var std = new Comedor()
                {
                    Codigo = comedor.Codigo,
                    Nombre = comedor.Nombre,
                    Direccion = comedor.Direccion,
                    Telefono = comedor.Telefono,
                    Email = comedor.Email,
                    Pais = comedor.Pais,
                    Departamento = comedor.Departamento,
                    Ciudad = comedor.Ciudad,
                    Contacto = comedor.Contacto,
                    Email_Contacto = comedor.Email_Contacto,
                    Telefono_Contacto = comedor.Telefono_Contacto,
                    Numero_Niños = comedor.Numero_Niños,
                    ZonaHorarioRecepción = comedor.ZonaHorarioRecepción
                


                  };
                context.Comedor.Add(std);

                result=context.SaveChanges();
              
                if (result == 0)
                {
                    return false;
                }
                else return true;
            }

        }
    }
}
