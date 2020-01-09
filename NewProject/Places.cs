using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace NewProject
{
    class Places
    {

        static HttpClient client = new HttpClient();

        public void var()
        {
            
            var client = new RestClient("https://skyscanner-skyscanner-flight-search-v1.p.rapidapi.com/apiservices/autosuggest/v1.0/accra/GBP/en-GB/?query=istanbul");
            var request = new RestRequest(Method.GET);
            request.AddHeader("x-rapidapi-host", "skyscanner-skyscanner-flight-search-v1.p.rapidapi.com");
            request.AddHeader("x-rapidapi-key", "6bcc2d1861mshfa70f85a843bbe8p142731jsndc2ac6412dab");
            IRestResponse response = client.Execute(request);
            
        }

        //static void Run()
        /*
        static async Task RunAsync()
        {
            // Update port # in the following line.
            client.BaseAddress = new Uri("https://rapidapi.com/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }
        */

        static async Task<Uri> GetProductAsync(string path)
        {
            Uri product = null;
            HttpResponseMessage response = await client.GetAsync("https://rapidapi.com/");
            if (response.IsSuccessStatusCode)
            {
                product = await response.Content.ReadAsAsync<Uri>();
            }
            return product;
        }

        internal void Show()
        {
            throw new NotImplementedException();
        }

        private interface IRestResponse
        {

        }

        private class RestRequest
        {
            private object gET;

            public RestRequest(object gET)
            {
                this.gET = gET;
            }

            internal void AddHeader(string v1, string v2)
            {
                throw new NotImplementedException();
            }
        }

        private class RestClient
        {
            private string v;

            public RestClient(string v)
            {
                this.v = v;
            }

            internal IRestResponse Execute(RestRequest request)
            {
                throw new NotImplementedException();
            }
        }
    }
}
