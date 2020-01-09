using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace NewProject
{
    
    public partial class CustomerInformation : Form
    {
        // CLIENTS client = new CLIENTS();
        //Data Source=CASPER_NIRVANA;Integrated Security=True

        SqlConnection sqlcon = new SqlConnection(@"Data Source=CASPER_NIRVANA\SQLEXPRESS;Initial Catalog=customer;Integrated Security=True");

        int id = 0;
        public CustomerInformation()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                sqlcon.Open();
                String firstName = textBoxFirstName.Text.ToString();
                String qry = "delete from CustomerInfor where sname='" + firstName + "'";
                SqlCommand sc = new SqlCommand(qry, sqlcon);
                int i = sc.ExecuteNonQuery();
                if (i >= 1)
                    MessageBox.Show(i + " Customer Deleted Successfully : " + firstName);
                else
                    MessageBox.Show(" Customer  Deletion Failed..... ");
                button1_Click(sender, e);
                show();
                sqlcon.Close();
            }
            catch (System.Exception exp)
            {
                MessageBox.Show(" Error is  " + exp.ToString());

            }

            /*
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
             
                    sqlcon.Open();
                    
                        SqlCommand sqlcmd = new SqlCommand(customerDeletion.sqlcon);
                        sqlcmd.CommandType = CommandType.StoredProcedure;
                        sqlcmd.Parameters.AddWithValue("@id", ID);
                        
                       
                        sqlcmd.ExecuteNonQuery();
                        MessageBox.Show("Deleted Successfully");
                Reset();
                FillDataGridView();

           
             }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "error message");
            }
            */

            /*
                try
                {
                    int id = Convert.ToInt32(textBoxID.Text);

                    if (client.removeClient(id))
                    {
                        dataGridView1.DataSource = client.getClients();
                        MessageBox.Show("Client Deleted Successfuly", "Delete Client", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // you can clear all textboxes after the delete if you want
                        // by calling the clear button
                        buttonClear.PerformClick();

                    }
                    else
                    {
                        MessageBox.Show("ERROR - Client Not Deleted", "Delete Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ID Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            */
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBoxID.Text = "";
            textBoxFirstName.Text = "";
            textBoxLastName.Text = "";
            textBoxPhone.Text = "";
            textBoxCountry.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                sqlcon.Open();
                String Id = textBoxID.Text.ToString();
                String firstName = textBoxFirstName.Text.ToString();
                String lastName = textBoxLastName.Text.ToString();
                String phone = textBoxPhone.Text.ToString();
                long iphone = Int64.Parse(phone);
                String country = textBoxCountry.Text.ToString();

                String qry = "insert into CustomerInfor values('" + id + "','" + firstName + "','" + lastName + "'," + phone + ",'" + country + "' )";
                SqlCommand sc = new SqlCommand(qry, sqlcon);
                int i = sc.ExecuteNonQuery();
                if (i >= 1)
                    MessageBox.Show(i + " Customer Info Updated Successfully : " + firstName);
                else
                    MessageBox.Show(" CustomerInfo  Updation Failed..... ");
                button1_Click(sender, e);
                show();
                sqlcon.Close();
            }
            catch (System.Exception exp)
            {
                MessageBox.Show(" Error is  " + exp.ToString());

            }


        }
        void show()
        {

            SqlDataAdapter sda = new SqlDataAdapter("select * from CustomerInfor ", sqlcon);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.Rows.Clear();
            foreach (DataRow dr in dt.Rows)
            {

                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = dr[0].ToString();
                dataGridView1.Rows[n].Cells[1].Value = dr[1].ToString();
                dataGridView1.Rows[n].Cells[2].Value = dr[2].ToString();
                dataGridView1.Rows[n].Cells[3].Value = dr[3].ToString();
                dataGridView1.Rows[n].Cells[4].Value = dr[4].ToString();

            }
        }

        /*
        private void button1_Click(object sender, EventArgs e)
        {
            
            String fname = textBoxFirstName.Text;
            String lname = textBoxLastName.Text;
            String phone = textBoxPhone.Text;
            String country = textBoxCountry.Text;

            if (fname.Trim().Equals("") || lname.Trim().Equals("") || phone.Trim().Equals(""))
            {
                MessageBox.Show("Required Fields - First & Last Name + Phone Number", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Boolean insertClient = client.insertClient(fname, lname, phone, country);

                if (insertClient)
                {
                    dataGridView1.DataSource = client.getClients();
                    MessageBox.Show("New Client Inserted Successfuly", "Add Client", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("ERROR - Client Not Inserted", "Add Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            
        }
        */
        private void button1_Click(object sender, EventArgs e)
        {
           try
            {
                sqlcon.Open();
                String firstName = textBoxFirstName.Text.ToString();
                String lastName = textBoxLastName.Text.ToString();
                String phone = textBoxPhone.Text.ToString();
                
                long Phone = Int64.Parse(phone);
                String country = textBoxCountry.Text.ToString();

                //MessageBox.Show("id: "+ID+" FN : "+firstName+", LN: "+lastName+", Phone : " +phone+", contry: "+country );
                
                //combo box creation
              
                //String branch = comboBox1.SelectedItem.ToString();
                 String qry = "insert into CustomerInfor values('" + id + "','" + firstName + "','" + lastName + "'," + phone + ",'" + country+"' )";
               
                SqlCommand sc = new SqlCommand(qry, sqlcon);
                int i = sc.ExecuteNonQuery();
                if (i >= 1)
                    MessageBox.Show(i + " Student Registerd Successfully : " + firstName);
                else
                    MessageBox.Show(" Student is not Registered: ");

                button1_Click(sender, e);

                show();

                //sqlcon.Close();
                

           }
            catch (System.Exception exp)
            {
               MessageBox.Show(" Error is  " + exp.ToString());


            }
            finally
            {
                sqlcon.Close();
            }

          
        }
        

       
        private void button5_Click(object sender, EventArgs e)
        {
            /*
            
            try
            {
                FillDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error message");

            }
            */
            
        }

        //CellContentClick
        private void dataGridView1_MouseClick(object sender,MouseEventArgs e)
        {

            /*
                textBoxID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                textBoxFirstName.Text = dataGridView1.SelectedRows[1].Cells[1].Value.ToString();
                textBoxLastName.Text = dataGridView1.SelectedRows[2].Cells[2].Value.ToString();
                textBoxCountry.Text = dataGridView1.SelectedRows[3].Cells[3].Value.ToString();
                textBoxPhone.Text = dataGridView1.SelectedRows[4].Cells[4].Value.ToString();
            */

            /*
            if(dataGridView1.CurrentRow.Index != -1)
            {
                textBoxID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textBoxFirstName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBoxLastName.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textBoxCountry.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                textBoxPhone.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                btnSearch.Text = "Update";
                btnRemove.Enabled = true;
                


            }
            */
        }
        /*
        void Reset()
        {
            textBoxFirstName.Text = textBoxLastName.Text = textBoxPhone.Text = textBoxCountry.Text = "";
            btnSave.Text = "Save";
            ID = 0;
            btnRemove.Enabled = false;
        }
        */
        private void btnReset_Click(object sender, EventArgs e)
        {
            

        }
        

        private void CustomerInformation_Load(object sender, EventArgs e)
        {
            /*
            Reset();
            FillDataGridView();
            */
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            sqlcon.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select * from customerInfor where sname like '%" + textBoxSearch.Text.ToString() + "%'", sqlcon);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.Rows.Clear();
            foreach (DataRow dr in dt.Rows)
            {

                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = dr[0].ToString();
                dataGridView1.Rows[n].Cells[1].Value = dr[1].ToString();
                dataGridView1.Rows[n].Cells[2].Value = dr[2].ToString();
                dataGridView1.Rows[n].Cells[3].Value = dr[3].ToString();
                dataGridView1.Rows[n].Cells[4].Value = dr[4].ToString();

            }

        }

        private void textBoxID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
