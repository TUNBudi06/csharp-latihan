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
    public partial class UbahStatusPenerbangan : Form
    {
        public UbahStatusPenerbangan()
        {
            InitializeComponent();
        }

        Utils conn = new Utils();
        bool update = true;
        DataGridViewRow row = new DataGridViewRow();

        public void loadtable()
        {
            using (SqlConnection sqls = conn.koneksi())
            {
                try
                {
                    sqls.Open();
                    SqlCommand sqlc = sqls.CreateCommand();
                    sqlc.CommandType = CommandType.Text;
                    sqlc.CommandText = "select pjp.ID as ID,pjp.PerkiraanDurasiDelay as pdd,jp.KodePenerbangan,mk.Nama as Maskapai,bk.Nama as Bandarakeberangkatan," +
                        "bt.Nama as BandaraTujuan,format(jp.TanggalWaktuKeberangkatan,'yyyy-MM-dd') as TanggalKeberangkatan," +
                        "format(jp.TanggalWaktuKeberangkatan,'HH:mm::ss') as WaktuKeberangkatan" +
                        ",concat(format(jp.DurasiPenerbangan / 60,'00'),' Jam ',format(jp.DurasiPenerbangan % 60,'00'),' Menit') as DurasiPenerbangan," +
                        "case " +
                        " when pjp.StatusPenerbanganID = 3 then concat(sp.Nama,' (',format(pjp.PerkiraanDurasiDelay / 60,'00'),' Jam ',format(pjp.PerkiraanDurasiDelay % 60,'00'),' Menit)')" +
                        " else sp.Nama " +
                        "end as StatusPenerbangan" +
                        ",case " +
                        " when pjp.StatusPenerbanganID = 1 then '-' " +
                        " else concat(pjp.WaktuPerubahanTerjadi,' ') " +
                        " end AS TerakhirDiUbah" +
                        " from PerubahanStatusJadwalPenerbangan as pjp " +
                        "join JadwalPenerbangan as jp on pjp.JadwalPenerbanganID = jp.ID" +
                        " join Maskapai as mk on jp.MaskapaiID = mk.ID " +
                        "join Bandara as bk on jp.BandaraKeberangkatanID = bk.ID " +
                        "join Bandara as bt on jp.BandaraTujuanID = bt.ID " +
                        "join StatusPenerbangan as sp on pjp.StatusPenerbanganID = sp.ID";
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
                    sqlDataAdapter.SelectCommand = sqlc;
                    DataTable dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);
                    if (dataGridView_statusPenerbangan.ColumnCount > 0)
                    {
                        dataGridView_statusPenerbangan.Columns.Clear();
                        
                    }
                    dataGridView_statusPenerbangan.DataSource = dataTable;
                    dataGridView_statusPenerbangan.Columns["ID"].Visible = false;
                    dataGridView_statusPenerbangan.Columns["pdd"].Visible = false;
                    dataGridView_statusPenerbangan.AllowUserToAddRows = false;
                    for (int i = 0; i < dataGridView_statusPenerbangan.ColumnCount; i++)
                    {
                        dataGridView_statusPenerbangan.Columns[i].ReadOnly = true;
                    }
                    DataGridViewButtonColumn ubah = new DataGridViewButtonColumn();
                    DataGridViewButtonColumn hapus = new DataGridViewButtonColumn();
                    ubah.Name = "ubahData";
                    ubah.Text = "Ubah";
                    hapus.Name = "hapusData";
                    hapus.Text = "hapus";
                    ubah.UseColumnTextForButtonValue = true;
                    hapus.UseColumnTextForButtonValue = true;
                    for (int i = 0; i < dataGridView_statusPenerbangan.ColumnCount; i++)
                    {
                        dataGridView_statusPenerbangan.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                    }
                    dataGridView_statusPenerbangan.Columns.Insert(dataGridView_statusPenerbangan.ColumnCount, ubah);
                    //dataGridView_statusPenerbangan.Columns.Insert(dataGridView_statusPenerbangan.ColumnCount, hapus);
                }
                finally
                {
                    sqls.Close();
                }
            }

        }

        private void loadcombostatus()
        {
            using (SqlConnection sqls = conn.koneksi())
            {
                try
                {
                    sqls.Open();
                    SqlCommand sqlc = sqls.CreateCommand();
                    sqlc.CommandType = CommandType.Text;
                    sqlc.CommandText = "select * from StatusPenerbangan";
                    SqlDataAdapter adapter = new SqlDataAdapter(sqlc);
                    DataSet dataSet = new DataSet();
                    adapter.Fill(dataSet,"sp");

                    comboBox_status.DataSource = dataSet.Tables["sp"];
                    comboBox_status.ValueMember = "ID";
                    comboBox_status.DisplayMember = "Nama";
                } finally { sqls.Close(); }
            }
        }

        private void UbahStatusPenerbangan_Load(object sender, EventArgs e)
        {
            loadtable();
            loadcombostatus();
            panel_status.Visible = false;
            panel_delay.Visible = false;
        }

        private void comboBox_status_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_status.SelectedValue.ToString() == "3" || comboBox_status.SelectedValue.ToString() == "2") {
                panel_delay.Visible = true;
                maskedTextBox_pdd.Text = string.Format("{0:00} Jam {1:00} Menit", int.Parse(row.Cells["pdd"].Value.ToString()) / 60, int.Parse(row.Cells["pdd"].Value.ToString()) % 60);
            } else panel_delay.Visible = false;
        }

        private void dataGridView_statusPenerbangan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && dataGridView_statusPenerbangan.Columns[e.ColumnIndex].Name == "ubahData")
            {
                panel_status.Visible = true;
                row = dataGridView_statusPenerbangan.Rows[e.RowIndex];
                string status = row.Cells["StatusPenerbangan"].Value.ToString();
                string[] strings = status.Split(' ');
                status = strings[0];
                Console.WriteLine(status);
                comboBox_status.Text = status;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox_status.SelectedValue = 1;
            maskedTextBox_pdd.Clear();
            panel_status.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using(SqlConnection sqls = conn.koneksi())
            {
                try
                {
                    sqls.Open(); 
                    SqlCommand sqlc = sqls.CreateCommand();
                    sqlc.CommandType = CommandType.Text;
                    sqlc.CommandText = "update PerubahanStatusJadwalPenerbangan set StatusPenerbanganID = @sp,WaktuPerubahanTerjadi = @wpt,PerkiraanDurasiDelay = @pdd where ID = @id";
                    sqlc.Parameters.AddWithValue("@id", row.Cells["ID"].Value.ToString());
                    sqlc.Parameters.AddWithValue("@wpt", DateTime.Now.ToString());
                    string[] wpt = maskedTextBox_pdd.Text.Split(' ');
                    int count = (int.Parse(wpt[0]) * 60) + int.Parse(wpt[2]);
                    sqlc.Parameters.AddWithValue("@pdd",count);
                    sqlc.Parameters.AddWithValue("@sp", comboBox_status.SelectedValue);

                    int result = sqlc.ExecuteNonQuery();
                    if (result >= 0)
                    {
                        MessageBox.Show(string.Format("{0} update data", (result >= 0) ? "Successfully" : "Failed to"), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                finally
                {
                    sqls.Close();
                    comboBox_status.SelectedValue = 1;
                    maskedTextBox_pdd.Clear();
                    panel_status.Visible = false;
                    loadtable();
                }
            }
        }
    }
}
