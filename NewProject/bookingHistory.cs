using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;

namespace NewProject
{
    public partial class bookingHistory : MaterialSkin.Controls.MaterialForm
    {
        public bookingHistory()
        {
            InitializeComponent();
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void bookingHistory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'historyDataSet.bookedHistory' table. You can move, or remove it, as needed.
            this.bookedHistoryTableAdapter.Fill(this.historyDataSet.bookedHistory);
            Edit(false);
        }
        private void Edit(Boolean value)
        {
            textCustomer.Enabled = value;
            textBooked.Enabled = value;
            textDeparture.Enabled = value;
            textArrival.Enabled = value;
            textCost.Enabled = value;
            textEmail.Enabled = value;
            textPhone.Enabled = value;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                Edit(true);
                historyDataSet.bookedHistory.AddbookedHistoryRow(historyDataSet.bookedHistory.NewbookedHistoryRow());
                bookedHistoryBindingSource.MoveLast();
                textPhone.Focus();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                historyDataSet.bookedHistory.RejectChanges();


            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Edit(true);
            textPhone.Focus();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Edit(false);
            bookedHistoryBindingSource.ResetBindings(false);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Edit(false);
                bookedHistoryBindingSource.EndEdit();
                bookedHistoryTableAdapter.Update(historyDataSet.bookedHistory);
                dataGridView.Refresh();
                textPhone.Focus();
                MessageBox.Show("Your Message has been successfully Saved","Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                historyDataSet.bookedHistory.RejectChanges();


            }
        }
        //CellContentClick

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        /*
        private void dataGridView_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)13)//enter
            {
                if (MessageBox.Show("Are you sure You want to delete This record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    bookedHistoryBindingSource.RemoveCurrent();
            }
        }
        */

        private void textSearch_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textSearch_KeyDown(object sender, KeyEventArgs e)
        {
           if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrEmpty(textSearch.Text))
                    bookedHistoryBindingSource.Filter = string.Format("customerName = '{0}' OR bookedItem LIKE '*{1}*' OR totalCost = '{2}' OR emailAddress LIKE '*{3}*' ", textCustomer.Text, textBooked.Text, textDeparture.Text, textArrival.Text, textCost.Text, textEmail.Text, textPhone.Text);
                else
                    bookedHistoryBindingSource.Filter = string.Empty;
            }
           
        }

        private void dataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show("Are you sure You want to delete This record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    bookedHistoryBindingSource.RemoveCurrent();

            } 
        }
    }
}
