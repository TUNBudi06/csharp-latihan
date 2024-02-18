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
    public partial class MasterJadwalPenerbangan : Form
    {
        public MasterJadwalPenerbangan()
        {
            InitializeComponent();
        }
        Utils conn = new Utils();
        private bool updateData = false;

        public void loadDataBinding()
        {
            using (SqlConnection sqls = conn.koneksi())
            {
                try
                {
                    sqls.Open();

                    using (SqlCommand cmd = sqls.CreateCommand())
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "SELECT * FROM Bandara ORDER BY Nama ASC";

                        using (SqlDataAdapter sdaa = new SqlDataAdapter(cmd))
                        {
                            DataSet dsBK = new DataSet();
                            DataSet dsBT = new DataSet();
                            sdaa.Fill(dsBK, "Bandara");
                            sdaa.Fill(dsBT, "Bandara");

                            if (dsBK.Tables["Bandara"].Rows.Count > 0)
                            {
                                combo_dari.DataSource = dsBK.Tables["Bandara"];
                                combo_dari.DisplayMember = "Nama";
                                combo_dari.ValueMember = "ID";
                                combo_dari.SelectedValue = 68;

                                combo_ke.DataSource = dsBT.Tables["Bandara"];
                                combo_ke.DisplayMember = "Nama";
                                combo_ke.ValueMember = "ID";
                                combo_ke.SelectedValue = 68;
                            }
                            else
                            {
                                Console.WriteLine("No data found in the Bandara table.");
                            }
                        }
                        using (SqlDataAdapter sdab = new SqlDataAdapter(cmd))
                        {
                            cmd.CommandText = "SELECT * FROM Maskapai ORDER BY Nama ASC";

                            DataSet dsMaskapai = new DataSet();
                            sdab.Fill(dsMaskapai, "Maskapai");

                            if (dsMaskapai.Tables["Maskapai"].Rows.Count > 0)
                            {
                                combo_maskapai.DataSource = dsMaskapai.Tables["Maskapai"];
                                combo_maskapai.DisplayMember = "Nama";
                                combo_maskapai.ValueMember = "ID";
                                combo_maskapai.SelectedText = "Adam Air";
                            }
                            else
                            {
                                Console.WriteLine("No data found in the Bandara table.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
                finally
                {
                    sqls.Close();
                }
            }
        }

        public void loadTable()
        {
            using(SqlConnection sqls = conn.koneksi())
            {
                try
                {
                    sqls.Open();
                    string query = "SELECT jp.ID AS ID, jp.KodePenerbangan as KodePenerbangan, bk.Nama AS BandaraKeberangkatan, bt.Nama AS BandaraTujuan, m.Nama AS Maskapai, jp.TanggalWaktuKeberangkatan AS TanggalWaktuKeberangkatan," +
    " convert(nvarchar(2),jp.DurasiPenerbangan / 60) + ' Jam ' + convert(nvarchar(2),jp.DurasiPenerbangan % 60) + ' menit' AS DurasiPenerbangan," +
    " jp.HargaPerTiket AS HargaPerTiket" +
    " FROM JadwalPenerbangan AS jp" +
    " JOIN Bandara AS bk ON jp.BandaraKeberangkatanID = bk.ID" +
    " JOIN Bandara AS bt ON jp.BandaraTujuanID = bt.ID" +
    " JOIN Maskapai AS m ON jp.MaskapaiID = m.ID order by TanggalWaktuKeberangkatan desc";


                    SqlCommand sqlc = sqls.CreateCommand();
                    sqlc.CommandText = query;
                    sqlc.CommandType = CommandType.Text;

                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.SelectCommand = sqlc;

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    this.dataGridView_mjp.Rows.Clear();
                    this.dataGridView_mjp.Columns.Clear();
                    this.dataGridView_mjp.DataSource = dt;
                    this.dataGridView_mjp.Columns["ID"].Visible = false;
                    this.dataGridView_mjp.AllowUserToAddRows = false;
                    Console.WriteLine(this.dataGridView_mjp.ColumnCount);

                    DataGridViewButtonColumn btn_ubah = new DataGridViewButtonColumn();
                    DataGridViewButtonColumn btn_hapus = new DataGridViewButtonColumn();
                    btn_ubah.Name = "ubahData";
                    btn_hapus.Name = "hapusData";
                    btn_ubah.Text = "Ubah";
                    btn_hapus.Text = "Hapus";
                    btn_hapus.UseColumnTextForButtonValue = true;
                    btn_ubah.UseColumnTextForButtonValue = true;
                    this.dataGridView_mjp.Columns.Insert(8, btn_ubah);
                    this.dataGridView_mjp.Columns.Insert(9, btn_hapus);
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("error: " + ex);
                }
                finally
                {
                    sqls.Close();
                }
            }
        }

        private void MasterJadwalPenerbangan_Load(object sender, EventArgs e)
        {
            loadDataBinding();

            loadTable();
        }


        private void dataGridView_mjp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex >= 0  && dataGridView_mjp.Columns[e.ColumnIndex].Name == "ubahData")
            {
                updateData = true;
                DataGridViewRow row = dataGridView_mjp.Rows[e.RowIndex];
                masked_kode.Text = row.Cells["KodePenerbangan"].Value.ToString();
                combo_dari.Text = row.Cells["BandaraKeberangkatan"].Value.ToString();
                combo_ke.Text = row.Cells["BandaraTujuan"].Value.ToString();
                combo_maskapai.Text = row.Cells["Maskapai"].Value.ToString();

                DateTime dt = DateTime.Parse(row.Cells["TanggalWaktuKeberangkatan"].Value.ToString());
                picker_tanggal.Value = dt;
                masked_waktu.Text = dt.ToString("HH:mm");
                numericUpDown_hargaPerTiket.Value = int.Parse(row.Cells["HargaPerTiket"].Value.ToString());
            }
            if (e.ColumnIndex >= 0 && dataGridView_mjp.Columns[e.ColumnIndex].Name == "hapusData")
            {
                DataGridViewRow row = dataGridView_mjp.Rows[e.RowIndex];
                using(SqlConnection sqls = conn.koneksi())
                {
                    try
                    {
                        sqls.Open();
                        SqlCommand sqlc = sqls.CreateCommand();
                        sqlc.CommandType = CommandType.Text;
                        sqlc.CommandText = "delete from JadwalPenerbangan where ID = @id;";
                        sqlc.Parameters.AddWithValue("@id", row.Cells["ID"].Value.ToString());
                    } catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());

                    } finally
                    {
                        sqls.Close();
                    }
                }
            }
        }

        private void button_batal_Click(object sender, EventArgs e)
        {
            updateData = false;
            masked_kode.Clear();
            combo_dari.SelectedValue = 68;
            combo_ke.SelectedValue = 68;
            combo_maskapai.SelectedText = "Adam Air";
            picker_tanggal.Value = DateTime.Now;
            masked_waktu.Clear();
            numericUpDown_hargaPerTiket.Value = 1;
        }
    }
}
