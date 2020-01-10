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
    public partial class Packages : Form
    {
        public Packages()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //test
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FlightScreen FS = new FlightScreen();
            FS.Show();
            
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            Home H = new Home();
            H.Show();
            
            
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HotelBooking HotelBook = new HotelBooking();
            HotelBook.Show();
            this.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            CarRent carRent = new CarRent();
            carRent.Show();
            this.Close();
        }
    }
}
