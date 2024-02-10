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
    public partial class MasterMaskapai : Form
    {
        public MasterMaskapai()
        {
            InitializeComponent();
        }
        
        Utils conn = new Utils();
        bool isUpdateData = false;

        public void loadtable()
        {
            string query = "select ID, Nama, Perusahaan, JumlahKru, Deskripsi from Maskapai order by Nama asc;";
            using (SqlConnection sqls = conn.koneksi())
            {
                sqls.Open();
                SqlCommand sql = sqls.CreateCommand();
                sql.CommandText = query;
                sql.CommandType = CommandType.Text;

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = sql;

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                this.maskapai.DataSource = dt;
                this.maskapai.Columns["ID"].Visible = false;
                //Console.WriteLine(this.maskapai.ColumnCount.ToString());
                if (this.maskapai.ColumnCount < 6)
                {
                    DataGridViewButtonColumn ubah = new DataGridViewButtonColumn();
                    ubah.Name = "ubahData";
                    ubah.Text = "ubah";
                    ubah.UseColumnTextForButtonValue = true;

                    DataGridViewButtonColumn hapus = new DataGridViewButtonColumn();
                    hapus.Name = "hapusData";
                    hapus.Text = "hapus";
                    hapus.UseColumnTextForButtonValue = true;

                    maskapai.Columns.Insert(5, ubah);
                    maskapai.Columns.Insert(6, hapus);
                }
            }
        }

        private void MasterMaskapai_Load(object sender, EventArgs e)
        {
            loadtable();
        }

        private void maskapai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && maskapai.Columns[e.ColumnIndex].Name == "ubahData")
            {
                isUpdateData = true;

                DataGridViewRow row = maskapai.Rows[e.RowIndex];
                textBox_nama.Text = row.Cells["Nama"].Value.ToString();
                textBox_perusahaan.Text = row.Cells["Perusahaan"].Value.ToString();
                numericUpDown_kru.Value = int.Parse(row.Cells["JumlahKru"].Value.ToString());
                richTextBox_deskripsi.Text = row.Cells["Deskripsi"].Value.ToString();

            }
        }

        private void button_batal_Click(object sender, EventArgs e)
        {
            isUpdateData = false;

            textBox_nama.Clear();
            textBox_perusahaan.Clear();
            numericUpDown_kru.Value = 1;
            richTextBox_deskripsi.Clear();

        }
    }
}
