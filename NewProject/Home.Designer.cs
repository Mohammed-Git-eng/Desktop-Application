namespace NewProject
{
    partial class Home
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
            this.login = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.heading = new System.Windows.Forms.Label();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.textLogin = new System.Windows.Forms.TextBox();
            this.login_Btn = new System.Windows.Forms.Button();
            this.cancel_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // login
            // 
            this.login.AutoSize = true;
            this.login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.Location = new System.Drawing.Point(36, 186);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(99, 20);
            this.login.TabIndex = 0;
            this.login.Text = "LoginName";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(36, 220);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(86, 20);
            this.password.TabIndex = 1;
            this.password.Text = "Password";
            // 
            // heading
            // 
            this.heading.AutoSize = true;
            this.heading.BackColor = System.Drawing.Color.Orchid;
            this.heading.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.heading.Font = new System.Drawing.Font("Goudy Old Style", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heading.Location = new System.Drawing.Point(64, 88);
            this.heading.Name = "heading";
            this.heading.Size = new System.Drawing.Size(644, 45);
            this.heading.TabIndex = 2;
            this.heading.Text = "MAMI TRAVEL AND TOUR AGENCY";
            // 
            // textPassword
            // 
            this.textPassword.Location = new System.Drawing.Point(157, 220);
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(206, 20);
            this.textPassword.TabIndex = 3;
            this.textPassword.Text = "123456";
            this.textPassword.TextChanged += new System.EventHandler(this.textPassword_TextChanged);
            // 
            // textLogin
            // 
            this.textLogin.Location = new System.Drawing.Point(157, 186);
            this.textLogin.Name = "textLogin";
            this.textLogin.Size = new System.Drawing.Size(206, 20);
            this.textLogin.TabIndex = 4;
            this.textLogin.Text = "Admin";
            this.textLogin.TextChanged += new System.EventHandler(this.textLogin_TextChanged);
            // 
            // login_Btn
            // 
            this.login_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_Btn.Location = new System.Drawing.Point(207, 257);
            this.login_Btn.Name = "login_Btn";
            this.login_Btn.Size = new System.Drawing.Size(75, 32);
            this.login_Btn.TabIndex = 5;
            this.login_Btn.Text = "Login";
            this.login_Btn.UseVisualStyleBackColor = true;
            this.login_Btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // cancel_Btn
            // 
            this.cancel_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_Btn.Location = new System.Drawing.Point(288, 257);
            this.cancel_Btn.Name = "cancel_Btn";
            this.cancel_Btn.Size = new System.Drawing.Size(75, 32);
            this.cancel_Btn.TabIndex = 6;
            this.cancel_Btn.Text = "Cancel";
            this.cancel_Btn.UseVisualStyleBackColor = true;
            this.cancel_Btn.Click += new System.EventHandler(this.cancel_Btn_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NewProject.Properties.Resources.image1;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.cancel_Btn);
            this.Controls.Add(this.login_Btn);
            this.Controls.Add(this.textLogin);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.heading);
            this.Controls.Add(this.password);
            this.Controls.Add(this.login);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label login;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label heading;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.TextBox textLogin;
        private System.Windows.Forms.Button login_Btn;
        private System.Windows.Forms.Button cancel_Btn;
    }
}