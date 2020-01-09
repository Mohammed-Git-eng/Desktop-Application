using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace NewProject
{
    public partial class Finance : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source=CASPER_NIRVANA\SQLEXPRESS;Initial Catalog=customer;Integrated Security=True");


        public Finance()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                sqlcon.Open();
                
                String customerName = textBoxCustomerName.Text.ToString();
                String package = comboBoxPackage.SelectedItem.ToString();

                //combo box creation

                //String branch = comboBox1.SelectedItem.ToString();
                String packageCost = textBoxPackageCost.Text.ToString();
                long ipc = Int64.Parse(packageCost);

                String paidAmount = textBoxPaidAmount.Text.ToString();
                long ipa = Int64.Parse(paidAmount);

                String balances = textBoxBalances.Text.ToString();
                long b = Int64.Parse(balances);
                

               // MessageBox.Show(" Name : "+customerName+", Package : "+ package +", PCost : " +packageCost+ ", pAmount : " + paidAmount + ", Balance: " + balances );

                String qry = "insert into finance values('" + customerName + "','" + package + "','" + ipc + "'," + ipa + ",'" + b + "' )";

                SqlCommand sc = new SqlCommand(qry, sqlcon);

                int i = sc.ExecuteNonQuery();
                if (i >= 1)
                    MessageBox.Show(i + " Customer Payment Information recorded Successfully : " + customerName);
                else
                    MessageBox.Show(" Customer payment record Error: ");

                /*
               

                

                show();

                //sqlcon.Close();
                */

                button4_Click(sender, e);

                
            }
            catch (System.Exception exp)
            {
                MessageBox.Show(" Error is  " + exp.ToString());


            }
            /*
            finally
            {
                sqlcon.Close();
            }
            */
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.textBoxCustomerName.Text = "";
            comboBoxPackage.SelectedIndex = -1;
            textBoxPackageCost.Text = "";
            textBoxPaidAmount.Text = "";
            textBoxBalances.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }
    }
}
