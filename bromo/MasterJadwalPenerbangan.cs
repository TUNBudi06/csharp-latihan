using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
        private int id_user;

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
                        " FORMAT(jp.DurasiPenerbangan / 60, '00') + ' Jam ' + FORMAT(jp.DurasiPenerbangan % 60, '00') + ' Menit' AS DurasiPenerbangan," +
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
            try
            {
                if (e.ColumnIndex >= 0 && dataGridView_mjp.Columns[e.ColumnIndex].Name == "ubahData")
                {
                    updateData = true;
                    DataGridViewRow row = dataGridView_mjp.Rows[e.RowIndex];
                    masked_kode.Text = row.Cells["KodePenerbangan"].Value.ToString();
                    combo_dari.Text = row.Cells["BandaraKeberangkatan"].Value.ToString();
                    combo_ke.Text = row.Cells["BandaraTujuan"].Value.ToString();
                    combo_maskapai.Text = row.Cells["Maskapai"].Value.ToString();

                    DateTime dt = DateTime.Parse(row.Cells["TanggalWaktuKeberangkatan"].Value.ToString());
                    picker_tanggal.Value = dt;
                    masked_waktu.Text = $"{dt.ToString("HH"):D2}:{dt.ToString("mm"):D2}";
                    masked_durasi.Text = row.Cells["DurasiPenerbangan"].Value.ToString();
                    id_user = int.Parse(row.Cells["ID"].Value.ToString());

                    numericUpDown_hargaPerTiket.Value = int.Parse(row.Cells["HargaPerTiket"].Value.ToString());
                }
                if (e.ColumnIndex >= 0 && dataGridView_mjp.Columns[e.ColumnIndex].Name == "hapusData")
                {
                    DataGridViewRow row = dataGridView_mjp.Rows[e.RowIndex];
                    using (SqlConnection sqls = conn.koneksi())
                    {
                        try
                        {
                            sqls.Open();
                            SqlCommand sqlc = sqls.CreateCommand();
                            sqlc.CommandType = CommandType.Text;
                            sqlc.CommandText = "delete from JadwalPenerbangan where ID = @id;";
                            sqlc.Parameters.AddWithValue("@id", row.Cells["ID"].Value.ToString());
                            if (MessageBox.Show("apakah kamu mau menghapus barisan ini?","Question",MessageBoxButtons.OKCancel,MessageBoxIcon.Question) == DialogResult.OK)
                            {
                                int result = sqlc.ExecuteNonQuery();
                                if (result > 0)
                                {
                                    MessageBox.Show("successfully delete data", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("no data deleted", "failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.ToString());

                        }
                        finally
                        {
                            sqls.Close();
                        }
                    }
                }
            } finally
            {
                loadTable();
            }
        }

        private void batal()
        {
            updateData = false;
            masked_kode.Clear();
            combo_dari.SelectedValue = 68;
            combo_ke.SelectedValue = 68;
            combo_maskapai.SelectedText = "Adam Air";
            picker_tanggal.Value = DateTime.Now;
            masked_waktu.Clear();
            masked_durasi.Clear();
            numericUpDown_hargaPerTiket.Value = 1;
        }

        private void button_batal_Click(object sender, EventArgs e)
        {
            batal();
        }

        private void button_simpan_Click(object sender, EventArgs e)
        {
            try
            {
                if (updateData)
                {
                    string kp = masked_kode.Text;
                    string dari = combo_dari.SelectedValue.ToString();
                    string ke = combo_ke.SelectedValue.ToString();
                    string maskapai = combo_maskapai.SelectedValue.ToString();
                    string tanggal = picker_tanggal.Value.ToString("MM/dd/yyyy") + " " + masked_waktu.Text;
                    string[] durasiParts = masked_durasi.Text.Split(' ');
                    int validDurasi = (int.Parse(durasiParts[0]) * 60) + int.Parse(durasiParts[2]);
                    if ( validDurasi >= 1439)
                    {
                        MessageBox.Show("durasi penerbangan tidak valid", "validation failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    string menitDurasi = string.Concat((int.Parse(durasiParts[0]) * 60) + int.Parse(durasiParts[2]));
                    string hpt = numericUpDown_hargaPerTiket.Value.ToString();

                    using (SqlConnection sqls = conn.koneksi())
                    {
                        try
                        {
                            sqls.Open();

                            using (SqlCommand sqlc = sqls.CreateCommand())
                            {
                                sqlc.CommandType = CommandType.Text;
                                sqlc.CommandText = "update JadwalPenerbangan set KodePenerbangan = @kp,BandaraKeberangkatanID = @bk,BandaraTujuanID = @bt,MaskapaiID = @maskapai,TanggalWaktuKeberangkatan = @twk, DurasiPenerbangan =  @durasi," +
                                     " HargaPerTiket = @hpt where ID = @id;";
                                sqlc.Parameters.AddWithValue("@kp", kp);
                                sqlc.Parameters.AddWithValue("@bk", dari);
                                sqlc.Parameters.AddWithValue("@bt", ke);
                                sqlc.Parameters.AddWithValue("@maskapai", maskapai);
                                sqlc.Parameters.AddWithValue("@twk", tanggal);
                                sqlc.Parameters.AddWithValue("@durasi", menitDurasi);
                                sqlc.Parameters.AddWithValue("@hpt", hpt);
                                sqlc.Parameters.AddWithValue("@id", id_user);

                                if (dari == ke)
                                {
                                    MessageBox.Show("bandara keberangkatan dan tujuan tidak boleh sama","Error",MessageBoxButtons.OK,MessageBoxIcon.Information);
                                    return;
                                }
                                int result = sqlc.ExecuteNonQuery();
                                if (result > 0)
                                {
                                    MessageBox.Show("successfully update data", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                } else
                                {
                                    MessageBox.Show("cannot update data", "failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Error: " + ex);
                        }
                        finally
                        {
                            sqls.Close();
                        }
                    }
                    Console.WriteLine(menitDurasi);
                }
                else
                {
                    using(SqlConnection sqls = conn.koneksi())
                    {
                        string kp = masked_kode.Text;
                        string dari = combo_dari.SelectedValue.ToString();
                        string ke = combo_ke.SelectedValue.ToString();
                        string maskapai = combo_maskapai.SelectedValue.ToString();
                        string tanggal = picker_tanggal.Value.ToString("MM/dd/yyyy") + " " + masked_waktu.Text;
                        string[] durasiParts = masked_durasi.Text.Split(' ');
                        int validDurasi = (int.Parse(durasiParts[0]) * 60) + int.Parse(durasiParts[2]);
                        if (validDurasi >= 1439)
                        {
                            MessageBox.Show("durasi penerbangan tidak valid", "validation failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        string menitDurasi = string.Concat((int.Parse(durasiParts[0]) * 60) + int.Parse(durasiParts[2]));
                        string hpt = numericUpDown_hargaPerTiket.Value.ToString();
                        try
                        {
                            sqls.Open();
                            SqlCommand sqlc = sqls.CreateCommand();
                            sqlc.CommandType = CommandType.Text;
                            sqlc.CommandText = "insert into JadwalPenerbangan (KodePenerbangan,BandaraKeberangkatanID,BandaraTujuanID,MaskapaiID,TanggalWaktuKeberangkatan,DurasiPenerbangan,HargaPerTiket) " +
                                "values (@kp,@bk,@bt,@maskapai,@twk,@durasi,@hpt)";
                            sqlc.Parameters.AddWithValue("@kp", kp);
                            sqlc.Parameters.AddWithValue("@bk", dari);
                            sqlc.Parameters.AddWithValue("@bt", ke);
                            sqlc.Parameters.AddWithValue("@maskapai", maskapai);
                            sqlc.Parameters.AddWithValue("@twk", tanggal);
                            sqlc.Parameters.AddWithValue("@durasi", menitDurasi);
                            sqlc.Parameters.AddWithValue("@hpt", hpt);

                            int result = sqlc.ExecuteNonQuery();
                            if (result > 0)
                            {
                                MessageBox.Show("Successfully added data", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            } else
                            {
                                MessageBox.Show("failed to add data", "failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        finally
                        {
                            sqls.Close();
                        }
                    }
                }
            } catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex);
            }
            finally
            {
                loadTable();
                batal();
            }
        }
    }
}
