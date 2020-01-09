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
    public partial class MakeChoice : Form
    {
        public MakeChoice()
        {
            InitializeComponent();
        }

        private void home_btn_Click(object sender, EventArgs e)
        {
            Packages P = new Packages();
            P.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            RecordDatabase RDB = new RecordDatabase();
            RDB.Show();
            this.Hide();
            */

        }

        private void History_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            manageClients mc = new manageClients();
            mc.Show();
        }

        private void searchPack_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            manageClients mc = new manageClients();
            mc.Show();
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            manageClients mc = new manageClients();
            mc.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            manageClients mc = new manageClients();
            mc.Show();
        }
    }
}
