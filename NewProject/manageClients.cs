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
    public partial class manageClients : Form
    {
        public manageClients()
        {
            InitializeComponent();
        }

        private void manageClients_Load(object sender, EventArgs e)
        {

        }

        private void historyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cancelledBookings cancel = new cancelledBookings();
            cancel.ShowDialog();
            
        }

        private void manageCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomersInformation CInfor = new CustomersInformation();
            CInfor.ShowDialog();
       
        }

        private void cancelledBookingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
           
        }

        private void financeToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            
        }

        private void mainPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MakeChoice mc = new MakeChoice();
            mc.Show();
            this.Close();
        }

        private void bookingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void bookingHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bookingHistory BHistory = new bookingHistory();
            BHistory.ShowDialog();
        }

        private void finaceHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            financeHistories FH = new financeHistories();
            FH.ShowDialog();
        }

        private void bookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerInformation ci = new CustomerInformation();
            ci.ShowDialog();
        }

        private void financeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Finance fin = new Finance();
            fin.ShowDialog();
        }
    }
}
