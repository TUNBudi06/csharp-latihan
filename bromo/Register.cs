using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
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
        private SqlConnection conn = new SqlConnection(@"Data Source=MSI\SQLEXPRESS;Initial Catalog=BromoAirlines;Integrated Security=True;");

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
            if (!Char.IsDigit(e.KeyChar) && (e.KeyChar != (char)(Keys.Back)))
            {
                e.Handled = true;
            }
            else
            {
                // is a digit or backspace - ignore digits if length is alreay 10 - allow backspace
                if (Char.IsDigit(e.KeyChar))
                {
                    if (textBox_noTelp.Text.Length > 14)
                    {
                        e.Handled = true;
                    }
                }
            }
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
                if (!string.IsNullOrEmpty(textBox_username.Text))
                {
                    string getUsername = "select * from Akun where Username = '" + textBox_username.Text + "'";
                    SqlDataAdapter data_user = new SqlDataAdapter(getUsername, conn);

                    DataTable dt_user = new DataTable();
                    data_user.Fill(dt_user);
                    if (dt_user.Rows.Count > 0)
                    {
                        MessageBox.Show("Username telah dipakai", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox_username.Focus();
                    } else
                    {
                        //logik of nama
                        if (string.IsNullOrEmpty(textBox_name.Text))
                        {
                            MessageBox.Show("Nama tidak boleh kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            textBox_name.Focus();
                        }
                        else
                        {
                            // logic of tanggal_lahir
                            // add .date for filter only date can go throught without time
                            // and convert to string to filter time
                            string dt = tanggal_lahir.Value.Date.ToString("yyyy-MM-dd");
                            string dt_now = DateTime.Now.Date.ToString("yyyy-MM-dd");

                            if (dt.Equals(dt_now))
                            {
                                MessageBox.Show("Masukkan tanggal lahir anda", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                tanggal_lahir.Focus();
                                //Console.WriteLine(dt);
                            }
                            else
                            {
                                // logic of number telephone
                                if (string.IsNullOrEmpty(textBox_noTelp.Text))
                                {
                                    MessageBox.Show("nomor telepon tidak boleh kosong", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    textBox_noTelp.Focus();
                                }
                                else
                                {
                                    if(textBox_noTelp.Text.Length < 10)
                                    {
                                        MessageBox.Show("Masukkan nomor handphone anda dengan benar", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        textBox_noTelp.Focus();
                                    } else
                                    {
                                        //logic password
                                        if (string.IsNullOrEmpty(textBox_password.Text))
                                        {
                                            MessageBox.Show("password tidak boleh kosong", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            textBox_password.Focus();
                                        }
                                        else
                                        {
                                            if (textBox_password.Text.Length < 8)
                                            {
                                                MessageBox.Show("panjang password tidak boleh kurang dari 8 karakter", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                textBox_password.Focus();
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    
                }
                else
                {
                    MessageBox.Show("Username tidak boleh kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox_username.Focus();
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
