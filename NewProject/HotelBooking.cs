using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewProject
{
    public partial class HotelBooking : Form
    {
        public HotelBooking()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            IWebDriver driver = new FirefoxDriver();

            driver.Navigate().GoToUrl("https://www.skyscanner.com");
            driver.FindElement(By.XPath("//*[@HeaderTab_HeaderTab__text___djus HeaderTab_HeaderTab__text--large__3GG4Z]")).Click();
            driver.FindElement(By.Id("destination-autosuggest")).SendKeys("Muğla");
            driver.FindElement(By.Id("guests - rooms")).SendKeys("room"); 


            var client = new RestSharp.RestClient("https://hotels4.p.rapidapi.com/locations/search?locale=en_US&query=new%20york");
            var request = new RestSharp.RestRequest(RestSharp.Method.GET);
            request.AddHeader("x-rapidapi-host", "hotels4.p.rapidapi.com");
            request.AddHeader("x-rapidapi-key", "6bcc2d1861mshfa70f85a843bbe8p142731jsndc2ac6412dab");
            RestSharp.IRestResponse response = client.Execute(request);

            /*
             * var client = new RestClient("https://hotels4.p.rapidapi.com/locations/search?locale=en_US&query=new%20york");
               var request = new RestRequest(Method.GET);
               request.AddHeader("x-rapidapi-host", "hotels4.p.rapidapi.com");
               request.AddHeader("x-rapidapi-key", "6bcc2d1861mshfa70f85a843bbe8p142731jsndc2ac6412dab");
               IRestResponse response = client.Execute(request);
            */
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

        private void button2_Click(object sender, EventArgs e)
        {
            Packages P = new Packages();
            P.Show();
            this.Close();
        }
    }
}
