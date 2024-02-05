﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bromo
{
    public partial class adminform : Form
    {
        public adminform()
        {
            InitializeComponent();
            
        }
        Utils con = new Utils();
        bool showNavbar = true;

        public Form loadForm(object panel)
        {
            if (this.mainpanel.Controls.Count > 0) {
                this.mainpanel.Controls.RemoveAt(0);
            }
            Form f = panel as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();
            return f;

        }

        public void defaultButton()
        {
            this.button_masterBandana.ForeColor = System.Drawing.Color.FromArgb(((int)(((160)))),((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.button_masterMaskapai.ForeColor = System.Drawing.Color.FromArgb(((int)(((160)))),((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.button_MasterKodePromo.ForeColor = System.Drawing.Color.FromArgb(((int)(((160)))),((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.button_UbahStatusPenerbangan.ForeColor = System.Drawing.Color.FromArgb(((int)(((160)))),((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.button_masterJadwalPenerbangan.ForeColor = System.Drawing.Color.FromArgb(((int)(((160)))),((int)(((byte)(160)))), ((int)(((byte)(160)))));

            this.button_masterBandana.Image = Image.FromFile("C:\\Users\\Msi-PC\\source\\repos\\csharp-latihan\\bromo\\Icons\\map-unselected-72.png");
            this.button_masterMaskapai.Image = Image.FromFile("C:\\Users\\Msi-PC\\source\\repos\\csharp-latihan\\bromo\\Icons\\plane-take-off-unselected-72.png");
            this.button_MasterKodePromo.Image = Image.FromFile("C:\\Users\\Msi-PC\\source\\repos\\csharp-latihan\\bromo\\Icons\\purchase-tag-alt-unselected-72.png");
            this.button_UbahStatusPenerbangan.Image = Image.FromFile("C:\\Users\\Msi-PC\\source\\repos\\csharp-latihan\\bromo\\Icons\\notepad-unselected-72.png");
            this.button_masterJadwalPenerbangan.Image = Image.FromFile("C:\\Users\\Msi-PC\\source\\repos\\csharp-latihan\\bromo\\Icons\\calendar-unselected-72.png");
        }

        private void adminform_Load(object sender, EventArgs e)
        {
            defaultButton();
        }

        private void button_masterBandana_Click(object sender, EventArgs e)
        {
            defaultButton();
            this.button_masterBandana.ForeColor = System.Drawing.Color.FromArgb(((int)(((0)))),((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_masterBandana.Image = Image.FromFile("C:\\Users\\Msi-PC\\source\\repos\\csharp-latihan\\bromo\\Icons\\map-selected-72.png");
            Form panel = loadForm(new MasterBandara());
        }

        private void button_navbar_Click(object sender, EventArgs e)
        {
            if (showNavbar.Equals(false))
            {
                showNavbar = true;
                this.panel_navbar.Visible = true;
            } else
            {
                showNavbar = false;
                this.panel_navbar.Visible = false; 
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            System.Threading.Thread thread = new System.Threading.Thread(new System.Threading.ThreadStart(OpenLogin));
            this.Close();
            thread.Start();
        }

        public static void OpenLogin()
        {
            Application.Run(new Login());
        }
    }
}
