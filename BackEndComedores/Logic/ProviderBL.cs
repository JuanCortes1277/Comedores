using BackEndComedores.DataACCESS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BackEndComedores.Logic
{
    public class ProviderBL
    {
        public Provider ExtractproviderByID(long code)
        {
            ProviderDAL providerdal = new ProviderDAL();
            return providerdal.ExtractById(code);
        }

        public Provider ExtractById(long? code)
        {
            ProviderDAL provider = new ProviderDAL();
            return provider.ExtractById(code);
        }
        public string InsertProvider( Provider provider)
        {
            ProviderDAL providerdal = new ProviderDAL();
            return providerdal.InsertProvider(provider);
        }
        public Provider Extractprovider(string  provider)
        {
            ProviderDAL providerdal = new ProviderDAL();
            return providerdal.Extractprovider(provider);
        }
        public List<Provider> ExtractAllProviders()
        {
            ProviderDAL providerdal = new ProviderDAL();
            return providerdal.ExtractAllProviders();
        }
        public string ModifyProvider(Provider provider)
        {
            ProviderDAL providerdal = new ProviderDAL();


            return providerdal.ModifyProvider(provider);

        }
        public string DeleteProvider(string code)
        {
            ProviderDAL providerdal = new ProviderDAL();


            return providerdal.DeleteProvider(code);

        }
        





    }
}