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
    public partial class CustomersInformation : MetroFramework.Forms.MetroForm
    {
        public CustomersInformation()
        {
            InitializeComponent();
        }

        private async void mtAdd_Click(object sender, EventArgs e)
        {
            using(addNewCustomer add = new addNewCustomer(new Customerss() { Gender=false} ))
            {
               // add.ShowDialog();
               if (add.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        //customerBindingSource.Add(add.CustomerInfor);
                        customerBindingSource.Add(add.CustomerInfor);
                        db.Customersses.Add(add.CustomerInfor);
                        await db.SaveChangesAsync();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void mtRefresh_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            customerBindingSource.DataSource = db.Customersses.ToList();
            cityBindingSource.DataSource = db.Cities.ToList();
            Cursor.Current = Cursors.Default;
        }

        dbModel db;
        
        
        private async void mtSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do you want to Save the Changes?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    customerBindingSource.EndEdit();
                    await db.SaveChangesAsync();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CustomersInformation_Load(object sender, EventArgs e)
        {
            db = new dbModel();
            //customerBindingSource.DataSource = db.Customers.ToList();
            customerBindingSource.DataSource = db.Customersses.ToList();
            cityBindingSource.DataSource = db.Cities.ToList();
        }

        private async void mtEdit_Click(object sender, EventArgs e)
        {
            Customerss obj = customerBindingSource.Current as Customerss;
            if (obj != null)
            {
                using(addNewCustomer add = new addNewCustomer(obj))
                {
                    if (add.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            customerBindingSource.EndEdit();
                            await db.SaveChangesAsync();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void mtDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to Delete Record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int rows = dataGridViewer.RowCount;
                for (int i = rows - 1; i >= 0; i--)
                {
                    if (dataGridViewer.Rows[i].Selected)
                    {
                        db.Customersses.Remove(dataGridViewer.Rows[i].DataBoundItem as Customerss);
                        customerBindingSource.RemoveAt(dataGridViewer.Rows[i].Index);
                    }
                }
            }
        }

        private void dataGridViewer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
