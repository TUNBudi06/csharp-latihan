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
                            DataSet dsBandara = new DataSet();
                            sdaa.Fill(dsBandara, "Bandara");

                            if (dsBandara.Tables["Bandara"].Rows.Count > 0)
                            {
                                combo_dari.DataSource = dsBandara.Tables["Bandara"];
                                combo_dari.DisplayMember = "Nama";
                                combo_dari.ValueMember = "ID";
                                combo_dari.SelectedValue = 68;

                                combo_ke.DataSource = dsBandara.Tables["Bandara"];
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

        public static void loadTable()
        {

        }

        private void MasterJadwalPenerbangan_Load(object sender, EventArgs e)
        {
            loadDataBinding();
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Tanggal_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
