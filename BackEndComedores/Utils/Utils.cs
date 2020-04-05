using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Accord.Statistics.Distributions;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace BackEndComedores.Utils
{
    public static class Utils
    {
         

        public static double minmax(double x, double max, double min, double new_max = 1, double new_min = 0)
        {
            x = (x - min) * (new_max - new_min) / (max - min) + new_min;
            return x;
        }


        //standard normal cumulative distribution function
        public static double ZScore(double x)
        {
            MathNet.Numerics.Distributions.Normal result = new MathNet.Numerics.Distributions.Normal();
            return result.CumulativeDistribution(x);
        }

        public static object getDistanceMatrix()
        {
            HttpClient client = new HttpClient();
            object resultMatrix= "";
            HttpResponseMessage response = client.GetAsync("").Result;
            if (response.IsSuccessStatusCode)
            {
                resultMatrix =  response.Content.ReadAsAsync<Object>().Result;
            }
            return resultMatrix;
        }



    }
}


