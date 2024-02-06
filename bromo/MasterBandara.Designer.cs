namespace bromo
{
    partial class MasterBandara
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
            this.components = new System.ComponentModel.Container();
            this.label_master = new System.Windows.Forms.Label();
            this.label_informasi = new System.Windows.Forms.Label();
            this.BandaraGV = new System.Windows.Forms.DataGridView();
            this.bandaraTableAdapter = new bromo.BromoAirlinesTableAdapters.BandaraTableAdapter();
            this.label_nama = new System.Windows.Forms.Label();
            this.label_kodeIATA = new System.Windows.Forms.Label();
            this.label_Kota = new System.Windows.Forms.Label();
            this.label_negara = new System.Windows.Forms.Label();
            this.textBox_nama = new System.Windows.Forms.TextBox();
            this.textBox_kodeIATA = new System.Windows.Forms.TextBox();
            this.textBox_kota = new System.Windows.Forms.TextBox();
            this.label_terminal = new System.Windows.Forms.Label();
            this.label_alamat = new System.Windows.Forms.Label();
            this.richTextBox_alamat = new System.Windows.Forms.RichTextBox();
            this.button_simpan = new System.Windows.Forms.Button();
            this.button_batal = new System.Windows.Forms.Button();
            this.numericUpDown_terminal = new System.Windows.Forms.NumericUpDown();
            this.comboBox_Negara = new System.Windows.Forms.ComboBox();
            this.bromoAirlines = new bromo.BromoAirlines();
            this.negaraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.negaraTableAdapter = new bromo.BromoAirlinesTableAdapters.NegaraTableAdapter();
            this.bandaraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.BandaraGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_terminal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bromoAirlines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.negaraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandaraBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label_master
            // 
            this.label_master.AutoSize = true;
            this.label_master.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_master.Location = new System.Drawing.Point(12, 19);
            this.label_master.Name = "label_master";
            this.label_master.Size = new System.Drawing.Size(259, 37);
            this.label_master.TabIndex = 0;
            this.label_master.Text = "Master Bandara";
            // 
            // label_informasi
            // 
            this.label_informasi.AutoSize = true;
            this.label_informasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_informasi.Location = new System.Drawing.Point(16, 65);
            this.label_informasi.Name = "label_informasi";
            this.label_informasi.Size = new System.Drawing.Size(301, 16);
            this.label_informasi.TabIndex = 1;
            this.label_informasi.Text = "Semua bandara yang terdaftar akan muncul disini";
            // 
            // BandaraGV
            // 
            this.BandaraGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BandaraGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BandaraGV.Location = new System.Drawing.Point(12, 94);
            this.BandaraGV.Name = "BandaraGV";
            this.BandaraGV.Size = new System.Drawing.Size(812, 196);
            this.BandaraGV.TabIndex = 2;
            this.BandaraGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BandaraGV_CellContentClick);
            // 
            // bandaraTableAdapter
            // 
            this.bandaraTableAdapter.ClearBeforeFill = true;
            // 
            // label_nama
            // 
            this.label_nama.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_nama.AutoSize = true;
            this.label_nama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nama.Location = new System.Drawing.Point(8, 330);
            this.label_nama.Name = "label_nama";
            this.label_nama.Size = new System.Drawing.Size(55, 20);
            this.label_nama.TabIndex = 3;
            this.label_nama.Text = "Nama:";
            this.label_nama.Click += new System.EventHandler(this.label_nama_Click);
            // 
            // label_kodeIATA
            // 
            this.label_kodeIATA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_kodeIATA.AutoSize = true;
            this.label_kodeIATA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_kodeIATA.Location = new System.Drawing.Point(8, 361);
            this.label_kodeIATA.Name = "label_kodeIATA";
            this.label_kodeIATA.Size = new System.Drawing.Size(90, 20);
            this.label_kodeIATA.TabIndex = 4;
            this.label_kodeIATA.Text = "Kode IATA:";
            // 
            // label_Kota
            // 
            this.label_Kota.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_Kota.AutoSize = true;
            this.label_Kota.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Kota.Location = new System.Drawing.Point(9, 397);
            this.label_Kota.Name = "label_Kota";
            this.label_Kota.Size = new System.Drawing.Size(50, 20);
            this.label_Kota.TabIndex = 5;
            this.label_Kota.Text = "Kota: ";
            // 
            // label_negara
            // 
            this.label_negara.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_negara.AutoSize = true;
            this.label_negara.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_negara.Location = new System.Drawing.Point(10, 434);
            this.label_negara.Name = "label_negara";
            this.label_negara.Size = new System.Drawing.Size(65, 20);
            this.label_negara.TabIndex = 6;
            this.label_negara.Text = "Negara:";
            // 
            // textBox_nama
            // 
            this.textBox_nama.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_nama.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_nama.Location = new System.Drawing.Point(131, 328);
            this.textBox_nama.Name = "textBox_nama";
            this.textBox_nama.Size = new System.Drawing.Size(216, 22);
            this.textBox_nama.TabIndex = 7;
            // 
            // textBox_kodeIATA
            // 
            this.textBox_kodeIATA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_kodeIATA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox_kodeIATA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_kodeIATA.Location = new System.Drawing.Point(131, 361);
            this.textBox_kodeIATA.Name = "textBox_kodeIATA";
            this.textBox_kodeIATA.Size = new System.Drawing.Size(216, 22);
            this.textBox_kodeIATA.TabIndex = 8;
            this.textBox_kodeIATA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_kodeIATA_KeyPress);
            // 
            // textBox_kota
            // 
            this.textBox_kota.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_kota.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_kota.Location = new System.Drawing.Point(131, 395);
            this.textBox_kota.Name = "textBox_kota";
            this.textBox_kota.Size = new System.Drawing.Size(216, 22);
            this.textBox_kota.TabIndex = 9;
            // 
            // label_terminal
            // 
            this.label_terminal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_terminal.AutoSize = true;
            this.label_terminal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_terminal.Location = new System.Drawing.Point(415, 330);
            this.label_terminal.Name = "label_terminal";
            this.label_terminal.Size = new System.Drawing.Size(128, 20);
            this.label_terminal.TabIndex = 11;
            this.label_terminal.Text = "Jumlah Terminal:";
            // 
            // label_alamat
            // 
            this.label_alamat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_alamat.AutoSize = true;
            this.label_alamat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_alamat.Location = new System.Drawing.Point(415, 361);
            this.label_alamat.Name = "label_alamat";
            this.label_alamat.Size = new System.Drawing.Size(63, 20);
            this.label_alamat.TabIndex = 12;
            this.label_alamat.Text = "Alamat:";
            // 
            // richTextBox_alamat
            // 
            this.richTextBox_alamat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox_alamat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_alamat.Location = new System.Drawing.Point(484, 361);
            this.richTextBox_alamat.Name = "richTextBox_alamat";
            this.richTextBox_alamat.Size = new System.Drawing.Size(298, 85);
            this.richTextBox_alamat.TabIndex = 14;
            this.richTextBox_alamat.Text = "";
            // 
            // button_simpan
            // 
            this.button_simpan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_simpan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_simpan.Location = new System.Drawing.Point(558, 500);
            this.button_simpan.Name = "button_simpan";
            this.button_simpan.Size = new System.Drawing.Size(109, 33);
            this.button_simpan.TabIndex = 15;
            this.button_simpan.Text = "Simpan";
            this.button_simpan.UseVisualStyleBackColor = true;
            this.button_simpan.Click += new System.EventHandler(this.button_simpan_Click);
            // 
            // button_batal
            // 
            this.button_batal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_batal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_batal.Location = new System.Drawing.Point(673, 500);
            this.button_batal.Name = "button_batal";
            this.button_batal.Size = new System.Drawing.Size(109, 33);
            this.button_batal.TabIndex = 16;
            this.button_batal.Text = "Batal";
            this.button_batal.UseVisualStyleBackColor = true;
            this.button_batal.Click += new System.EventHandler(this.button_batal_Click);
            // 
            // numericUpDown_terminal
            // 
            this.numericUpDown_terminal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown_terminal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_terminal.Location = new System.Drawing.Point(549, 328);
            this.numericUpDown_terminal.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_terminal.Name = "numericUpDown_terminal";
            this.numericUpDown_terminal.Size = new System.Drawing.Size(240, 22);
            this.numericUpDown_terminal.TabIndex = 17;
            this.numericUpDown_terminal.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // comboBox_Negara
            // 
            this.comboBox_Negara.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBox_Negara.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox_Negara.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.comboBox_Negara.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bandaraBindingSource, "NegaraID", true));
            this.comboBox_Negara.DataSource = this.negaraBindingSource;
            this.comboBox_Negara.DisplayMember = "Nama";
            this.comboBox_Negara.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Negara.FormattingEnabled = true;
            this.comboBox_Negara.Location = new System.Drawing.Point(131, 434);
            this.comboBox_Negara.Name = "comboBox_Negara";
            this.comboBox_Negara.Size = new System.Drawing.Size(216, 24);
            this.comboBox_Negara.TabIndex = 18;
            this.comboBox_Negara.ValueMember = "ID";
            // 
            // bromoAirlines
            // 
            this.bromoAirlines.DataSetName = "BromoAirlines";
            this.bromoAirlines.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // negaraBindingSource
            // 
            this.negaraBindingSource.DataMember = "Negara";
            this.negaraBindingSource.DataSource = this.bromoAirlines;
            // 
            // negaraTableAdapter
            // 
            this.negaraTableAdapter.ClearBeforeFill = true;
            // 
            // bandaraBindingSource
            // 
            this.bandaraBindingSource.DataMember = "Bandara";
            this.bandaraBindingSource.DataSource = this.bromoAirlines;
            // 
            // MasterBandara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 560);
            this.Controls.Add(this.comboBox_Negara);
            this.Controls.Add(this.numericUpDown_terminal);
            this.Controls.Add(this.button_batal);
            this.Controls.Add(this.button_simpan);
            this.Controls.Add(this.richTextBox_alamat);
            this.Controls.Add(this.label_alamat);
            this.Controls.Add(this.label_terminal);
            this.Controls.Add(this.textBox_kota);
            this.Controls.Add(this.textBox_kodeIATA);
            this.Controls.Add(this.textBox_nama);
            this.Controls.Add(this.label_negara);
            this.Controls.Add(this.label_Kota);
            this.Controls.Add(this.label_kodeIATA);
            this.Controls.Add(this.label_nama);
            this.Controls.Add(this.BandaraGV);
            this.Controls.Add(this.label_informasi);
            this.Controls.Add(this.label_master);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MasterBandara";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MasterBandara_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BandaraGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_terminal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bromoAirlines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.negaraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandaraBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_master;
        private System.Windows.Forms.Label label_informasi;
        private System.Windows.Forms.DataGridView BandaraGV;
        private BromoAirlinesTableAdapters.BandaraTableAdapter bandaraTableAdapter;
        private System.Windows.Forms.Label label_nama;
        private System.Windows.Forms.Label label_kodeIATA;
        private System.Windows.Forms.Label label_Kota;
        private System.Windows.Forms.Label label_negara;
        private System.Windows.Forms.TextBox textBox_nama;
        private System.Windows.Forms.TextBox textBox_kodeIATA;
        private System.Windows.Forms.TextBox textBox_kota;
        private System.Windows.Forms.Label label_terminal;
        private System.Windows.Forms.Label label_alamat;
        private System.Windows.Forms.RichTextBox richTextBox_alamat;
        private System.Windows.Forms.Button button_simpan;
        private System.Windows.Forms.Button button_batal;
        private System.Windows.Forms.NumericUpDown numericUpDown_terminal;
        private System.Windows.Forms.ComboBox comboBox_Negara;
        private BromoAirlines bromoAirlines;
        private System.Windows.Forms.BindingSource negaraBindingSource;
        private BromoAirlinesTableAdapters.NegaraTableAdapter negaraTableAdapter;
        private System.Windows.Forms.BindingSource bandaraBindingSource;
    }
}