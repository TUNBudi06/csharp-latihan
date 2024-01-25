namespace bromo
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label_username = new System.Windows.Forms.Label();
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.label_password = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.button_login = new System.Windows.Forms.Button();
            this.logo_bromo = new System.Windows.Forms.PictureBox();
            this.label_noAkun = new System.Windows.Forms.Label();
            this.linkLabel_Daftar = new System.Windows.Forms.LinkLabel();
            this.checkBox_showPassword = new System.Windows.Forms.CheckBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.logo_bromo)).BeginInit();
            this.SuspendLayout();
            // 
            // label_username
            // 
            this.label_username.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_username.AutoSize = true;
            this.label_username.Font = new System.Drawing.Font("HP Simplified Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_username.Location = new System.Drawing.Point(131, 276);
            this.label_username.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(104, 28);
            this.label_username.TabIndex = 1;
            this.label_username.Text = "Username";
            this.label_username.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox_username
            // 
            this.textBox_username.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox_username.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_username.Location = new System.Drawing.Point(239, 276);
            this.textBox_username.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(387, 28);
            this.textBox_username.TabIndex = 2;
            this.textBox_username.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_username_KeyPress);
            // 
            // label_password
            // 
            this.label_password.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_password.AutoSize = true;
            this.label_password.Font = new System.Drawing.Font("HP Simplified Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_password.Location = new System.Drawing.Point(131, 321);
            this.label_password.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(99, 28);
            this.label_password.TabIndex = 3;
            this.label_password.Text = "Password";
            this.label_password.Click += new System.EventHandler(this.label2_Click);
            // 
            // exitButton
            // 
            this.exitButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(547, 367);
            this.exitButton.Margin = new System.Windows.Forms.Padding(2);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(79, 36);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Keluar";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // button_login
            // 
            this.button_login.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_login.Location = new System.Drawing.Point(465, 366);
            this.button_login.Margin = new System.Windows.Forms.Padding(2);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(78, 37);
            this.button_login.TabIndex = 6;
            this.button_login.Text = "Masuk";
            this.button_login.UseVisualStyleBackColor = true;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // logo_bromo
            // 
            this.logo_bromo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.logo_bromo.Image = ((System.Drawing.Image)(resources.GetObject("logo_bromo.Image")));
            this.logo_bromo.InitialImage = null;
            this.logo_bromo.Location = new System.Drawing.Point(104, 33);
            this.logo_bromo.Name = "logo_bromo";
            this.logo_bromo.Size = new System.Drawing.Size(583, 207);
            this.logo_bromo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo_bromo.TabIndex = 8;
            this.logo_bromo.TabStop = false;
            // 
            // label_noAkun
            // 
            this.label_noAkun.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_noAkun.AutoSize = true;
            this.label_noAkun.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_noAkun.Location = new System.Drawing.Point(265, 433);
            this.label_noAkun.Name = "label_noAkun";
            this.label_noAkun.Size = new System.Drawing.Size(137, 18);
            this.label_noAkun.TabIndex = 9;
            this.label_noAkun.Text = "Belum punya akun?";
            this.label_noAkun.Click += new System.EventHandler(this.label3_Click);
            // 
            // linkLabel_Daftar
            // 
            this.linkLabel_Daftar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.linkLabel_Daftar.AutoSize = true;
            this.linkLabel_Daftar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel_Daftar.Location = new System.Drawing.Point(408, 433);
            this.linkLabel_Daftar.Name = "linkLabel_Daftar";
            this.linkLabel_Daftar.Size = new System.Drawing.Size(88, 18);
            this.linkLabel_Daftar.TabIndex = 10;
            this.linkLabel_Daftar.TabStop = true;
            this.linkLabel_Daftar.Text = "Daftar disini!";
            this.linkLabel_Daftar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_Daftar_LinkClicked);
            // 
            // checkBox_showPassword
            // 
            this.checkBox_showPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.checkBox_showPassword.AutoSize = true;
            this.checkBox_showPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_showPassword.Location = new System.Drawing.Point(136, 361);
            this.checkBox_showPassword.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox_showPassword.Name = "checkBox_showPassword";
            this.checkBox_showPassword.Size = new System.Drawing.Size(141, 24);
            this.checkBox_showPassword.TabIndex = 7;
            this.checkBox_showPassword.Text = "Show Password";
            this.checkBox_showPassword.UseVisualStyleBackColor = true;
            this.checkBox_showPassword.CheckedChanged += new System.EventHandler(this.checkBox_showPassword_CheckedChanged);
            // 
            // textBox_password
            // 
            this.textBox_password.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_password.Location = new System.Drawing.Point(239, 321);
            this.textBox_password.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.PasswordChar = '*';
            this.textBox_password.Size = new System.Drawing.Size(387, 29);
            this.textBox_password.TabIndex = 4;
            this.textBox_password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_password_KeyPress);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 484);
            this.Controls.Add(this.linkLabel_Daftar);
            this.Controls.Add(this.label_noAkun);
            this.Controls.Add(this.logo_bromo);
            this.Controls.Add(this.checkBox_showPassword);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.textBox_username);
            this.Controls.Add(this.label_username);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bromo AirLines - Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo_bromo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.TextBox textBox_username;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.PictureBox logo_bromo;
        private System.Windows.Forms.Label label_noAkun;
        private System.Windows.Forms.LinkLabel linkLabel_Daftar;
        private System.Windows.Forms.CheckBox checkBox_showPassword;
        private System.Windows.Forms.TextBox textBox_password;
    }
}

