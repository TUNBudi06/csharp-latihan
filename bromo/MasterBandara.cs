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
        Utils conn = new Utils();

        public void loadtable()
        {

            using (SqlConnection sqls = conn.koneksi())
            {
                try
                {
                    sqls.Open();

                    string query = "select ID,Nama,KodeIATA,Kota,NegaraID,JumlahTerminal as 'Jumlah Terminal',Alamat from Bandara;";

                    SqlCommand cmd = sqls.CreateCommand();

                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;

                    SqlDataAdapter data = new SqlDataAdapter();

                    data.SelectCommand = cmd;

                    DataTable dt = new DataTable();
                    data.Fill(dt);

                    
                    this.BandaraGV.DataSource = dt;
                    this.BandaraGV.AllowUserToAddRows = false;
                    this.BandaraGV.Columns["ID"].Visible = false;
                }
                finally
                {
                    sqls.Close();
                }
            }
        }

        private void MasterBandara_Load(object sender, EventArgs e)
        {
            loadtable();
            DataGridViewButtonColumn Ubah = new DataGridViewButtonColumn();
            Ubah.Text = "Ubah";
            Ubah.UseColumnTextForButtonValue = true;

            Ubah.Width = 100;
            DataGridViewButtonColumn Hapus = new DataGridViewButtonColumn();
            Hapus.Text = "Hapus";
            Hapus.Width = 100;
            Hapus.UseColumnTextForButtonValue = true;

            BandaraGV.Columns.Insert(7, Ubah);
            BandaraGV.Columns.Insert(8, Hapus);
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

        private void BandaraGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7)
            {
                DataGridViewRow curRow = BandaraGV.Rows[e.RowIndex];
                if (MessageBox.Show(String.Format("Do you want change the row?", curRow.Cells["ID"].Value), "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SqlConnection sqls = conn.koneksi();
                    try
                    {
                        sqls.Open();

                        SqlCommand cmd = sqls.CreateCommand();

                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "update Bandara set Nama = @nama,KodeIATA = @iata,Kota = @kota,NegaraID = @negara,JumlahTerminal = @terminal,Alamat = @alamat where ID = @curr";

                        cmd.Parameters.AddWithValue("@nama", curRow.Cells["nama"].Value);
                        cmd.Parameters.AddWithValue("@iata", curRow.Cells["KodeIATA"].Value);
                        cmd.Parameters.AddWithValue("@kota", curRow.Cells["Kota"].Value);
                        cmd.Parameters.AddWithValue("@negara", curRow.Cells["NegaraID"].Value);
                        cmd.Parameters.AddWithValue("@terminal", curRow.Cells["Jumlah Terminal"].Value);
                        cmd.Parameters.AddWithValue("@curr", curRow.Cells["ID"].Value);
                        cmd.Parameters.AddWithValue("@alamat", curRow.Cells["Alamat"].Value);

                        cmd.ExecuteNonQuery();
                        loadtable();
                    }
                    finally
                    {
                        sqls.Close();
                    }
                }
            }

            if (e.ColumnIndex == 8)
            {
                DataGridViewRow curRow = BandaraGV.Rows[e.RowIndex];
                if (MessageBox.Show(String.Format("Do you want delete the row?", curRow.Cells["ID"].Value), "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SqlConnection sqls = conn.koneksi();
                    try
                    {
                        sqls.Open();

                        SqlCommand cmd = sqls.CreateCommand();

                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "delete from bandara where ID = @curr";
                        cmd.Parameters.AddWithValue("@curr", curRow.Cells["ID"].Value);

                        cmd.ExecuteNonQuery();
                        loadtable();
                    }
                    finally
                    {
                        sqls.Close();
                    }
                }
            }
        }
    }
}
