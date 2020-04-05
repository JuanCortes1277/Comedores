using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Accord.Statistics.Distributions;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Configuration;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

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

        public static Dictionary<string, object> getDistanceMatrix(string origin, string destination, long provider = 10101, long dinningroom = 015151)
        {
            

            HttpClient client = new HttpClient();
            Dictionary<string, object> dictionaryDistanceMatrix = new Dictionary<string, object>();
            string key = ConfigurationManager.AppSettings["KeyGoogle"]; ;
            string uri = string.Format("https://maps.googleapis.com/maps/api/distancematrix/json?units=metric&origins={0}&destinations={1}&key={2}&mode=driving&language=es", origin, destination, key);
            HttpResponseMessage response = client.GetAsync(uri).Result;
            if (response.IsSuccessStatusCode)
            {
                string result = response.Content.ReadAsStringAsync().Result;
                JObject rss = JObject.Parse(result);

                long durationValue = 0;
                long distanceValue = 0;

                long.TryParse((string)rss["rows"][0]["elements"][0]["duration"]["value"], out durationValue);
                string durationText =   (string)rss["rows"][0]["elements"][0]["duration"]["text"];
                long.TryParse((string)rss["rows"][0]["elements"][0]["distance"]["value"], out distanceValue);
                string distanceText = (string)rss["rows"][0]["elements"][0]["distance"]["text"];

                dictionaryDistanceMatrix.Add("IDprovider", provider);
                dictionaryDistanceMatrix.Add("IDdinningroom", dinningroom);
                dictionaryDistanceMatrix.Add("durationValue", durationValue);
                dictionaryDistanceMatrix.Add("durationText", durationText);
                dictionaryDistanceMatrix.Add("distanceValue", distanceValue);
                dictionaryDistanceMatrix.Add("distanceText", distanceText);
                

            }
            return dictionaryDistanceMatrix;
        }



    }
}


