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
    public partial class MasterKodePromo : Form
    {
        public MasterKodePromo()
        {
            InitializeComponent();
        }
        Utils conn = new Utils();
        string user_id = null;
        bool updateData = false;


        public void loadtable()
        {
           using(SqlConnection sqls = conn.koneksi())
            {
                try
                {
                    sqls.Open();
                    SqlCommand sqlc = sqls.CreateCommand();
                    sqlc.CommandType = CommandType.Text;
                    sqlc.CommandText = "select * from KodePromo";
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
                    sqlDataAdapter.SelectCommand = sqlc;
                    DataTable dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);
                    if (dataGridView_kodepromo.ColumnCount > 0)
                    {
                        dataGridView_kodepromo.Columns.Clear();
                    }
                    dataGridView_kodepromo.DataSource = dataTable;
                    dataGridView_kodepromo.Columns["ID"].Visible = false;
                    dataGridView_kodepromo.AllowUserToAddRows = false;
                    for (int i = 0; i < dataGridView_kodepromo.ColumnCount; i++)
                    {
                        dataGridView_kodepromo.Columns[i].ReadOnly = true;
                    }
                    dataGridView_kodepromo.Columns["Deskripsi"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    DataGridViewButtonColumn ubah = new DataGridViewButtonColumn();
                    DataGridViewButtonColumn hapus = new DataGridViewButtonColumn();
                    ubah.Name = "ubahData";
                    ubah.Text = "Ubah";
                    hapus.Name = "hapusData";
                    hapus.Text = "hapus";
                    ubah.UseColumnTextForButtonValue = true;
                    hapus.UseColumnTextForButtonValue = true;
                    dataGridView_kodepromo.Columns.Insert(dataGridView_kodepromo.ColumnCount, ubah);
                    dataGridView_kodepromo.Columns.Insert(dataGridView_kodepromo.ColumnCount, hapus);
                }
                finally
                {
                    sqls.Close();
                }
           }

        }

        private void MasterKodePromo_Load(object sender, EventArgs e)
        {
            loadtable();
        }

        private void dataGridView_kodepromo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && dataGridView_kodepromo.Columns[e.ColumnIndex].Name == "ubahData")
            {
                DataGridViewRow row = dataGridView_kodepromo.Rows[e.RowIndex];
                textBox_kodePromo.Text = row.Cells["Kode"].Value.ToString();
                string date = row.Cells["BerlakuSampai"].Value.ToString();
                Console.WriteLine(date);
                //DateTime dt = DateTime.ParseExact(date, "dd-MM-yyyy", CultureInfo.InvariantCulture);
                DateTime.TryParse(date, out DateTime dt);
                dateTimePicker_berlakusampai.Value = dt;
                numericUpDown_persentasediskon.Value = int.Parse(row.Cells["PersentaseDiskon"].Value.ToString());
                numericUpDown_minimumdiskon.Value = int.Parse(row.Cells["MaksimumDiskon"].Value.ToString());
                richTextBox_deskripsi.Text = row.Cells["Deskripsi"].Value.ToString();
                user_id = row.Cells["ID"].Value.ToString();
                updateData = true;
            }
            if (e.ColumnIndex >= 0 && dataGridView_kodepromo.Columns[e.ColumnIndex].Name == "hapusData")
            {
                if (MessageBox.Show("are you sure to want delete this row?","QUESTION!!",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection sqls = conn.koneksi())
                    {
                        try
                        {
                            DataGridViewRow row = dataGridView_kodepromo.Rows[e.RowIndex];
                            sqls.Open();
                            SqlCommand sqlc = sqls.CreateCommand();
                            sqlc.CommandText = "delete from KodePromo where ID = @id";
                            sqlc.CommandType = CommandType.Text;
                            sqlc.Parameters.AddWithValue("@id", row.Cells["ID"].Value.ToString());
                            int result = sqlc.ExecuteNonQuery();
                            if (result > 0)
                            {
                                MessageBox.Show("successfully deleted data", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        finally
                        {
                            sqls.Close();
                            loadtable();
                            clearText();
                        }
                    }
                }
            }
        }
        private void clearText()
        {
            textBox_kodePromo.Clear();
            dateTimePicker_berlakusampai.Value = DateTime.Now;
            numericUpDown_persentasediskon.Value = 1;
            numericUpDown_minimumdiskon.Value = 1;
            richTextBox_deskripsi.Clear(); updateData = false;
        }

        private void button_batal_Click(object sender, EventArgs e)
        {
            clearText();
            
        }

        private void button_simpan_Click(object sender, EventArgs e)
        {
            string query;
            if (updateData)
            {
                 query = "update KodePromo set Kode = @kode,PersentaseDiskon = @pd,MaksimumDiskon = @md,BerlakuSampai = @bs,Deskripsi = @dk where id = @id";
            } else
            {
                 query = "insert into KodePromo(Kode,PersentaseDiskon,MaksimumDiskon,BerlakuSampai,Deskripsi) values (@kode,@pd,@md,@bs,@dk)";
            }
            using (SqlConnection sqls = conn.koneksi())
            {
                try
                {
                    sqls.Open();
                    SqlCommand sqlc = sqls.CreateCommand();
                    sqlc.CommandText = query;
                    sqlc.CommandType = CommandType.Text;
                    sqlc.Parameters.AddWithValue("@kode",textBox_kodePromo.Text);
                    sqlc.Parameters.AddWithValue("@pd",numericUpDown_persentasediskon.Value);
                    sqlc.Parameters.AddWithValue("@md",numericUpDown_minimumdiskon.Value);
                    sqlc.Parameters.AddWithValue("@bs",dateTimePicker_berlakusampai.Value.ToString("yyyy-MM-dd"));
                    sqlc.Parameters.AddWithValue("@dk",richTextBox_deskripsi.Text );
                    if (updateData) sqlc.Parameters.AddWithValue("@id", user_id); ;
                    int result = sqlc.ExecuteNonQuery();
                    if(result > 0 )
                    {
                        MessageBox.Show(string.Format("successfully {0} data", updateData ? "Updated" : "Insert"),"Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                }
                finally
                {
                    sqls.Close();
                    clearText();
                    loadtable();
                }
            }
        }
    }
}
