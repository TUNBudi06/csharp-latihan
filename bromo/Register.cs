﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
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
        Utils conn = new Utils();
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
                    string getUsername = "select * from Akun where Username = @username";
                    SqlParameter[] sqlParameter = new SqlParameter[] 
                    { 
                        new SqlParameter("username", textBox_username.Text)
                    };

                    //SqlDataAdapter sqldata = conn.sqlselect(getUsername,sqlParameter); 
                    SqlCommand cmd = conn.koneksi().CreateCommand();

                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = getUsername;
                    cmd.Parameters.AddRange(sqlParameter);
                    //Console.WriteLine(cmd.ToString());

                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.SelectCommand = cmd;

                    DataTable dt_user = new DataTable();
                    adapter.Fill(dt_user);
                    if (dt_user.Rows.Count > 0)
                    {
                        MessageBox.Show("Username telah dipakai", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox_username.Focus();
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(textBox_name.Text))
                        {
                            MessageBox.Show("Kolom nama tidak boleh kosong", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            // logic of tanggal_lahir
                            // add .date for filter only date can go throught without time
                            // and convert to string to filter time
                            DateTime dt_now = DateTime.Now.Date;
                            //Console.WriteLine("test");
                            DateTime dt = tanggal_lahir.Value.Date;
                            if (DateTime.Compare(dt, dt_now) == 0)
                            {
                                MessageBox.Show("Masukkan tanggal lahir anda", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                tanggal_lahir.Focus();
                                //Console.WriteLine(dt);
                            }
                            else if (DateTime.Compare(dt, dt_now) > 0)
                            {
                                MessageBox.Show("Masukkan tanggal lahir anda dengan benar", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                tanggal_lahir.Focus();
                            }
                            else
                            {
                                if (string.IsNullOrEmpty(textBox_noTelp.Text))
                                {
                                    MessageBox.Show("nomor telepon tidak boleh kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    textBox_noTelp.Focus();
                                }
                                else if (textBox_noTelp.Text.Length < 10)
                                {
                                    MessageBox.Show("Masukkan nomor telepon anda dengan benar", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    textBox_noTelp.Focus();
                                }
                                else
                                {
                                    // Check for password
                                    Console.WriteLine("testing");
                                    if (string.IsNullOrEmpty(textBox_password.Text))
                                    {
                                        MessageBox.Show("Password tidak boleh kosong", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        textBox_password.Focus();
                                    }
                                    else if (textBox_password.Text.Length < 8)
                                    {
                                        MessageBox.Show("Panjang password tidak boleh kurang dari 8 karakter", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        textBox_password.Focus();
                                    }
                                    else
                                    {
                                        // Insert into Akun table
                                        string queue = "INSERT INTO Akun(Username, Password, nama, TanggalLahir, Nomortelepon, merupakanAdmin) VALUES (@username, @password, @nama, @tglLahir, @nomorTelepon, 0)";

                                        SqlParameter[] parameters = new SqlParameter[]
                                        {
                                        new SqlParameter("@username", textBox_username.Text),
                                        new SqlParameter("@password", textBox_password.Text),
                                        new SqlParameter("@nama", textBox_name.Text),
                                        new SqlParameter("@tglLahir", dt.ToString("yyyy-MM-dd")),
                                        new SqlParameter("@nomorTelepon", textBox_noTelp.Text)
                                        };

                                        SqlConnection sql = conn.koneksi();
                                        SqlCommand sqlinsert = sql.CreateCommand();
                                        sqlinsert.CommandType = CommandType.Text;
                                        sqlinsert.CommandText = queue;
                                        sqlinsert.Parameters.AddRange(parameters);
                                        Debug.WriteLine("result.ToString()");
                                        try
                                        {
                                            sql.Open();
                                            int result = sqlinsert.ExecuteNonQuery();


                                            if (result < 1)
                                            {
                                                MessageBox.Show("Registrasi gagal, silahkan coba lagi", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            }
                                            else
                                            {
                                                customerForm cform = new customerForm();
                                                this.Hide();
                                                cform.ShowDialog();
                                                this.Close();
                                            }
                                        }
                                        catch 
                                        {
                                            //MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                        finally
                                        {
                                            sql.Close();
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

            }
        }
    }
}
