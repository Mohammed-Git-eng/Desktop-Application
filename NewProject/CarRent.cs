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
    public partial class CarRent : Form
    {
        public CarRent()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            IWebDriver driver = new FirefoxDriver();

            driver.Navigate().GoToUrl("https://www.skyscanner.com");

            driver.FindElement(By.Id("carhire-search-controls-location-pick-up")).SendKeys("Kotekli");
            driver.FindElement(By.Id("airport-transfers-search-controls-location-drop-off")).SendKeys("Bodrum");
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
