using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Data.SqlClient;
using RestSharp;
using MySql.Data.MySqlClient;

namespace NewProject
{
    public partial class Home : Form
    {
        
        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           /*

            CONNECT conn = new CONNECT();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand();
            String query = "SELECT * FROM `users` WHERE `username`=@usn AND `password`=@pass";

            command.CommandText = query;
            command.Connection = conn.getConnection();

            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = textLogin.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = textPassword.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            // if the username and the password exists
            if(table.Rows.Count > 0)
            {
                // show the main form
                this.Hide();
                MakeChoice FS = new MakeChoice();
                FS.Show();
                
            }
            else
            {
                if(textLogin.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Enter Your Username to Login", "Empty Username", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (textPassword.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Enter Your Password to Login", "Empty Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("This Username Or Password Doesn't Exists", "Wrong Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        
            */

            /*
            SqlConnection sql = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\muhmmed.CASPER_NIRVANA\Documents\4 year\Senior desgn Project\AirTicket\DB\dataBase.mdf;Integrated Security=True;Connect Timeout=30");

           //SqlConnection sql = new SqlConnection(@"Data Source=(LocalDB)\MyDatabase;AttachDbFilename=|DataDirectory|\dataBase.mdf;Integrated Security=True");
            //run on command prompt; sqllocaldb create MyDatabase and sqllocaldb start MyDatabase

            string query = "Select * from dbo.Table Where username = '" + textLogin.Text.Trim() + "' and password = '" + textPassword.Text.Trim() + "'";
            SqlDataAdapter sqAda = new SqlDataAdapter(query, sql);
            DataTable dtable = new DataTable();
            sqAda.Fill(dtable);

            if (dtable.Rows.Count == 1 )
            {
                Home objFromMain = new Home();
                this.Hide();
                objFromMain.Show();
            }
            else
            {
                MessageBox.Show("Check login credentials and try again");

            }

            */



            
             // tryıng something Different
            string loginName = textLogin.Text;
            string Password = textPassword.Text;


            if (loginName == "Admin" && Password == "123456")
            {
               
                MakeChoice FS = new MakeChoice();
                FS.Show();
                this.Hide();


            }
            else
            {
                MessageBox.Show("Please Check the Login Credentials and try again");
            }
            


        }

     

        private void Home_Load(object sender, EventArgs e)
        {
           
        }

        private void cancel_Btn_Click(object sender, EventArgs e)
        {
            Home H = new Home();
            H.Show();
            this.Close();

            // this.Close();
        }

        private void textLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void textPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
