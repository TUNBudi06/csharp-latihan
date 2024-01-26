using System;
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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }
        private SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=BromoAirlines;Integrated Security=True");

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_showPassword.Checked)
                textBox_password.PasswordChar = '\0';
            else
                textBox_password.PasswordChar = '*';
        }

        private void linkLabel_Masuk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login(); 
            this.Hide();
            login.ShowDialog();
        }

        private void textBox_username_KeyPress(object sender, KeyPressEventArgs e)
        {
            if( e.KeyChar == (char)Keys.Enter )
            {
                textBox_name.Focus();
                e.Handled = true;
            }
        }

        private void textBox_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                tanggal_lahir.Focus();
                e.Handled = true;
            }
        }

        private void tanggal_lahir_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                textBox_noTelp.Focus();
                e.Handled = true;
            }
        }

        private void textBox_noTelp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                textBox_password.Focus();
                e.Handled = true;
            }
        }

        private void textBox_password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                button_daftar.Focus();
                e.Handled = true;
            }
        }

        private void button_daftar_Click(object sender, EventArgs e)
        {
            try
            {
                //logic of username
                if(!string.IsNullOrEmpty(textBox_username.Text)) {
                    string getUsername = "select * from Akun where Username = '" + textBox_username.Text + "'";
                    SqlDataAdapter data_user = new SqlDataAdapter(getUsername, conn);

                    DataTable dt_user = new DataTable();
                    data_user.Fill(dt_user);
                    if (dt_user.Rows.Count > 0)
                    {
                        MessageBox.Show("Username telah dipakai", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox_username.Focus();
                    }
                } else
                {
                    MessageBox.Show("Username tidak boleh kosong","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    textBox_username.Focus();
                }

                //logik of nama
                if(string.IsNullOrEmpty(textBox_name.Text))
                {
                    MessageBox.Show("Nama tidak boleh kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox_name.Focus();
                }

                if(string.IsNullOrEmpty(tanggal_lahir.Text))
                {

                }


            } catch
            {

            } finally
            {
                conn.Close();
            }
        }
    }
}
