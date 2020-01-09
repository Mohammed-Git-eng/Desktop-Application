namespace NewProject
{
    partial class addNewCustomer
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.textNmae = new MetroFramework.Controls.MetroTextBox();
            this.textPhone = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.textDeparture = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.textArrival = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.TextHotel = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.textCost = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.checkGender = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.comboCity = new MetroFramework.Controls.MetroComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.textCar = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.buttonSave = new MetroFramework.Controls.MetroButton();
            this.textAddress = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.textPackage = new MetroFramework.Controls.MetroTextBox();
            this.bindingSourceCustomer = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(34, 86);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(69, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Full Name";
            // 
            // textNmae
            // 
            this.textNmae.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceCustomer, "FullName", true));
            this.textNmae.Location = new System.Drawing.Point(132, 82);
            this.textNmae.Name = "textNmae";
            this.textNmae.ReadOnly = true;
            this.textNmae.Size = new System.Drawing.Size(251, 23);
            this.textNmae.TabIndex = 1;
            this.textNmae.Click += new System.EventHandler(this.metroTextBox1_Click);
            // 
            // textPhone
            // 
            this.textPhone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceCustomer, "Phone", true));
            this.textPhone.Location = new System.Drawing.Point(132, 112);
            this.textPhone.Name = "textPhone";
            this.textPhone.Size = new System.Drawing.Size(251, 23);
            this.textPhone.TabIndex = 3;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(34, 115);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(46, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Phone";
            // 
            // textDeparture
            // 
            this.textDeparture.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceCustomer, "Departure", true));
            this.textDeparture.Location = new System.Drawing.Point(132, 368);
            this.textDeparture.Name = "textDeparture";
            this.textDeparture.Size = new System.Drawing.Size(251, 23);
            this.textDeparture.TabIndex = 9;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(34, 372);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(69, 19);
            this.metroLabel5.TabIndex = 8;
            this.metroLabel5.Text = "Departure";
            // 
            // textArrival
            // 
            this.textArrival.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceCustomer, "Arrival", true));
            this.textArrival.Location = new System.Drawing.Point(132, 397);
            this.textArrival.Name = "textArrival";
            this.textArrival.Size = new System.Drawing.Size(251, 23);
            this.textArrival.TabIndex = 11;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(34, 401);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(47, 19);
            this.metroLabel6.TabIndex = 10;
            this.metroLabel6.Text = "Arrival";
            // 
            // TextHotel
            // 
            this.TextHotel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceCustomer, "HotelName", true));
            this.TextHotel.Location = new System.Drawing.Point(132, 173);
            this.TextHotel.Name = "TextHotel";
            this.TextHotel.Size = new System.Drawing.Size(251, 23);
            this.TextHotel.TabIndex = 13;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(34, 177);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(80, 19);
            this.metroLabel7.TabIndex = 12;
            this.metroLabel7.Text = "Hotel Name";
            // 
            // textCost
            // 
            this.textCost.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceCustomer, "TotalCost", true));
            this.textCost.Location = new System.Drawing.Point(132, 481);
            this.textCost.Name = "textCost";
            this.textCost.Size = new System.Drawing.Size(251, 23);
            this.textCost.TabIndex = 15;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(34, 485);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(66, 19);
            this.metroLabel8.TabIndex = 14;
            this.metroLabel8.Text = "Total Cost";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(34, 146);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(52, 19);
            this.metroLabel9.TabIndex = 16;
            this.metroLabel9.Text = "Gender";
            // 
            // checkGender
            // 
            this.checkGender.AutoSize = true;
            this.checkGender.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bindingSourceCustomer, "Gender", true));
            this.checkGender.Location = new System.Drawing.Point(132, 146);
            this.checkGender.Name = "checkGender";
            this.checkGender.Size = new System.Drawing.Size(28, 15);
            this.checkGender.TabIndex = 17;
            this.checkGender.Text = "?";
            this.checkGender.UseVisualStyleBackColor = true;
            this.checkGender.CheckStateChanged += new System.EventHandler(this.checkGender_CheckStateChanged);
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(34, 302);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(31, 19);
            this.metroLabel10.TabIndex = 18;
            this.metroLabel10.Text = "City";
            // 
            // comboCity
            // 
            this.comboCity.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bindingSourceCustomer, "City", true));
            this.comboCity.FormattingEnabled = true;
            this.comboCity.ItemHeight = 23;
            this.comboCity.Location = new System.Drawing.Point(132, 295);
            this.comboCity.Name = "comboCity";
            this.comboCity.Size = new System.Drawing.Size(123, 29);
            this.comboCity.TabIndex = 19;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceCustomer, "From", true));
            this.dateTimePicker1.Location = new System.Drawing.Point(132, 426);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(181, 20);
            this.dateTimePicker1.TabIndex = 21;
            this.dateTimePicker1.Value = new System.DateTime(2019, 12, 28, 10, 35, 33, 0);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceCustomer, "To", true));
            this.dateTimePicker2.Location = new System.Drawing.Point(132, 452);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(181, 20);
            this.dateTimePicker2.TabIndex = 22;
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(34, 427);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(41, 19);
            this.metroLabel11.TabIndex = 23;
            this.metroLabel11.Text = "From";
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(34, 453);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(22, 19);
            this.metroLabel12.TabIndex = 24;
            this.metroLabel12.Text = "To";
            // 
            // textCar
            // 
            this.textCar.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceCustomer, "CarDetails", true));
            this.textCar.Location = new System.Drawing.Point(132, 203);
            this.textCar.Name = "textCar";
            this.textCar.Size = new System.Drawing.Size(251, 23);
            this.textCar.TabIndex = 26;
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(34, 207);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(72, 19);
            this.metroLabel13.TabIndex = 25;
            this.metroLabel13.Text = "Car Details";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(308, 525);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 27;
            this.buttonSave.Text = "Save";
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textAddress
            // 
            this.textAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceCustomer, "Address", true));
            this.textAddress.Location = new System.Drawing.Point(132, 233);
            this.textAddress.Multiline = true;
            this.textAddress.Name = "textAddress";
            this.textAddress.Size = new System.Drawing.Size(222, 56);
            this.textAddress.TabIndex = 29;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(34, 233);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(56, 19);
            this.metroLabel3.TabIndex = 28;
            this.metroLabel3.Text = "Address";
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.Location = new System.Drawing.Point(34, 339);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(62, 19);
            this.metroLabel14.TabIndex = 30;
            this.metroLabel14.Text = "Packages";
            // 
            // textPackage
            // 
            this.textPackage.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceCustomer, "Package", true));
            this.textPackage.Location = new System.Drawing.Point(132, 339);
            this.textPackage.Name = "textPackage";
            this.textPackage.Size = new System.Drawing.Size(251, 23);
            this.textPackage.TabIndex = 31;
            // 
            // bindingSourceCustomer
            // 
            this.bindingSourceCustomer.DataSource = typeof(NewProject.Customerss);
            // 
            // addNewCustomer
            // 
            this.AcceptButton = this.buttonSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 627);
            this.Controls.Add(this.textPackage);
            this.Controls.Add(this.metroLabel14);
            this.Controls.Add(this.textAddress);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textCar);
            this.Controls.Add(this.metroLabel13);
            this.Controls.Add(this.metroLabel12);
            this.Controls.Add(this.metroLabel11);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboCity);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.checkGender);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.textCost);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.TextHotel);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.textArrival);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.textDeparture);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.textPhone);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.textNmae);
            this.Controls.Add(this.metroLabel1);
            this.MinimizeBox = false;
            this.Name = "addNewCustomer";
            this.Text = "New Customer";
            this.Load += new System.EventHandler(this.addNewCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox textNmae;
        private MetroFramework.Controls.MetroTextBox textPhone;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox textDeparture;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox textArrival;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox TextHotel;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox textCost;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroCheckBox checkGender;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroComboBox comboCity;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroTextBox textCar;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroButton buttonSave;
        private MetroFramework.Controls.MetroTextBox textAddress;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroTextBox textPackage;
        private System.Windows.Forms.BindingSource bindingSourceCustomer;
    }
}