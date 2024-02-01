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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        Utils koneksi = new Utils();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox_showPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_showPassword.Checked)
                textBox_password.PasswordChar = '\0';
            else
                textBox_password.PasswordChar = '*';
        }

        private void linkLabel_Daftar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register register = new Register();
            this.Hide();
            register.ShowDialog();
            this.Show();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            SqlConnection conn = koneksi.koneksi();
            try
            {
                string query = "select * From Akun where Username = '" + textBox_username.Text + "' AND Password = '" + textBox_password.Text + "'";
                

                SqlDataAdapter run = new SqlDataAdapter(query, conn);

                DataTable dt_user = new DataTable();
                run.Fill(dt_user);
                
                if( dt_user.Rows.Count == 1 )
                {
                    string username = textBox_username.Text;
                    string password = textBox_password.Text;
                    DataRow dt_user_row = dt_user.Rows[0];
                    Console.WriteLine("1");
                    int admin = Convert.ToInt32(dt_user_row["MerupakanAdmin"]);
                    Console.WriteLine("2");

                    if ( admin == 0  )
                    {
                        customerForm cform = new customerForm();
                        this.Hide();
                        cform.ShowDialog();
                        this.ShowDialog();
                    } else
                    {
                        adminform aform = new adminform();
                        this.Hide(); aform.ShowDialog();
                        this.Show();
                    }
                } else
                {
                    MessageBox.Show("Password and Username tidak cocok", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox_password.Clear();
                    textBox_username.Focus();

                }
            } catch 
            {

            }
            finally 
            { 
                conn.Close();
            }
        }

        private void textBox_username_KeyPress(object sender, KeyPressEventArgs e)
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
                button_login.PerformClick();
                e.Handled = true;
            }
        }
    }
}
