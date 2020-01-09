namespace NewProject
{
    partial class manageClients
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mainPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageCustomersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookingHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.financeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.finaceHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.financeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainPageToolStripMenuItem,
            this.manageCustomersToolStripMenuItem,
            this.bookingsToolStripMenuItem,
            this.historyToolStripMenuItem,
            this.financeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(682, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mainPageToolStripMenuItem
            // 
            this.mainPageToolStripMenuItem.Name = "mainPageToolStripMenuItem";
            this.mainPageToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.mainPageToolStripMenuItem.Text = "Home Page";
            this.mainPageToolStripMenuItem.Click += new System.EventHandler(this.mainPageToolStripMenuItem_Click);
            // 
            // manageCustomersToolStripMenuItem
            // 
            this.manageCustomersToolStripMenuItem.Name = "manageCustomersToolStripMenuItem";
            this.manageCustomersToolStripMenuItem.Size = new System.Drawing.Size(142, 20);
            this.manageCustomersToolStripMenuItem.Text = "Customers Information";
            this.manageCustomersToolStripMenuItem.Click += new System.EventHandler(this.manageCustomersToolStripMenuItem_Click);
            // 
            // bookingsToolStripMenuItem
            // 
            this.bookingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookingToolStripMenuItem,
            this.bookingHistoryToolStripMenuItem});
            this.bookingsToolStripMenuItem.Name = "bookingsToolStripMenuItem";
            this.bookingsToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.bookingsToolStripMenuItem.Text = "Bookings";
            this.bookingsToolStripMenuItem.Click += new System.EventHandler(this.bookingsToolStripMenuItem_Click);
            // 
            // bookingHistoryToolStripMenuItem
            // 
            this.bookingHistoryToolStripMenuItem.Name = "bookingHistoryToolStripMenuItem";
            this.bookingHistoryToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.bookingHistoryToolStripMenuItem.Text = "Booking History";
            this.bookingHistoryToolStripMenuItem.Click += new System.EventHandler(this.bookingHistoryToolStripMenuItem_Click);
            // 
            // historyToolStripMenuItem
            // 
            this.historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            this.historyToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.historyToolStripMenuItem.Text = "Cancel Bookings";
            this.historyToolStripMenuItem.Click += new System.EventHandler(this.historyToolStripMenuItem_Click);
            // 
            // financeToolStripMenuItem
            // 
            this.financeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.financeToolStripMenuItem1,
            this.finaceHistoryToolStripMenuItem});
            this.financeToolStripMenuItem.Name = "financeToolStripMenuItem";
            this.financeToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.financeToolStripMenuItem.Text = "Finance";
            this.financeToolStripMenuItem.Click += new System.EventHandler(this.financeToolStripMenuItem_Click);
            // 
            // finaceHistoryToolStripMenuItem
            // 
            this.finaceHistoryToolStripMenuItem.Name = "finaceHistoryToolStripMenuItem";
            this.finaceHistoryToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.finaceHistoryToolStripMenuItem.Text = "Finace History";
            this.finaceHistoryToolStripMenuItem.Click += new System.EventHandler(this.finaceHistoryToolStripMenuItem_Click);
            // 
            // bookingToolStripMenuItem
            // 
            this.bookingToolStripMenuItem.Name = "bookingToolStripMenuItem";
            this.bookingToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.bookingToolStripMenuItem.Text = "Booking";
            this.bookingToolStripMenuItem.Click += new System.EventHandler(this.bookingToolStripMenuItem_Click);
            // 
            // financeToolStripMenuItem1
            // 
            this.financeToolStripMenuItem1.Name = "financeToolStripMenuItem1";
            this.financeToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.financeToolStripMenuItem1.Text = "Finance";
            this.financeToolStripMenuItem1.Click += new System.EventHandler(this.financeToolStripMenuItem1_Click);
            // 
            // manageClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 687);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(600, 726);
            this.Name = "manageClients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "manageClients";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.manageClients_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem manageCustomersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem financeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mainPageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookingHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem finaceHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem financeToolStripMenuItem1;
    }
}