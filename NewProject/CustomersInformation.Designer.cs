namespace NewProject
{
    partial class CustomersInformation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.metroUserControl1 = new MetroFramework.Controls.MetroUserControl();
            this.mtRefresh = new MetroFramework.Controls.MetroTile();
            this.mtAdd = new MetroFramework.Controls.MetroTile();
            this.mtEdit = new MetroFramework.Controls.MetroTile();
            this.mtDelete = new MetroFramework.Controls.MetroTile();
            this.mtSave = new MetroFramework.Controls.MetroTile();
            this.dataGridViewer = new System.Windows.Forms.DataGridView();
            this.cityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerssBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotelNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CityIdDataGridViewComboBox = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.packageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrivalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fromDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerssBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // metroUserControl1
            // 
            this.metroUserControl1.Location = new System.Drawing.Point(226, 49);
            this.metroUserControl1.Name = "metroUserControl1";
            this.metroUserControl1.Size = new System.Drawing.Size(8, 8);
            this.metroUserControl1.TabIndex = 0;
            // 
            // mtRefresh
            // 
            this.mtRefresh.BackColor = System.Drawing.Color.Transparent;
            this.mtRefresh.Location = new System.Drawing.Point(6, 83);
            this.mtRefresh.Name = "mtRefresh";
            this.mtRefresh.Size = new System.Drawing.Size(62, 49);
            this.mtRefresh.TabIndex = 1;
            this.mtRefresh.Text = "Refresh";
            this.mtRefresh.Click += new System.EventHandler(this.mtRefresh_Click);
            // 
            // mtAdd
            // 
            this.mtAdd.Location = new System.Drawing.Point(91, 83);
            this.mtAdd.Name = "mtAdd";
            this.mtAdd.Size = new System.Drawing.Size(62, 49);
            this.mtAdd.TabIndex = 2;
            this.mtAdd.Text = "Add";
            this.mtAdd.Click += new System.EventHandler(this.mtAdd_Click);
            // 
            // mtEdit
            // 
            this.mtEdit.Location = new System.Drawing.Point(181, 83);
            this.mtEdit.Name = "mtEdit";
            this.mtEdit.Size = new System.Drawing.Size(62, 49);
            this.mtEdit.TabIndex = 3;
            this.mtEdit.Text = "Edit";
            this.mtEdit.Click += new System.EventHandler(this.mtEdit_Click);
            // 
            // mtDelete
            // 
            this.mtDelete.Location = new System.Drawing.Point(265, 83);
            this.mtDelete.Name = "mtDelete";
            this.mtDelete.Size = new System.Drawing.Size(62, 49);
            this.mtDelete.TabIndex = 4;
            this.mtDelete.Text = "Delete";
            this.mtDelete.Click += new System.EventHandler(this.mtDelete_Click);
            // 
            // mtSave
            // 
            this.mtSave.Location = new System.Drawing.Point(353, 83);
            this.mtSave.Name = "mtSave";
            this.mtSave.Size = new System.Drawing.Size(62, 49);
            this.mtSave.TabIndex = 5;
            this.mtSave.Text = "Save";
            this.mtSave.Click += new System.EventHandler(this.mtSave_Click);
            // 
            // dataGridViewer
            // 
            this.dataGridViewer.AutoGenerateColumns = false;
            this.dataGridViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerIdDataGridViewTextBoxColumn,
            this.fullNameDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.hotelNameDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.addressDataGridViewTextBoxColumn,
            this.CityIdDataGridViewComboBox,
            this.packageDataGridViewTextBoxColumn,
            this.cityIdDataGridViewTextBoxColumn,
            this.departureDataGridViewTextBoxColumn,
            this.arrivalDataGridViewTextBoxColumn,
            this.fromDataGridViewTextBoxColumn,
            this.toDataGridViewTextBoxColumn,
            this.totalCostDataGridViewTextBoxColumn});
            this.dataGridViewer.DataSource = this.customerssBindingSource;
            this.dataGridViewer.Location = new System.Drawing.Point(6, 146);
            this.dataGridViewer.Name = "dataGridViewer";
            this.dataGridViewer.Size = new System.Drawing.Size(1381, 448);
            this.dataGridViewer.TabIndex = 6;
            this.dataGridViewer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewer_CellContentClick);
            // 
            // cityBindingSource
            // 
            this.cityBindingSource.DataSource = typeof(NewProject.City);
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataSource = typeof(NewProject.Customerss);
            // 
            // customerssBindingSource
            // 
            this.customerssBindingSource.DataSource = typeof(NewProject.Customerss);
            // 
            // customerIdDataGridViewTextBoxColumn
            // 
            this.customerIdDataGridViewTextBoxColumn.DataPropertyName = "CustomerId";
            this.customerIdDataGridViewTextBoxColumn.HeaderText = "CustomerId";
            this.customerIdDataGridViewTextBoxColumn.Name = "customerIdDataGridViewTextBoxColumn";
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "FullName";
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            // 
            // hotelNameDataGridViewTextBoxColumn
            // 
            this.hotelNameDataGridViewTextBoxColumn.DataPropertyName = "HotelName";
            this.hotelNameDataGridViewTextBoxColumn.HeaderText = "HotelName";
            this.hotelNameDataGridViewTextBoxColumn.Name = "hotelNameDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CarDetails";
            this.dataGridViewTextBoxColumn1.HeaderText = "CarDetails";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // CityIdDataGridViewComboBox
            // 
            this.CityIdDataGridViewComboBox.DataPropertyName = "CityId";
            this.CityIdDataGridViewComboBox.DataSource = this.cityBindingSource;
            this.CityIdDataGridViewComboBox.DisplayMember = "CityName";
            this.CityIdDataGridViewComboBox.HeaderText = "City";
            this.CityIdDataGridViewComboBox.Name = "CityIdDataGridViewComboBox";
            this.CityIdDataGridViewComboBox.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CityIdDataGridViewComboBox.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.CityIdDataGridViewComboBox.ValueMember = "CityId";
            // 
            // packageDataGridViewTextBoxColumn
            // 
            this.packageDataGridViewTextBoxColumn.DataPropertyName = "Package";
            this.packageDataGridViewTextBoxColumn.HeaderText = "Package";
            this.packageDataGridViewTextBoxColumn.Name = "packageDataGridViewTextBoxColumn";
            // 
            // cityIdDataGridViewTextBoxColumn
            // 
            this.cityIdDataGridViewTextBoxColumn.DataPropertyName = "CityId";
            this.cityIdDataGridViewTextBoxColumn.HeaderText = "CityId";
            this.cityIdDataGridViewTextBoxColumn.Name = "cityIdDataGridViewTextBoxColumn";
            // 
            // departureDataGridViewTextBoxColumn
            // 
            this.departureDataGridViewTextBoxColumn.DataPropertyName = "Departure";
            this.departureDataGridViewTextBoxColumn.HeaderText = "Departure";
            this.departureDataGridViewTextBoxColumn.Name = "departureDataGridViewTextBoxColumn";
            // 
            // arrivalDataGridViewTextBoxColumn
            // 
            this.arrivalDataGridViewTextBoxColumn.DataPropertyName = "Arrival";
            this.arrivalDataGridViewTextBoxColumn.HeaderText = "Arrival";
            this.arrivalDataGridViewTextBoxColumn.Name = "arrivalDataGridViewTextBoxColumn";
            // 
            // fromDataGridViewTextBoxColumn
            // 
            this.fromDataGridViewTextBoxColumn.DataPropertyName = "From";
            this.fromDataGridViewTextBoxColumn.HeaderText = "From";
            this.fromDataGridViewTextBoxColumn.Name = "fromDataGridViewTextBoxColumn";
            // 
            // toDataGridViewTextBoxColumn
            // 
            this.toDataGridViewTextBoxColumn.DataPropertyName = "To";
            this.toDataGridViewTextBoxColumn.HeaderText = "To";
            this.toDataGridViewTextBoxColumn.Name = "toDataGridViewTextBoxColumn";
            // 
            // totalCostDataGridViewTextBoxColumn
            // 
            this.totalCostDataGridViewTextBoxColumn.DataPropertyName = "TotalCost";
            this.totalCostDataGridViewTextBoxColumn.HeaderText = "TotalCost";
            this.totalCostDataGridViewTextBoxColumn.Name = "totalCostDataGridViewTextBoxColumn";
            // 
            // CustomersInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 617);
            this.Controls.Add(this.dataGridViewer);
            this.Controls.Add(this.mtSave);
            this.Controls.Add(this.mtDelete);
            this.Controls.Add(this.mtEdit);
            this.Controls.Add(this.mtAdd);
            this.Controls.Add(this.mtRefresh);
            this.Controls.Add(this.metroUserControl1);
            this.Name = "CustomersInformation";
            this.Text = "Customers Information";
            this.Load += new System.EventHandler(this.CustomersInformation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerssBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroUserControl metroUserControl1;
        private MetroFramework.Controls.MetroTile mtRefresh;
        private MetroFramework.Controls.MetroTile mtAdd;
        private MetroFramework.Controls.MetroTile mtEdit;
        private MetroFramework.Controls.MetroTile mtDelete;
        private MetroFramework.Controls.MetroTile mtSave;
        private System.Windows.Forms.DataGridView dataGridViewer;
        private System.Windows.Forms.DataGridViewTextBoxColumn carDetailsDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private System.Windows.Forms.BindingSource cityBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotelNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn CityIdDataGridViewComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn packageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrivalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fromDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource customerssBindingSource;
    }
}