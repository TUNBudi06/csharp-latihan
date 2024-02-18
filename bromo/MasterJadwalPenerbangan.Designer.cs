namespace bromo
{
    partial class MasterJadwalPenerbangan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_headline = new System.Windows.Forms.Label();
            this.label_body = new System.Windows.Forms.Label();
            this.dataGridView_mjp = new System.Windows.Forms.DataGridView();
            this.label_kPenerbangan = new System.Windows.Forms.Label();
            this.label_dari = new System.Windows.Forms.Label();
            this.label_ke = new System.Windows.Forms.Label();
            this.label_maskapai = new System.Windows.Forms.Label();
            this.label_tanggal = new System.Windows.Forms.Label();
            this.label_WaktuKeberangkatan = new System.Windows.Forms.Label();
            this.label_DurasiPenerbangan = new System.Windows.Forms.Label();
            this.label_HargaPerTiket = new System.Windows.Forms.Label();
            this.masked_kode = new System.Windows.Forms.MaskedTextBox();
            this.combo_ke = new System.Windows.Forms.ComboBox();
            this.combo_dari = new System.Windows.Forms.ComboBox();
            this.combo_maskapai = new System.Windows.Forms.ComboBox();
            this.picker_tanggal = new System.Windows.Forms.DateTimePicker();
            this.masked_waktu = new System.Windows.Forms.MaskedTextBox();
            this.masked_durasi = new System.Windows.Forms.MaskedTextBox();
            this.button_batal = new System.Windows.Forms.Button();
            this.button_simpan = new System.Windows.Forms.Button();
            this.numericUpDown_hargaPerTiket = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_mjp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_hargaPerTiket)).BeginInit();
            this.SuspendLayout();
            // 
            // label_headline
            // 
            this.label_headline.AutoSize = true;
            this.label_headline.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_headline.Location = new System.Drawing.Point(12, 25);
            this.label_headline.Name = "label_headline";
            this.label_headline.Size = new System.Drawing.Size(400, 32);
            this.label_headline.TabIndex = 0;
            this.label_headline.Text = "Master Jadwal Penerbangan";
            // 
            // label_body
            // 
            this.label_body.AutoSize = true;
            this.label_body.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_body.Location = new System.Drawing.Point(15, 57);
            this.label_body.Name = "label_body";
            this.label_body.Size = new System.Drawing.Size(314, 18);
            this.label_body.TabIndex = 1;
            this.label_body.Text = "Semua jadwal penerbangan akan muncul disini";
            // 
            // dataGridView_mjp
            // 
            this.dataGridView_mjp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_mjp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_mjp.Location = new System.Drawing.Point(18, 90);
            this.dataGridView_mjp.Name = "dataGridView_mjp";
            this.dataGridView_mjp.Size = new System.Drawing.Size(775, 214);
            this.dataGridView_mjp.TabIndex = 2;
            this.dataGridView_mjp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_mjp_CellContentClick);
            // 
            // label_kPenerbangan
            // 
            this.label_kPenerbangan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_kPenerbangan.AutoSize = true;
            this.label_kPenerbangan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_kPenerbangan.Location = new System.Drawing.Point(20, 345);
            this.label_kPenerbangan.Name = "label_kPenerbangan";
            this.label_kPenerbangan.Size = new System.Drawing.Size(134, 18);
            this.label_kPenerbangan.TabIndex = 3;
            this.label_kPenerbangan.Text = "Kode Penerbangan";
            // 
            // label_dari
            // 
            this.label_dari.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_dari.AutoSize = true;
            this.label_dari.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_dari.Location = new System.Drawing.Point(20, 379);
            this.label_dari.Name = "label_dari";
            this.label_dari.Size = new System.Drawing.Size(35, 18);
            this.label_dari.TabIndex = 4;
            this.label_dari.Text = "Dari";
            // 
            // label_ke
            // 
            this.label_ke.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_ke.AutoSize = true;
            this.label_ke.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ke.Location = new System.Drawing.Point(20, 410);
            this.label_ke.Name = "label_ke";
            this.label_ke.Size = new System.Drawing.Size(26, 18);
            this.label_ke.TabIndex = 5;
            this.label_ke.Text = "Ke";
            // 
            // label_maskapai
            // 
            this.label_maskapai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_maskapai.AutoSize = true;
            this.label_maskapai.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_maskapai.Location = new System.Drawing.Point(20, 444);
            this.label_maskapai.Name = "label_maskapai";
            this.label_maskapai.Size = new System.Drawing.Size(72, 18);
            this.label_maskapai.TabIndex = 6;
            this.label_maskapai.Text = "Maskapai";
            // 
            // label_tanggal
            // 
            this.label_tanggal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_tanggal.AutoSize = true;
            this.label_tanggal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tanggal.Location = new System.Drawing.Point(419, 345);
            this.label_tanggal.Name = "label_tanggal";
            this.label_tanggal.Size = new System.Drawing.Size(60, 18);
            this.label_tanggal.TabIndex = 7;
            this.label_tanggal.Text = "Tanggal";
            // 
            // label_WaktuKeberangkatan
            // 
            this.label_WaktuKeberangkatan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_WaktuKeberangkatan.AutoSize = true;
            this.label_WaktuKeberangkatan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_WaktuKeberangkatan.Location = new System.Drawing.Point(419, 382);
            this.label_WaktuKeberangkatan.Name = "label_WaktuKeberangkatan";
            this.label_WaktuKeberangkatan.Size = new System.Drawing.Size(154, 18);
            this.label_WaktuKeberangkatan.TabIndex = 8;
            this.label_WaktuKeberangkatan.Text = "Waktu Keberangkatan";
            // 
            // label_DurasiPenerbangan
            // 
            this.label_DurasiPenerbangan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_DurasiPenerbangan.AutoSize = true;
            this.label_DurasiPenerbangan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DurasiPenerbangan.Location = new System.Drawing.Point(419, 414);
            this.label_DurasiPenerbangan.Name = "label_DurasiPenerbangan";
            this.label_DurasiPenerbangan.Size = new System.Drawing.Size(142, 18);
            this.label_DurasiPenerbangan.TabIndex = 9;
            this.label_DurasiPenerbangan.Text = "Durasi Penerbangan";
            // 
            // label_HargaPerTiket
            // 
            this.label_HargaPerTiket.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_HargaPerTiket.AutoSize = true;
            this.label_HargaPerTiket.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_HargaPerTiket.Location = new System.Drawing.Point(419, 448);
            this.label_HargaPerTiket.Name = "label_HargaPerTiket";
            this.label_HargaPerTiket.Size = new System.Drawing.Size(104, 18);
            this.label_HargaPerTiket.TabIndex = 10;
            this.label_HargaPerTiket.Text = "Harga per tiket";
            // 
            // masked_kode
            // 
            this.masked_kode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.masked_kode.Location = new System.Drawing.Point(176, 346);
            this.masked_kode.Mask = "AA-0000";
            this.masked_kode.Name = "masked_kode";
            this.masked_kode.Size = new System.Drawing.Size(183, 20);
            this.masked_kode.TabIndex = 11;
            // 
            // combo_ke
            // 
            this.combo_ke.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.combo_ke.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_ke.FormattingEnabled = true;
            this.combo_ke.Location = new System.Drawing.Point(176, 411);
            this.combo_ke.Name = "combo_ke";
            this.combo_ke.Size = new System.Drawing.Size(183, 21);
            this.combo_ke.TabIndex = 12;
            // 
            // combo_dari
            // 
            this.combo_dari.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.combo_dari.DisplayMember = "ID";
            this.combo_dari.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_dari.FormattingEnabled = true;
            this.combo_dari.Location = new System.Drawing.Point(176, 379);
            this.combo_dari.Name = "combo_dari";
            this.combo_dari.Size = new System.Drawing.Size(183, 21);
            this.combo_dari.TabIndex = 13;
            this.combo_dari.ValueMember = "ID";
            // 
            // combo_maskapai
            // 
            this.combo_maskapai.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.combo_maskapai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_maskapai.FormattingEnabled = true;
            this.combo_maskapai.Location = new System.Drawing.Point(176, 445);
            this.combo_maskapai.Name = "combo_maskapai";
            this.combo_maskapai.Size = new System.Drawing.Size(183, 21);
            this.combo_maskapai.TabIndex = 15;
            // 
            // picker_tanggal
            // 
            this.picker_tanggal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.picker_tanggal.Location = new System.Drawing.Point(593, 346);
            this.picker_tanggal.Name = "picker_tanggal";
            this.picker_tanggal.Size = new System.Drawing.Size(200, 20);
            this.picker_tanggal.TabIndex = 17;
            // 
            // masked_waktu
            // 
            this.masked_waktu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.masked_waktu.Location = new System.Drawing.Point(593, 380);
            this.masked_waktu.Mask = "00:00";
            this.masked_waktu.Name = "masked_waktu";
            this.masked_waktu.Size = new System.Drawing.Size(200, 20);
            this.masked_waktu.TabIndex = 19;
            this.masked_waktu.Text = "0000";
            // 
            // masked_durasi
            // 
            this.masked_durasi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.masked_durasi.Location = new System.Drawing.Point(593, 411);
            this.masked_durasi.Mask = "00 J\\am 00 Menit";
            this.masked_durasi.Name = "masked_durasi";
            this.masked_durasi.Size = new System.Drawing.Size(200, 20);
            this.masked_durasi.TabIndex = 20;
            // 
            // button_batal
            // 
            this.button_batal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_batal.Location = new System.Drawing.Point(593, 493);
            this.button_batal.Name = "button_batal";
            this.button_batal.Size = new System.Drawing.Size(95, 35);
            this.button_batal.TabIndex = 22;
            this.button_batal.Text = "Batal";
            this.button_batal.UseVisualStyleBackColor = true;
            this.button_batal.Click += new System.EventHandler(this.button_batal_Click);
            // 
            // button_simpan
            // 
            this.button_simpan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_simpan.Location = new System.Drawing.Point(698, 493);
            this.button_simpan.Name = "button_simpan";
            this.button_simpan.Size = new System.Drawing.Size(95, 35);
            this.button_simpan.TabIndex = 23;
            this.button_simpan.Text = "Simpan";
            this.button_simpan.UseVisualStyleBackColor = true;
            // 
            // numericUpDown_hargaPerTiket
            // 
            this.numericUpDown_hargaPerTiket.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown_hargaPerTiket.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_hargaPerTiket.Location = new System.Drawing.Point(593, 446);
            this.numericUpDown_hargaPerTiket.Maximum = new decimal(new int[] {
            276447231,
            23283,
            0,
            0});
            this.numericUpDown_hargaPerTiket.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_hargaPerTiket.Name = "numericUpDown_hargaPerTiket";
            this.numericUpDown_hargaPerTiket.Size = new System.Drawing.Size(198, 20);
            this.numericUpDown_hargaPerTiket.TabIndex = 24;
            this.numericUpDown_hargaPerTiket.ThousandsSeparator = true;
            this.numericUpDown_hargaPerTiket.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // MasterJadwalPenerbangan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 560);
            this.Controls.Add(this.numericUpDown_hargaPerTiket);
            this.Controls.Add(this.button_simpan);
            this.Controls.Add(this.button_batal);
            this.Controls.Add(this.masked_durasi);
            this.Controls.Add(this.masked_waktu);
            this.Controls.Add(this.picker_tanggal);
            this.Controls.Add(this.combo_maskapai);
            this.Controls.Add(this.combo_dari);
            this.Controls.Add(this.combo_ke);
            this.Controls.Add(this.masked_kode);
            this.Controls.Add(this.label_HargaPerTiket);
            this.Controls.Add(this.label_DurasiPenerbangan);
            this.Controls.Add(this.label_WaktuKeberangkatan);
            this.Controls.Add(this.label_tanggal);
            this.Controls.Add(this.label_maskapai);
            this.Controls.Add(this.label_ke);
            this.Controls.Add(this.label_dari);
            this.Controls.Add(this.label_kPenerbangan);
            this.Controls.Add(this.dataGridView_mjp);
            this.Controls.Add(this.label_body);
            this.Controls.Add(this.label_headline);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MasterJadwalPenerbangan";
            this.Text = "MasterJadwalPenerbangan";
            this.Load += new System.EventHandler(this.MasterJadwalPenerbangan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_mjp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_hargaPerTiket)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_headline;
        private System.Windows.Forms.Label label_body;
        private System.Windows.Forms.DataGridView dataGridView_mjp;
        private System.Windows.Forms.Label label_kPenerbangan;
        private System.Windows.Forms.Label label_dari;
        private System.Windows.Forms.Label label_ke;
        private System.Windows.Forms.Label label_maskapai;
        private System.Windows.Forms.Label label_tanggal;
        private System.Windows.Forms.Label label_WaktuKeberangkatan;
        private System.Windows.Forms.Label label_DurasiPenerbangan;
        private System.Windows.Forms.Label label_HargaPerTiket;
        private System.Windows.Forms.MaskedTextBox masked_kode;
        private System.Windows.Forms.ComboBox combo_ke;
        private System.Windows.Forms.ComboBox combo_dari;
        private System.Windows.Forms.ComboBox combo_maskapai;
        private System.Windows.Forms.DateTimePicker picker_tanggal;
        private System.Windows.Forms.MaskedTextBox masked_waktu;
        private System.Windows.Forms.MaskedTextBox masked_durasi;
        private System.Windows.Forms.Button button_batal;
        private System.Windows.Forms.Button button_simpan;
        private System.Windows.Forms.NumericUpDown numericUpDown_hargaPerTiket;
    }
}