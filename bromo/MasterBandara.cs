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
    public partial class MasterBandara : Form
    {
        public MasterBandara()
        {
            InitializeComponent();
        }

        private void MasterBandara_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bromoAirlines.Negara' table. You can move, or remove it, as needed.
            this.negaraTableAdapter.Fill(this.bromoAirlines.Negara);
            // TODO: This line of code loads data into the 'bromoAirlines.Bandara' table. You can move, or remove it, as needed.
            this.bandaraTableAdapter.Fill(this.bromoAirlines.Bandara);
            Utils conn = new Utils();

            //using (SqlConnection sqls = conn.koneksi())
            //{
            //    try
            //    {
            //        sqls.Open();

            //        string query = "select * from Bandara;";

            //        SqlCommand cmd = sqls.CreateCommand();

            //        cmd.CommandType = CommandType.Text;
            //        cmd.CommandText = query;

            //        SqlDataAdapter data = new SqlDataAdapter();

            //        data.SelectCommand = cmd;

            //        DataTable dt = new DataTable();
            //        data.Fill(dt);

            //        bandaraTableAdapter.Fill(dt);
            //    }
            //    catch
            //    {

            //    }
            //}
        }

        private void label_nama_Click(object sender, EventArgs e)
        {

        }

        private void textBox_terminal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && e.KeyChar != (char)(Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void textBox_kodeIATA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (this.textBox_kodeIATA.Text.Length > 3)
            {
                e.Handled = true;
            }
        }
    }
}
