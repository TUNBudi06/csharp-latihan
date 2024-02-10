namespace bromo
{
    partial class MasterMaskapai
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
            this.bromoAirlines = new bromo.BromoAirlines();
            this.label_maskapai = new System.Windows.Forms.Label();
            this.label_maskapai_title = new System.Windows.Forms.Label();
            this.maskapai = new System.Windows.Forms.DataGridView();
            this.label_nama = new System.Windows.Forms.Label();
            this.label_perusahaan = new System.Windows.Forms.Label();
            this.label_kru = new System.Windows.Forms.Label();
            this.label_deskripsi = new System.Windows.Forms.Label();
            this.textBox_nama = new System.Windows.Forms.TextBox();
            this.textBox_perusahaan = new System.Windows.Forms.TextBox();
            this.richTextBox_deskripsi = new System.Windows.Forms.RichTextBox();
            this.numericUpDown_kru = new System.Windows.Forms.NumericUpDown();
            this.button_batal = new System.Windows.Forms.Button();
            this.button_simpan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bromoAirlines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maskapai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_kru)).BeginInit();
            this.SuspendLayout();
            // 
            // bromoAirlines
            // 
            this.bromoAirlines.DataSetName = "BromoAirlines";
            this.bromoAirlines.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label_maskapai
            // 
            this.label_maskapai.AutoSize = true;
            this.label_maskapai.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_maskapai.Location = new System.Drawing.Point(12, 23);
            this.label_maskapai.Name = "label_maskapai";
            this.label_maskapai.Size = new System.Drawing.Size(210, 29);
            this.label_maskapai.TabIndex = 0;
            this.label_maskapai.Text = "Master Maskapai";
            // 
            // label_maskapai_title
            // 
            this.label_maskapai_title.AutoSize = true;
            this.label_maskapai_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_maskapai_title.Location = new System.Drawing.Point(14, 62);
            this.label_maskapai_title.Name = "label_maskapai_title";
            this.label_maskapai_title.Size = new System.Drawing.Size(329, 17);
            this.label_maskapai_title.TabIndex = 1;
            this.label_maskapai_title.Text = "Semua maskapai yang terdaftar akan muncul disini";
            // 
            // maskapai
            // 
            this.maskapai.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.maskapai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.maskapai.Location = new System.Drawing.Point(16, 101);
            this.maskapai.Name = "maskapai";
            this.maskapai.Size = new System.Drawing.Size(805, 255);
            this.maskapai.TabIndex = 2;
            this.maskapai.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.maskapai_CellContentClick);
            // 
            // label_nama
            // 
            this.label_nama.AutoSize = true;
            this.label_nama.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nama.Location = new System.Drawing.Point(14, 381);
            this.label_nama.Name = "label_nama";
            this.label_nama.Size = new System.Drawing.Size(45, 18);
            this.label_nama.TabIndex = 3;
            this.label_nama.Text = "nama";
            // 
            // label_perusahaan
            // 
            this.label_perusahaan.AutoSize = true;
            this.label_perusahaan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_perusahaan.Location = new System.Drawing.Point(14, 415);
            this.label_perusahaan.Name = "label_perusahaan";
            this.label_perusahaan.Size = new System.Drawing.Size(87, 18);
            this.label_perusahaan.TabIndex = 4;
            this.label_perusahaan.Text = "Perusahaan";
            // 
            // label_kru
            // 
            this.label_kru.AutoSize = true;
            this.label_kru.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_kru.Location = new System.Drawing.Point(14, 453);
            this.label_kru.Name = "label_kru";
            this.label_kru.Size = new System.Drawing.Size(81, 18);
            this.label_kru.TabIndex = 5;
            this.label_kru.Text = "Jumlah kru";
            // 
            // label_deskripsi
            // 
            this.label_deskripsi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_deskripsi.AutoSize = true;
            this.label_deskripsi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_deskripsi.Location = new System.Drawing.Point(388, 380);
            this.label_deskripsi.Name = "label_deskripsi";
            this.label_deskripsi.Size = new System.Drawing.Size(67, 18);
            this.label_deskripsi.TabIndex = 6;
            this.label_deskripsi.Text = "deskripsi";
            // 
            // textBox_nama
            // 
            this.textBox_nama.Location = new System.Drawing.Point(121, 382);
            this.textBox_nama.Name = "textBox_nama";
            this.textBox_nama.Size = new System.Drawing.Size(213, 20);
            this.textBox_nama.TabIndex = 7;
            // 
            // textBox_perusahaan
            // 
            this.textBox_perusahaan.Location = new System.Drawing.Point(121, 416);
            this.textBox_perusahaan.Name = "textBox_perusahaan";
            this.textBox_perusahaan.Size = new System.Drawing.Size(213, 20);
            this.textBox_perusahaan.TabIndex = 8;
            // 
            // richTextBox_deskripsi
            // 
            this.richTextBox_deskripsi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox_deskripsi.Location = new System.Drawing.Point(461, 380);
            this.richTextBox_deskripsi.Name = "richTextBox_deskripsi";
            this.richTextBox_deskripsi.Size = new System.Drawing.Size(360, 90);
            this.richTextBox_deskripsi.TabIndex = 9;
            this.richTextBox_deskripsi.Text = "";
            // 
            // numericUpDown_kru
            // 
            this.numericUpDown_kru.Location = new System.Drawing.Point(121, 450);
            this.numericUpDown_kru.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_kru.Name = "numericUpDown_kru";
            this.numericUpDown_kru.Size = new System.Drawing.Size(211, 20);
            this.numericUpDown_kru.TabIndex = 10;
            this.numericUpDown_kru.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button_batal
            // 
            this.button_batal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_batal.CausesValidation = false;
            this.button_batal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_batal.Location = new System.Drawing.Point(623, 502);
            this.button_batal.Name = "button_batal";
            this.button_batal.Size = new System.Drawing.Size(87, 29);
            this.button_batal.TabIndex = 11;
            this.button_batal.Text = "Batal";
            this.button_batal.UseVisualStyleBackColor = true;
            this.button_batal.Click += new System.EventHandler(this.button_batal_Click);
            // 
            // button_simpan
            // 
            this.button_simpan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_simpan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_simpan.Location = new System.Drawing.Point(716, 502);
            this.button_simpan.Name = "button_simpan";
            this.button_simpan.Size = new System.Drawing.Size(87, 29);
            this.button_simpan.TabIndex = 12;
            this.button_simpan.Text = "Simpan";
            this.button_simpan.UseVisualStyleBackColor = true;
            // 
            // MasterMaskapai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 560);
            this.Controls.Add(this.button_simpan);
            this.Controls.Add(this.button_batal);
            this.Controls.Add(this.numericUpDown_kru);
            this.Controls.Add(this.richTextBox_deskripsi);
            this.Controls.Add(this.textBox_perusahaan);
            this.Controls.Add(this.textBox_nama);
            this.Controls.Add(this.label_deskripsi);
            this.Controls.Add(this.label_kru);
            this.Controls.Add(this.label_perusahaan);
            this.Controls.Add(this.label_nama);
            this.Controls.Add(this.maskapai);
            this.Controls.Add(this.label_maskapai_title);
            this.Controls.Add(this.label_maskapai);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MasterMaskapai";
            this.Text = "Form";
            this.Load += new System.EventHandler(this.MasterMaskapai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bromoAirlines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maskapai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_kru)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private BromoAirlines bromoAirlines;
        private System.Windows.Forms.Label label_maskapai;
        private System.Windows.Forms.Label label_maskapai_title;
        private System.Windows.Forms.DataGridView maskapai;
        private System.Windows.Forms.Label label_nama;
        private System.Windows.Forms.Label label_perusahaan;
        private System.Windows.Forms.Label label_kru;
        private System.Windows.Forms.Label label_deskripsi;
        private System.Windows.Forms.TextBox textBox_nama;
        private System.Windows.Forms.TextBox textBox_perusahaan;
        private System.Windows.Forms.RichTextBox richTextBox_deskripsi;
        private System.Windows.Forms.NumericUpDown numericUpDown_kru;
        private System.Windows.Forms.Button button_batal;
        private System.Windows.Forms.Button button_simpan;
    }
}