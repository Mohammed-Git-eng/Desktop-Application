using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;


namespace NewProject
{
    public class RestSharp

    {
        //public object Method { get; set; }

        static HttpClient client = new HttpClient();

        public void SearchRest()
        {
            /*var client = new RestClient("https://skyscanner-skyscanner-flight-search-v1.p.rapidapi.com/apiservices/browsedates/v1.0/US/USD/en-US/SFO-sky/LAX-sky/2019-09-01?inboundpartialdate=2019-12-01");
            var request = new RestRequest(Method.GET);
            request.AddHeader("x-rapidapi-host", "skyscanner-skyscanner-flight-search-v1.p.rapidapi.com");
            request.AddHeader("x-rapidapi-key", "6bcc2d1861mshfa70f85a843bbe8p142731jsndc2ac6412dab");
            IRestResponse response = client.Execute(request);*/

            



            /*
            var client1 = new RestClient("https://www.skyscanner.com");

            var request1 = new RestRequest("resource/{id}", Method.POST);
            // adds to POST or URL querystring based on Method
            request.AddParameter("application/x-www-form-urlencoded", "inboundDate=2019-09-10&cabinClass=business&children=0&infants=0&country=US&currency=USD&locale=en-US&originPlace=SFO-sky&destinationPlace=LHR-sky&outboundDate=2019-09-01&adults=1", ParameterType.RequestBody);
            request1.AddUrlSegment("resource/{id}", 1); // replaces matching token in request.Resource

            // easily add HTTP Headers
            request.AddHeader("header", "value");
            request.AddHeader("x-rapidapi-host", "skyscanner-skyscanner-flight-search-v1.p.rapidapi.com");
            request.AddHeader("x-rapidapi-key", "6bcc2d1861mshfa70f85a843bbe8p142731jsndc2ac6412dab");
            request.AddHeader("content-type", "application/x-www-form-urlencoded");

            // execute the request
            IRestResponse response = client.Execute(request);
            var content = response.Content; // raw content as string

            // or automatically deserialize result
            // return content type is sniffed but can be explicitly set via RestClient.AddHandler();
            RestResponse<Person> response2 = client.Execute<Person>(request);
            var name = response2.Data.Name;

            // easy async support
            client.ExecuteAsync(request, response => {
                Console.WriteLine(response.Content);
            });

            // async with deserialization
            var asyncHandle = client.ExecuteAsync<Person>(request, response => {
                Console.WriteLine(response.Data.Name);
            });

            // abort the request on demand
            asyncHandle.Abort();
            */


            /*
            var client = new RestClient("https://skyscanner-skyscanner-flight-search-v1.p.rapidapi.com/apiservices/pricing/uk2/v1.0/%7Bsessionkey%7D?pageIndex=0&pageSize=10");
            var request = new RestRequest(Method.GET);
            request.AddHeader("x-rapidapi-host", "skyscanner-skyscanner-flight-search-v1.p.rapidapi.com");
            request.AddHeader("x-rapidapi-key", "6bcc2d1861mshfa70f85a843bbe8p142731jsndc2ac6412dab");
           // IRestResponse response = client.Execute(request);
            var response = client.Execute(request);
            
            */
        }

        static async Task<Uri> GetProductAsync(string path)
        {
            Uri product = null;
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                product = await response.Content.ReadAsAsync<Uri>();
            }
            return product;
        }

        internal class ParameterType
        {
            internal static object RequestBody;
        }

        internal void Show()
        {
            throw new NotImplementedException();
        }

        private class RestClient
        {
            private string v;

            public RestClient(string v)
            {
                this.v = v;
            }

            internal object Execute(RestRequest request)
            {
                throw new NotImplementedException();
            }

            internal IRestResponse Execute(RestRequest request)
            {
                throw new NotImplementedException();
            }

           
        }

        private class RestRequest
        {
            private object POST;

            public RestRequest(object POST)
            {
                this.POST = POST;
            }

            internal void AddHeader(string v1, string v2)
            {
                throw new NotImplementedException();
            }

            internal void AddParameter(string v1, string v2, object requestBody)
            {
                throw new NotImplementedException();
            }
        }

        public interface IRestRequest
        {
        }
    }
}
