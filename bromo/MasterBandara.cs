using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
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

        bool updateData = false;
        int getID = 0;

        public void loadtable()
        {

            using (SqlConnection sqls = conn.koneksi())
            {
                try
                {
                    sqls.Open();

                    string query = "SELECT b.ID, b.Nama, b.KodeIATA, b.Kota, n.Nama AS Negara, b.JumlahTerminal as 'Jumlah Terminal', b.Alamat " +
                   "FROM Bandara b " +
                   "JOIN Negara n ON b.NegaraID = n.ID;";

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
                    Console.WriteLine(BandaraGV.ColumnCount);
                    if (BandaraGV.ColumnCount < 8)
                    {
                        DataGridViewButtonColumn Ubah = new DataGridViewButtonColumn();
                        Ubah.Text = "Ubah";
                        Ubah.Name = "ubah";
                        Ubah.UseColumnTextForButtonValue = true;

                        Ubah.Width = 100;
                        DataGridViewButtonColumn Hapus = new DataGridViewButtonColumn();
                        Hapus.Text = "Hapus";
                        Hapus.Name = "hapus";
                        Hapus.Width = 100;
                        Hapus.UseColumnTextForButtonValue = true;
                        BandaraGV.Columns.Insert(7,Ubah);
                        BandaraGV.Columns.Insert(8,Hapus);
                    }
                }
                finally
                {
                    sqls.Close();
                }
            }
        }

        private void MasterBandara_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bromoAirlines.Negara' table. You can move, or remove it, as needed.
            this.negaraTableAdapter.Fill(this.bromoAirlines.Negara);
            loadtable();
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
            if (this.textBox_kodeIATA.Text.Length < 5 || e.KeyChar == (char)(Keys.BrowserBack))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void BandaraGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine(e.ColumnIndex);
            if (e.ColumnIndex >=0 && BandaraGV.Columns[e.ColumnIndex].Name == "ubah")
            {
                updateData = true;

                DataGridViewRow row = BandaraGV.Rows[e.RowIndex];
                this.getID = int.Parse(row.Cells["ID"].Value.ToString());
                this.textBox_nama.Text = row.Cells["nama"].Value.ToString();
                this.textBox_kodeIATA.Text = row.Cells["KodeIATA"].Value.ToString();
                this.textBox_kota.Text = row.Cells["Kota"].Value.ToString();
                this.comboBox_Negara.Text = row.Cells["Negara"].Value.ToString();
                this.numericUpDown_terminal.Value = int.Parse(row.Cells["Jumlah Terminal"].Value.ToString());
                this.richTextBox_alamat.Text = row.Cells["alamat"].Value.ToString();
            }

            if (e.ColumnIndex >= 0 && BandaraGV.Columns[e.ColumnIndex].Name == "hapus")
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

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.bandaraTableAdapter.FillBy(this.bromoAirlines.Bandara);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.negaraTableAdapter.FillBy(this.bromoAirlines.Negara);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button_batal_Click(object sender, EventArgs e)
        {
            updateData = false;
            this.textBox_nama.Clear();
            this.textBox_kodeIATA.Clear();
            this.textBox_kota.Clear();
            this.comboBox_Negara.SelectedValue = 1;
            this.numericUpDown_terminal.Value = 1;
            this.richTextBox_alamat.Clear();
        }

        private void button_simpan_Click(object sender, EventArgs e)
        {
            SqlConnection sqls = conn.koneksi();
            if (updateData == false)
            {
                try
                {
                    sqls.Open();

                    SqlCommand cmd = sqls.CreateCommand();

                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "insert into Bandara(Nama,KodeIATA,Kota,NegaraID,JumlahTerminal,Alamat) values (@nama,@iata,@kota,@nid,@jt,@alamat);";
                    cmd.Parameters.AddWithValue("@curr", this.getID);
                    cmd.Parameters.AddWithValue("@nama", this.textBox_nama.Text);
                    cmd.Parameters.AddWithValue("@iata", this.textBox_kodeIATA.Text);
                    cmd.Parameters.AddWithValue("@kota", this.textBox_kota.Text);
                    cmd.Parameters.AddWithValue("@nid", this.comboBox_Negara.SelectedValue);
                    cmd.Parameters.AddWithValue("@jt", this.numericUpDown_terminal.Value);
                    cmd.Parameters.AddWithValue("@alamat", this.richTextBox_alamat.Text);
                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Succesfully added data","SUCCESS",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        this.textBox_nama.Clear();
                        this.textBox_kodeIATA.Clear();
                        this.textBox_kota.Clear();
                        this.comboBox_Negara.SelectedValue = 1;
                        this.numericUpDown_terminal.Value = 1;
                        this.richTextBox_alamat.Clear();
                    }
                    loadtable();
                }
                finally
                {
                    sqls.Close();
                }
            } else
            {
                try
                {
                    sqls.Open();

                    SqlCommand cmd = sqls.CreateCommand();

                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "UPDATE Bandara SET Nama = @nama, KodeIATA = @iata, " +
                                      "Kota = @kota, NegaraID = @nid, JumlahTerminal = @jt, Alamat = @alamat " +
                                      "WHERE ID = @curr";

                    cmd.Parameters.AddWithValue("@curr", this.getID);
                    cmd.Parameters.AddWithValue("@nama", this.textBox_nama.Text);
                    cmd.Parameters.AddWithValue("@iata", this.textBox_kodeIATA.Text);
                    cmd.Parameters.AddWithValue("@kota", this.textBox_kota.Text);
                    cmd.Parameters.AddWithValue("@nid", this.comboBox_Negara.SelectedValue);
                    cmd.Parameters.AddWithValue("@jt", this.numericUpDown_terminal.Value);
                    cmd.Parameters.AddWithValue("@alamat", this.richTextBox_alamat.Text);

                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Successfully updated data", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        updateData = false; // Reset the update flag
                        this.getID = 0; // Reset the ID
                        this.textBox_nama.Clear();
                        this.textBox_kodeIATA.Clear();
                        this.textBox_kota.Clear();
                        this.comboBox_Negara.SelectedValue = 1;
                        this.numericUpDown_terminal.Value = 1;
                        this.richTextBox_alamat.Clear();
                    }
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
