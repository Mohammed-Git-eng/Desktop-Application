using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web.UI;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Imaging;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace NewProject
{


    public partial class FlightScreen : Form
    {

        // private readonly object client;

        public FlightScreen()
        {
            InitializeComponent();
            ComboBox mybox = new ComboBox();
            //List<mybox> products = new List<mybox>();
            string curdir = Directory.GetCurrentDirectory();
           // string filename = @"C:\Projects\ProductSales\ProductSales\Data\productdetails.csv";
            mybox.Visible = false;


            


        }


        private void ContactScreen_Load(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Packages P = new Packages();
            P.Show();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }



        private void search_btn_Click(object sender, EventArgs e)
        {
            IWebDriver driver = new FirefoxDriver();
            
            driver.Navigate().GoToUrl("https://www.skyscanner.com");

            // driver.Url = "https://www.skyscanner.com";
            // driver.Manage().Window.Maximize();
            // driver.Manage().Timeouts().ImplicitWait(TimeSpan.FromSeconds(10));

            driver.FindElement(By.Id("fsc-origin-search")).SendKeys("Bodrum");
            driver.FindElement(By.Id("fsc-destination-search")).SendKeys("Istanbul" + System.Windows.Forms.Keys.Enter);

            

            // System.Diagnostics.Process.Start("https://www.skyscanner.com.tr/");

            /*
           //Get Request
           ServicePointManager.Expect100Continue = true;
           ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

           string connectUrl = String.Format("https://www.skyscanner.com.tr/hotels?na=1&sd=2019-12-11&ed=2019-12-18&locale=en-GB");
           WebRequest requestObjectGet = WebRequest.Create(connectUrl);

           requestObjectGet.Method = "GET";
           HttpWebResponse responseObjectGet = null;

           responseObjectGet = (HttpWebResponse)requestObjectGet.GetResponse();

           string stringResultTest = null;
           using (Stream stream = responseObjectGet.GetResponseStream())
           {
               StreamReader sr = new StreamReader(stream);
               stringResultTest = sr.ReadToEnd();
               sr.Close();
           }


           //Post Request
           string strUrl = String.Format("https://www.skyscanner.com.tr/hotels?na=1&sd=2019-12-11&ed=2019-12-18&locale=en-GB");
           WebRequest requestObjectPost = WebRequest.Create(strUrl);
           requestObjectPost.Method = "POST";

           requestObjectPost.ContentType = "application/json";

           string postData = null;
           using (var streamWriter = new StreamWriter (requestObjectPost.GetRequestStream()))
           {
               streamWriter.Write(postData);
               streamWriter.Flush();
               streamWriter.Close();

               var httpResponse = (HttpWebResponse)requestObjectPost.GetResponse();
               using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
               {
                   var result2 = streamReader.ReadToEnd();

               }

           }
                 */

            /*
            var client1 = new RestClient("https://skyscanner-skyscanner-flight-search-v1.p.rapidapi.com/apiservices/browsedates/v1.0/US/USD/en-US/SFO-sky/LAX-sky/2019-09-01?inboundpartialdate=2019-12-01");
          //var request = new RestRequest(Method.GET);
            var request = new RestSharp.RestRequest(Method.GET);
            request.AddHeader("x-rapidapi-host", "skyscanner-skyscanner-flight-search-v1.p.rapidapi.com");
            request.AddHeader("x-rapidapi-key", "6bcc2d1861mshfa70f85a843bbe8p142731jsndc2ac6412dab");
            RestSharp.IRestResponse response = client.Execute(request);




           var client = new RestClient("https://skyscanner-skyscanner-flight-search-v1.p.rapidapi.com/apiservices/pricing/v1.0");
           var request = new RestRequest(Method.POST);
           //var request = new RestSharp.RestRequest(Method.POST);
           request.AddHeader("x-rapidapi-host", "skyscanner-skyscanner-flight-search-v1.p.rapidapi.com");
           request.AddHeader("x-rapidapi-key", "6bcc2d1861mshfa70f85a843bbe8p142731jsndc2ac6412dab");
           request.AddHeader("content-type", "application/x-www-form-urlencoded");
           request.AddParameter("application/x-www-form-urlencoded", "inboundDate=2019-09-10&cabinClass=business&children=0&infants=0&country=US&currency=USD&locale=en-US&originPlace=SFO-sky&destinationPlace=LHR-sky&outboundDate=2019-09-01&adults=1", ParameterType.RequestBody);
           IRestResponse response = client.Execute(request);
           // IRestResponse response = (IRestResponse)client.Execute(request);

         */


        }
        
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;       
            /*
            ComboBox comboBox = (ComboBox)sender;

            string selectedItems = (string)comboBox.SelectedItem;

            int count = 0;
            int resultIndex = -1;

            resultIndex = comboBox1.FindStringExact(selectedItems);

            while (resultIndex != -1)
            {
                comboBox1.Items.RemoveAt(resultIndex);
                count += 1;
                resultIndex = comboBox1.FindStringExact(selectedItems,
                    resultIndex);
            }
            */

            var client = new RestClient("https://skyscanner-skyscanner-flight-search-v1.p.rapidapi.com/apiservices/pricing/v1.0");
           // var request = new RestRequest(Method.POST);
            var request = new RestSharp.RestRequest(Method.POST);
            request.AddHeader("x-rapidapi-host", "skyscanner-skyscanner-flight-search-v1.p.rapidapi.com");
            request.AddHeader("x-rapidapi-key", "6bcc2d1861mshfa70f85a843bbe8p142731jsndc2ac6412dab");
            request.AddHeader("content-type", "application/x-www-form-urlencoded");
            request.AddParameter("application/x-www-form-urlencoded", "inboundDate=2019-09-10&cabinClass=business&children=0&infants=0&country=US&currency=USD&locale=en-US&originPlace=SFO-sky&destinationPlace=LHR-sky&outboundDate=2019-09-01&adults=1", ParameterType.RequestBody);
            //IRestResponse response = client.Execute(request);
            IRestResponse response = (IRestResponse)client.Execute(request);
        

            /*
            var client = new RestClient("https://skyscanner-skyscanner-flight-search-v1.p.rapidapi.com/apiservices/autosuggest/v1.0/accra/GBP/en-GB/?query=istanbul");
            //var request = new RestRequest(Method.GET);
            var request = new RestSharp.RestRequest(Method.GET);
            request.AddHeader("x-rapidapi-host", "skyscanner-skyscanner-flight-search-v1.p.rapidapi.com");
            request.AddHeader("x-rapidapi-key", "6bcc2d1861mshfa70f85a843bbe8p142731jsndc2ac6412dab");
           // IRestResponse response = client.Execute(request);
            IRestResponse response = (IRestResponse) client.Execute(request);
            */
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;

            HttpWebRequest webRequest = WebRequest.Create(@"https://maps.googleapis.com/maps/api/place/search/json?location=-33.8670522,151.1957362&radius=7500&types=library&sensor=false&key=AIzaSyD3jfeMZK1SWfRFDgMfxn_zrGRSjE7S8Vg") as HttpWebRequest;
            webRequest.Timeout = 20000;
            webRequest.Method = "GET";

            webRequest.BeginGetResponse(new AsyncCallback(RequestCompleted), webRequest);
          
        }
        private void RequestCompleted(IAsyncResult result)
        {
            var request = (HttpWebRequest)result.AsyncState;
            var response = (HttpWebResponse)request.EndGetResponse(result);
            using (var stream = response.GetResponseStream())
            {
                var r = new StreamReader(stream);
                var resp = r.ReadToEnd();
            }

        }

       

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

            DateTimePicker dateTimePicker1 = new DateTimePicker();
            
            dateTimePicker1.MinDate = new DateTime(2019, 12, 15);
            dateTimePicker1.MaxDate = DateTime.Today;
            
            dateTimePicker1.CustomFormat = "MMMM dd, yyyy - dddd";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;

            dateTimePicker1.ShowCheckBox = true;
            dateTimePicker1.ShowUpDown = true;


            var client = new RestClient("https://skyscanner-skyscanner-flight-search-v1.p.rapidapi.com/apiservices/browsedates/v1.0/US/USD/en-US/SFO-sky/LAX-sky/2019-09-01?inboundpartialdate=2019-12-01");
            var request = new RestSharp.RestRequest(Method.GET);
            request.AddHeader("x-rapidapi-host", "skyscanner-skyscanner-flight-search-v1.p.rapidapi.com");
            request.AddHeader("x-rapidapi-key", "6bcc2d1861mshfa70f85a843bbe8p142731jsndc2ac6412dab");
            IRestResponse response = (IRestResponse) client.Execute(request);

            


        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker dateTimePicker1 = new DateTimePicker();
            dateTimePicker1.MinDate = new DateTime(2019, 12, 15);
            dateTimePicker1.MaxDate = DateTime.Today;
            dateTimePicker1.CustomFormat = "MMMM dd, yyyy - dddd";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.ShowCheckBox = true;
            dateTimePicker1.ShowUpDown = true;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown1.Hexadecimal)
            {
                numericUpDown1.Hexadecimal = false;
            }
            else
            {
                numericUpDown1.Hexadecimal = true;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
