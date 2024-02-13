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
        int idValue = 0;

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
                idValue = int.Parse(row.Cells["ID"].Value.ToString());

            }

            if( e.ColumnIndex >= 0 && maskapai.Columns[e.ColumnIndex].Name == "hapusData")
            {
                if(MessageBox.Show(string.Format("kamu yakin ingin menghapus baris ini?", e.ColumnIndex), "warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes)
                {
                    string query = "delete from maskapai where id = @id;";

                    using (SqlConnection sqls = conn.koneksi())
                    {
                        sqls.Open();
                        DataGridViewRow row = maskapai.Rows[e.RowIndex];
                        SqlCommand sqlc = sqls.CreateCommand();

                        sqlc.CommandType = CommandType.Text;
                        sqlc.CommandText = query;
                        sqlc.Parameters.AddWithValue("@id", row.Cells["id"].Value);

                        int result = sqlc.ExecuteNonQuery();
                        if(result > 0)
                        {
                            MessageBox.Show("successfully delete row", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            loadtable();
                            return;
                        }
                    }
                }
            }
        }

        private void clearData()
        {
            textBox_nama.Clear();
            textBox_perusahaan.Clear();
            numericUpDown_kru.Value = 1;
            richTextBox_deskripsi.Clear();
        }

        private void button_batal_Click(object sender, EventArgs e)
        {
            isUpdateData = false;

            clearData();
        }

        private void button_simpan_Click(object sender, EventArgs e)
        {
            try
            {
                if (isUpdateData)
                {
                    if (string.IsNullOrEmpty(textBox_nama.Text) || string.IsNullOrEmpty(textBox_perusahaan.Text) ||
                        string.IsNullOrEmpty(richTextBox_deskripsi.Text) || numericUpDown_kru.Value == 0)
                    {
                        MessageBox.Show("please fill the empty box,a empty box cant be null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    string query = "update maskapai set Nama = @nama,Perusahaan = @perusahaan,JumlahKru = @jk,Deskripsi = @desc where ID = @id";
                    using (SqlConnection sqls = conn.koneksi())
                    {
                        sqls.Open();
                        SqlCommand sqlc = sqls.CreateCommand();

                        sqlc.CommandText = query;
                        sqlc.CommandType = CommandType.Text;
                        sqlc.Parameters.AddWithValue("@nama", textBox_nama.Text);
                        sqlc.Parameters.AddWithValue("@perusahaan", textBox_perusahaan.Text);
                        sqlc.Parameters.AddWithValue("@jk", numericUpDown_kru.Value);
                        sqlc.Parameters.AddWithValue("@desc", richTextBox_deskripsi.Text);
                        sqlc.Parameters.AddWithValue("@id", idValue);

                        int result = sqlc.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("successfully update data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                } else
                {
                    if (string.IsNullOrEmpty(textBox_nama.Text) || string.IsNullOrEmpty(textBox_perusahaan.Text) ||
                        string.IsNullOrEmpty(richTextBox_deskripsi.Text) || numericUpDown_kru.Value == 0)
                    {
                        MessageBox.Show("please fill the empty box,a empty box cant be null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    string query = "insert into maskapai(Nama,Perusahaan,JumlahKru,Deskripsi) values (@nama,@perusahaan,@jk,@desc);";
                    using (SqlConnection sqls = conn.koneksi())
                    {
                        sqls.Open();
                        SqlCommand sqlc = sqls.CreateCommand();

                        sqlc.CommandText = query;
                        sqlc.CommandType = CommandType.Text;
                        sqlc.Parameters.AddWithValue("@nama", textBox_nama.Text);
                        sqlc.Parameters.AddWithValue("@perusahaan", textBox_perusahaan.Text);
                        sqlc.Parameters.AddWithValue("@jk", numericUpDown_kru.Value);
                        sqlc.Parameters.AddWithValue("@desc", richTextBox_deskripsi.Text);

                        int result = sqlc.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("successfully added data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            } finally
            {
                isUpdateData =false;
                clearData();
                loadtable();
            }
        }
    }
}
