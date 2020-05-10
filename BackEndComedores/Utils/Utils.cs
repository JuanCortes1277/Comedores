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
using Microsoft.SolverFoundation.Services;

namespace BackEndComedores.Utils
{
    public static class Utils
    {
         

        public static double minmax(double x, double max, double min, double new_max = 2, double new_min = 1)
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
        public static double GetEffectivityPerProvider(double[,] b, int totalproviders, int posicionacomparar)
        {
            Term goal = 0.0;
            int status = 0;
            int variablesQuantity = b.GetLength(1);
            //   var efficiency = new Decision(Domain.RealNonnegative, "efficiency");


            Console.WriteLine(variablesQuantity);
            var solver = SolverContext.GetContext();
            solver.ClearModel();
            
            var model = solver.CreateModel();
            var n = b.GetLength(1);
            var x = new Decision[n];
            for (var i = 0; i < n; ++i)
            {
                model.AddDecision(x[i] = new Decision(Domain.RealNonnegative, null));

            }

            Term temp = 0;

            for (int i = 0; i < variablesQuantity; i++)
            {
                //este temp+= (Model.Power(x[i], 2));
                if (i == 1 || i == 3)
                {

                    temp += ((x[i]* 2));

                }
               else if (i == 0 || i == 2)
                {
                    temp -= ((x[i]  *2));

                }
            }
            goal = temp;
            Term sumatory = 0.0;
            for (var i = 0; i < n; ++i)
            {
                sumatory += x[i];
            }

            model.AddConstraint("igual1", sumatory = 1.00000);
            int constrainNumber = 0;
            for (int i = 0; i < b.GetLength(1); i++)
            {
                Term a = 0.000;
                for (int j = 0; j < b.GetLength(0); j++)
                {

                    if (i < 3)
                    {

                        a += ((b[j,i]) * x[status]) / (b[posicionacomparar, i]);
                    //    Console.WriteLine("(b[posicionacomparar, i]) " + (b[posicionacomparar, i]));
                    }

                    if (i == 3)
                    {
                        a = a - (((b[j, i]) * x[status]) / (b[j, i]));
                    //    Console.WriteLine("(b[j, i]) " + (b[j, i]));
                    }

                }
                model.AddConstraint("constrain" + constrainNumber, a <= 1.000);
                constrainNumber++;
                status++;
            }

            model.AddGoal(null, GoalKind.Minimize, goal);

            var solution = solver.Solve();
           

            return solution.Goals.First().ToDouble();


        }




    }
}


