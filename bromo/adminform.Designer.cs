using System.Drawing;

namespace bromo
{
    partial class adminform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminform));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button_navbar = new System.Windows.Forms.Button();
            this.panel_navbar = new System.Windows.Forms.Panel();
            this.button_Logout = new System.Windows.Forms.Button();
            this.button_masterBandana = new System.Windows.Forms.Button();
            this.button_UbahStatusPenerbangan = new System.Windows.Forms.Button();
            this.button_masterJadwalPenerbangan = new System.Windows.Forms.Button();
            this.button_MasterKodePromo = new System.Windows.Forms.Button();
            this.button_masterMaskapai = new System.Windows.Forms.Button();
            this.mainpanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel_navbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button_navbar);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1107, 59);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(58, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 24);
            this.label1.TabIndex = 1;
            // 
            // button_navbar
            // 
            this.button_navbar.FlatAppearance.BorderSize = 0;
            this.button_navbar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_navbar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_navbar.ForeColor = System.Drawing.SystemColors.Control;
            this.button_navbar.Image = ((System.Drawing.Image)(resources.GetObject("button_navbar.Image")));
            this.button_navbar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button_navbar.Location = new System.Drawing.Point(0, -3);
            this.button_navbar.Name = "button_navbar";
            this.button_navbar.Size = new System.Drawing.Size(225, 59);
            this.button_navbar.TabIndex = 0;
            this.button_navbar.Text = "Dashboard";
            this.button_navbar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_navbar.UseVisualStyleBackColor = true;
            this.button_navbar.Click += new System.EventHandler(this.button_navbar_Click);
            // 
            // panel_navbar
            // 
            this.panel_navbar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel_navbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.panel_navbar.Controls.Add(this.button_Logout);
            this.panel_navbar.Controls.Add(this.button_masterBandana);
            this.panel_navbar.Controls.Add(this.button_UbahStatusPenerbangan);
            this.panel_navbar.Controls.Add(this.button_masterJadwalPenerbangan);
            this.panel_navbar.Controls.Add(this.button_MasterKodePromo);
            this.panel_navbar.Controls.Add(this.button_masterMaskapai);
            this.panel_navbar.ForeColor = System.Drawing.Color.Black;
            this.panel_navbar.Location = new System.Drawing.Point(2, 51);
            this.panel_navbar.Name = "panel_navbar";
            this.panel_navbar.Size = new System.Drawing.Size(284, 568);
            this.panel_navbar.TabIndex = 1;
            // 
            // button_Logout
            // 
            this.button_Logout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_Logout.FlatAppearance.BorderSize = 0;
            this.button_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Logout.ForeColor = System.Drawing.Color.Red;
            this.button_Logout.Image = ((System.Drawing.Image)(resources.GetObject("button_Logout.Image")));
            this.button_Logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Logout.Location = new System.Drawing.Point(10, 514);
            this.button_Logout.Name = "button_Logout";
            this.button_Logout.Size = new System.Drawing.Size(205, 42);
            this.button_Logout.TabIndex = 4;
            this.button_Logout.Text = "LOGOUT";
            this.button_Logout.UseVisualStyleBackColor = true;
            this.button_Logout.Click += new System.EventHandler(this.button6_Click);
            // 
            // button_masterBandana
            // 
            this.button_masterBandana.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_masterBandana.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.button_masterBandana.FlatAppearance.BorderSize = 0;
            this.button_masterBandana.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_masterBandana.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_masterBandana.Image = ((System.Drawing.Image)(resources.GetObject("button_masterBandana.Image")));
            this.button_masterBandana.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_masterBandana.Location = new System.Drawing.Point(3, 14);
            this.button_masterBandana.Name = "button_masterBandana";
            this.button_masterBandana.Size = new System.Drawing.Size(278, 73);
            this.button_masterBandana.TabIndex = 0;
            this.button_masterBandana.Text = "Master Bandara";
            this.button_masterBandana.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_masterBandana.UseVisualStyleBackColor = false;
            this.button_masterBandana.Click += new System.EventHandler(this.button_masterBandana_Click);
            // 
            // button_UbahStatusPenerbangan
            // 
            this.button_UbahStatusPenerbangan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_UbahStatusPenerbangan.FlatAppearance.BorderSize = 0;
            this.button_UbahStatusPenerbangan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_UbahStatusPenerbangan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_UbahStatusPenerbangan.Image = ((System.Drawing.Image)(resources.GetObject("button_UbahStatusPenerbangan.Image")));
            this.button_UbahStatusPenerbangan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_UbahStatusPenerbangan.Location = new System.Drawing.Point(3, 305);
            this.button_UbahStatusPenerbangan.Name = "button_UbahStatusPenerbangan";
            this.button_UbahStatusPenerbangan.Size = new System.Drawing.Size(278, 58);
            this.button_UbahStatusPenerbangan.TabIndex = 3;
            this.button_UbahStatusPenerbangan.Text = "Ubah Status Penerbangan";
            this.button_UbahStatusPenerbangan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_UbahStatusPenerbangan.UseVisualStyleBackColor = true;
            this.button_UbahStatusPenerbangan.Click += new System.EventHandler(this.button_UbahStatusPenerbangan_Click);
            // 
            // button_masterJadwalPenerbangan
            // 
            this.button_masterJadwalPenerbangan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_masterJadwalPenerbangan.FlatAppearance.BorderSize = 0;
            this.button_masterJadwalPenerbangan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_masterJadwalPenerbangan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_masterJadwalPenerbangan.Image = ((System.Drawing.Image)(resources.GetObject("button_masterJadwalPenerbangan.Image")));
            this.button_masterJadwalPenerbangan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_masterJadwalPenerbangan.Location = new System.Drawing.Point(3, 162);
            this.button_masterJadwalPenerbangan.Name = "button_masterJadwalPenerbangan";
            this.button_masterJadwalPenerbangan.Size = new System.Drawing.Size(278, 67);
            this.button_masterJadwalPenerbangan.TabIndex = 2;
            this.button_masterJadwalPenerbangan.Text = "Master Jadwal Penerbangan";
            this.button_masterJadwalPenerbangan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_masterJadwalPenerbangan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_masterJadwalPenerbangan.UseVisualStyleBackColor = true;
            this.button_masterJadwalPenerbangan.Click += new System.EventHandler(this.button_masterJadwalPenerbangan_Click);
            // 
            // button_MasterKodePromo
            // 
            this.button_MasterKodePromo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_MasterKodePromo.Cursor = System.Windows.Forms.Cursors.Default;
            this.button_MasterKodePromo.FlatAppearance.BorderSize = 0;
            this.button_MasterKodePromo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_MasterKodePromo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_MasterKodePromo.Image = ((System.Drawing.Image)(resources.GetObject("button_MasterKodePromo.Image")));
            this.button_MasterKodePromo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_MasterKodePromo.Location = new System.Drawing.Point(3, 235);
            this.button_MasterKodePromo.Name = "button_MasterKodePromo";
            this.button_MasterKodePromo.Size = new System.Drawing.Size(278, 64);
            this.button_MasterKodePromo.TabIndex = 2;
            this.button_MasterKodePromo.Text = "Master Kode Promo";
            this.button_MasterKodePromo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_MasterKodePromo.UseVisualStyleBackColor = true;
            this.button_MasterKodePromo.Click += new System.EventHandler(this.button_MasterKodePromo_Click);
            // 
            // button_masterMaskapai
            // 
            this.button_masterMaskapai.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_masterMaskapai.FlatAppearance.BorderSize = 0;
            this.button_masterMaskapai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_masterMaskapai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_masterMaskapai.Image = ((System.Drawing.Image)(resources.GetObject("button_masterMaskapai.Image")));
            this.button_masterMaskapai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_masterMaskapai.Location = new System.Drawing.Point(3, 93);
            this.button_masterMaskapai.Name = "button_masterMaskapai";
            this.button_masterMaskapai.Size = new System.Drawing.Size(278, 63);
            this.button_masterMaskapai.TabIndex = 1;
            this.button_masterMaskapai.Text = "Master Maskapai";
            this.button_masterMaskapai.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_masterMaskapai.UseVisualStyleBackColor = true;
            this.button_masterMaskapai.Click += new System.EventHandler(this.button_masterMaskapai_Click);
            // 
            // mainpanel
            // 
            this.mainpanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainpanel.Location = new System.Drawing.Point(289, 59);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(811, 560);
            this.mainpanel.TabIndex = 2;
            // 
            // adminform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1101, 619);
            this.Controls.Add(this.mainpanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_navbar);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "adminform";
            this.Text = "Bromo Airlines - Admin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.adminform_FormClosing);
            this.Load += new System.EventHandler(this.adminform_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_navbar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_navbar;
        private System.Windows.Forms.Button button_masterBandana;
        private System.Windows.Forms.Button button_masterJadwalPenerbangan;
        private System.Windows.Forms.Button button_masterMaskapai;
        private System.Windows.Forms.Button button_UbahStatusPenerbangan;
        private System.Windows.Forms.Button button_MasterKodePromo;
        private System.Windows.Forms.Button button_Logout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_navbar;
        private System.Windows.Forms.Panel mainpanel;
    }
}