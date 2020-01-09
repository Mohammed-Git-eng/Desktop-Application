using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;

namespace NewProject
{
    class ConsoleTest
    {
        public class dataObject
        {
            public string Name { get; set; }
        }

        public class class1
        {
            private const string URL = "https://rapidapi.com/";

            private string urlParameters = "6bcc2d1861mshfa70f85a843bbe8p142731jsndc2ac6412dab";
            
            static void Main (String [] args)
            {
                HttpClient Client = new HttpClient();
                Client.BaseAddress = new Uri(URL);
                Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = Client.GetAsync(urlParameters).Result;

                if (response.IsSuccessStatusCode)
                {
                    var dataObjects = response.Content.ReadAsAsync<IEnumerable<dataObject>>().Result;

                    foreach (var d in dataObjects)
                    {
                        Console.WriteLine("{0}", d.Name);
                    }
                }
                else
                {
                    Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
                }

                Client.Dispose();
            }

            
        }
    }
}
