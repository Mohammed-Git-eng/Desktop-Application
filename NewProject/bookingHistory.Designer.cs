namespace NewProject
{
    partial class bookingHistory
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
            this.label1 = new System.Windows.Forms.Label();
            this.textCustomer = new System.Windows.Forms.TextBox();
            this.bookedHistoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.historyDataSet = new NewProject.HistoryDataSet();
            this.textBooked = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textCost = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textDeparture = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textArrival = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.customerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookedItemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrivalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.date1 = new System.Windows.Forms.Label();
            this.To = new System.Windows.Forms.Label();
            this.textPhone = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.bookedHistoryTableAdapter = new NewProject.HistoryDataSetTableAdapters.bookedHistoryTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bookedHistoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Tomato;
            this.label1.Location = new System.Drawing.Point(33, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textCustomer
            // 
            this.textCustomer.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookedHistoryBindingSource, "customerName", true));
            this.textCustomer.Location = new System.Drawing.Point(145, 78);
            this.textCustomer.Name = "textCustomer";
            this.textCustomer.Size = new System.Drawing.Size(198, 20);
            this.textCustomer.TabIndex = 0;
            // 
            // bookedHistoryBindingSource
            // 
            this.bookedHistoryBindingSource.DataMember = "bookedHistory";
            this.bookedHistoryBindingSource.DataSource = this.historyDataSet;
            // 
            // historyDataSet
            // 
            this.historyDataSet.DataSetName = "HistoryDataSet";
            this.historyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBooked
            // 
            this.textBooked.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookedHistoryBindingSource, "bookedItem", true));
            this.textBooked.Location = new System.Drawing.Point(145, 104);
            this.textBooked.Name = "textBooked";
            this.textBooked.Size = new System.Drawing.Size(198, 20);
            this.textBooked.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Tomato;
            this.label2.Location = new System.Drawing.Point(33, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Booked Item";
            // 
            // textCost
            // 
            this.textCost.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookedHistoryBindingSource, "totalCost", true));
            this.textCost.Location = new System.Drawing.Point(145, 130);
            this.textCost.Name = "textCost";
            this.textCost.Size = new System.Drawing.Size(198, 20);
            this.textCost.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Tomato;
            this.label3.Location = new System.Drawing.Point(33, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Total Cost";
            // 
            // textEmail
            // 
            this.textEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookedHistoryBindingSource, "emailAddress", true));
            this.textEmail.Location = new System.Drawing.Point(145, 156);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(198, 20);
            this.textEmail.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Tomato;
            this.label4.Location = new System.Drawing.Point(33, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Email Address";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textSearch
            // 
            this.textSearch.Location = new System.Drawing.Point(145, 218);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(724, 20);
            this.textSearch.TabIndex = 5;
            this.textSearch.TextChanged += new System.EventHandler(this.textSearch_TextChanged);
            this.textSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textSearch_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Tomato;
            this.label5.Location = new System.Drawing.Point(33, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Search";
            // 
            // textDeparture
            // 
            this.textDeparture.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookedHistoryBindingSource, "departure", true));
            this.textDeparture.Location = new System.Drawing.Point(428, 104);
            this.textDeparture.Name = "textDeparture";
            this.textDeparture.Size = new System.Drawing.Size(195, 20);
            this.textDeparture.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Tomato;
            this.label6.Location = new System.Drawing.Point(360, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Departure";
            // 
            // textArrival
            // 
            this.textArrival.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookedHistoryBindingSource, "arrival", true));
            this.textArrival.Location = new System.Drawing.Point(690, 104);
            this.textArrival.Name = "textArrival";
            this.textArrival.Size = new System.Drawing.Size(179, 20);
            this.textArrival.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Tomato;
            this.label7.Location = new System.Drawing.Point(637, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Arrival";
            // 
            // dataGridView
            // 
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerNameDataGridViewTextBoxColumn,
            this.bookedItemDataGridViewTextBoxColumn,
            this.departureDataGridViewTextBoxColumn,
            this.arrivalDataGridViewTextBoxColumn,
            this.totalCostDataGridViewTextBoxColumn,
            this.emailAddressDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.bookedHistoryBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(36, 256);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(833, 249);
            this.dataGridView.TabIndex = 14;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            this.dataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView_KeyDown);
            // 
            // customerNameDataGridViewTextBoxColumn
            // 
            this.customerNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.customerNameDataGridViewTextBoxColumn.DataPropertyName = "customerName";
            this.customerNameDataGridViewTextBoxColumn.HeaderText = "customerName";
            this.customerNameDataGridViewTextBoxColumn.Name = "customerNameDataGridViewTextBoxColumn";
            // 
            // bookedItemDataGridViewTextBoxColumn
            // 
            this.bookedItemDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bookedItemDataGridViewTextBoxColumn.DataPropertyName = "bookedItem";
            this.bookedItemDataGridViewTextBoxColumn.HeaderText = "bookedItem";
            this.bookedItemDataGridViewTextBoxColumn.Name = "bookedItemDataGridViewTextBoxColumn";
            // 
            // departureDataGridViewTextBoxColumn
            // 
            this.departureDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.departureDataGridViewTextBoxColumn.DataPropertyName = "departure";
            this.departureDataGridViewTextBoxColumn.HeaderText = "departure";
            this.departureDataGridViewTextBoxColumn.Name = "departureDataGridViewTextBoxColumn";
            // 
            // arrivalDataGridViewTextBoxColumn
            // 
            this.arrivalDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.arrivalDataGridViewTextBoxColumn.DataPropertyName = "arrival";
            this.arrivalDataGridViewTextBoxColumn.HeaderText = "arrival";
            this.arrivalDataGridViewTextBoxColumn.Name = "arrivalDataGridViewTextBoxColumn";
            // 
            // totalCostDataGridViewTextBoxColumn
            // 
            this.totalCostDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.totalCostDataGridViewTextBoxColumn.DataPropertyName = "totalCost";
            this.totalCostDataGridViewTextBoxColumn.HeaderText = "totalCost";
            this.totalCostDataGridViewTextBoxColumn.Name = "totalCostDataGridViewTextBoxColumn";
            // 
            // emailAddressDataGridViewTextBoxColumn
            // 
            this.emailAddressDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.emailAddressDataGridViewTextBoxColumn.DataPropertyName = "emailAddress";
            this.emailAddressDataGridViewTextBoxColumn.HeaderText = "emailAddress";
            this.emailAddressDataGridViewTextBoxColumn.Name = "emailAddressDataGridViewTextBoxColumn";
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "phoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "phoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(551, 511);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 10;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(632, 511);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 11;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(713, 511);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(794, 511);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 22);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(426, 137);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(690, 137);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(179, 20);
            this.dateTimePicker2.TabIndex = 9;
            // 
            // date1
            // 
            this.date1.AutoSize = true;
            this.date1.ForeColor = System.Drawing.Color.Tomato;
            this.date1.Location = new System.Drawing.Point(362, 143);
            this.date1.Name = "date1";
            this.date1.Size = new System.Drawing.Size(30, 13);
            this.date1.TabIndex = 21;
            this.date1.Text = "From";
            // 
            // To
            // 
            this.To.AutoSize = true;
            this.To.ForeColor = System.Drawing.Color.Tomato;
            this.To.Location = new System.Drawing.Point(637, 144);
            this.To.Name = "To";
            this.To.Size = new System.Drawing.Size(20, 13);
            this.To.TabIndex = 22;
            this.To.Text = "To";
            // 
            // textPhone
            // 
            this.textPhone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookedHistoryBindingSource, "phoneNumber", true));
            this.textPhone.Location = new System.Drawing.Point(145, 182);
            this.textPhone.Name = "textPhone";
            this.textPhone.Size = new System.Drawing.Size(198, 20);
            this.textPhone.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Tomato;
            this.label8.Location = new System.Drawing.Point(33, 189);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Phone Number";
            // 
            // bookedHistoryTableAdapter
            // 
            this.bookedHistoryTableAdapter.ClearBeforeFill = true;
            // 
            // bookingHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 600);
            this.Controls.Add(this.textPhone);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.To);
            this.Controls.Add(this.date1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.textArrival);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textDeparture);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textSearch);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textCost);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBooked);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textCustomer);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "bookingHistory";
            this.Text = "bookingHistory";
            this.Load += new System.EventHandler(this.bookingHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bookedHistoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textCustomer;
        private System.Windows.Forms.TextBox textBooked;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textCost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textDeparture;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textArrival;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label date1;
        private System.Windows.Forms.Label To;
        private System.Windows.Forms.TextBox textPhone;
        private System.Windows.Forms.Label label8;
        private HistoryDataSet historyDataSet;
        private System.Windows.Forms.BindingSource bookedHistoryBindingSource;
        private HistoryDataSetTableAdapters.bookedHistoryTableAdapter bookedHistoryTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookedItemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrivalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
    }
}