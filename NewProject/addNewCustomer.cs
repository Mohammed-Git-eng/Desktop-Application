using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;

namespace NewProject
{
    public partial class addNewCustomer : MetroFramework.Forms.MetroForm
    {
        public addNewCustomer(Customerss obj)
        {
            InitializeComponent();
            bindingSourceCustomer.DataSource = obj;

            if (checkGender.CheckState == CheckState.Checked)
                checkGender.Text = "Male";
            else if (checkGender.CheckState == CheckState.Unchecked)
                checkGender.Text = "Female";
            else
                checkGender.Text = "???";
        }

        public Customerss CustomerInfor { get { return bindingSourceCustomer.Current as Customerss;  } }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            bindingSourceCustomer.EndEdit();
            DialogResult = DialogResult.OK;
        }

        private void checkGender_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkGender.CheckState == CheckState.Checked)
                checkGender.Text = "Male";
            else if (checkGender.CheckState == CheckState.Unchecked)
                checkGender.Text = "Female";
            else
                checkGender.Text = "???";
        }

        private void addNewCustomer_Load(object sender, EventArgs e)
        {
            comboCity.DisplayMember = "CityName";
            comboCity.ValueMember = "CityId";
            //comboPackage.DisplayMember = "PackageName";
            //comboPackage.ValueMember = "PackageId";

            
            using (dbModel db = new dbModel())
            {
                comboCity.DataSource = db.Cities.ToList();
                //comboPackage.DataSource = db.Packages.ToList();

                
            }
        }
    }
}
