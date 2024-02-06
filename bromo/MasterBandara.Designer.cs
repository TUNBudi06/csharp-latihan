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
            this.bandaraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bromoAirlinesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bromoAirlines = new bromo.BromoAirlines();
            this.bromoAirlinesDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bromoAirlinesDataSet = new bromo.BromoAirlinesDataSet();
            this.bromoAirlinesDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bandaraTableAdapter = new bromo.BromoAirlinesTableAdapters.BandaraTableAdapter();
            this.label_nama = new System.Windows.Forms.Label();
            this.label_kodeIATA = new System.Windows.Forms.Label();
            this.label_Kota = new System.Windows.Forms.Label();
            this.label_negara = new System.Windows.Forms.Label();
            this.textBox_nama = new System.Windows.Forms.TextBox();
            this.textBox_kodeIATA = new System.Windows.Forms.TextBox();
            this.textBox_kota = new System.Windows.Forms.TextBox();
            this.comboBox_Negara = new System.Windows.Forms.ComboBox();
            this.negaraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.negaraTableAdapter = new bromo.BromoAirlinesTableAdapters.NegaraTableAdapter();
            this.label_terminal = new System.Windows.Forms.Label();
            this.label_alamat = new System.Windows.Forms.Label();
            this.textBox_terminal = new System.Windows.Forms.TextBox();
            this.richTextBox_alamat = new System.Windows.Forms.RichTextBox();
            this.button_simpan = new System.Windows.Forms.Button();
            this.button_batal = new System.Windows.Forms.Button();
            this.nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodeIATA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.negaraID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jumlahTerminal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alamat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ubah = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Hapus = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.BandaraGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandaraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bromoAirlinesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bromoAirlines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bromoAirlinesDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bromoAirlinesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bromoAirlinesDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.negaraBindingSource)).BeginInit();
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
            this.BandaraGV.AutoGenerateColumns = false;
            this.BandaraGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BandaraGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nama,
            this.kodeIATA,
            this.kota,
            this.negaraID,
            this.jumlahTerminal,
            this.alamat,
            this.ubah,
            this.Hapus});
            this.BandaraGV.DataSource = this.bandaraBindingSource;
            this.BandaraGV.Location = new System.Drawing.Point(12, 94);
            this.BandaraGV.Name = "BandaraGV";
            this.BandaraGV.Size = new System.Drawing.Size(792, 196);
            this.BandaraGV.TabIndex = 2;
            // 
            // bandaraBindingSource
            // 
            this.bandaraBindingSource.DataMember = "Bandara";
            this.bandaraBindingSource.DataSource = this.bromoAirlinesBindingSource;
            // 
            // bromoAirlinesBindingSource
            // 
            this.bromoAirlinesBindingSource.DataSource = this.bromoAirlines;
            this.bromoAirlinesBindingSource.Position = 0;
            // 
            // bromoAirlines
            // 
            this.bromoAirlines.DataSetName = "BromoAirlines";
            this.bromoAirlines.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bromoAirlinesDataSetBindingSource1
            // 
            this.bromoAirlinesDataSetBindingSource1.DataSource = this.bromoAirlinesDataSet;
            this.bromoAirlinesDataSetBindingSource1.Position = 0;
            // 
            // bromoAirlinesDataSet
            // 
            this.bromoAirlinesDataSet.DataSetName = "BromoAirlinesDataSet";
            this.bromoAirlinesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bromoAirlinesDataSetBindingSource
            // 
            this.bromoAirlinesDataSetBindingSource.DataSource = this.bromoAirlinesDataSet;
            this.bromoAirlinesDataSetBindingSource.Position = 0;
            // 
            // bandaraTableAdapter
            // 
            this.bandaraTableAdapter.ClearBeforeFill = true;
            // 
            // label_nama
            // 
            this.label_nama.Anchor = System.Windows.Forms.AnchorStyles.Left;
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
            this.label_kodeIATA.Anchor = System.Windows.Forms.AnchorStyles.Left;
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
            this.label_Kota.Anchor = System.Windows.Forms.AnchorStyles.Left;
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
            this.label_negara.Anchor = System.Windows.Forms.AnchorStyles.Left;
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
            this.textBox_nama.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox_nama.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_nama.Location = new System.Drawing.Point(131, 328);
            this.textBox_nama.Name = "textBox_nama";
            this.textBox_nama.Size = new System.Drawing.Size(216, 22);
            this.textBox_nama.TabIndex = 7;
            // 
            // textBox_kodeIATA
            // 
            this.textBox_kodeIATA.Anchor = System.Windows.Forms.AnchorStyles.Left;
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
            this.textBox_kota.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox_kota.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_kota.Location = new System.Drawing.Point(131, 395);
            this.textBox_kota.Name = "textBox_kota";
            this.textBox_kota.Size = new System.Drawing.Size(216, 22);
            this.textBox_kota.TabIndex = 9;
            // 
            // comboBox_Negara
            // 
            this.comboBox_Negara.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBox_Negara.DataSource = this.negaraBindingSource;
            this.comboBox_Negara.DisplayMember = "Nama";
            this.comboBox_Negara.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Negara.FormattingEnabled = true;
            this.comboBox_Negara.Location = new System.Drawing.Point(131, 430);
            this.comboBox_Negara.Name = "comboBox_Negara";
            this.comboBox_Negara.Size = new System.Drawing.Size(216, 24);
            this.comboBox_Negara.TabIndex = 10;
            // 
            // negaraBindingSource
            // 
            this.negaraBindingSource.DataMember = "Negara";
            this.negaraBindingSource.DataSource = this.bromoAirlinesBindingSource;
            // 
            // negaraTableAdapter
            // 
            this.negaraTableAdapter.ClearBeforeFill = true;
            // 
            // label_terminal
            // 
            this.label_terminal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_terminal.AutoSize = true;
            this.label_terminal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_terminal.Location = new System.Drawing.Point(395, 330);
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
            this.label_alamat.Location = new System.Drawing.Point(395, 361);
            this.label_alamat.Name = "label_alamat";
            this.label_alamat.Size = new System.Drawing.Size(63, 20);
            this.label_alamat.TabIndex = 12;
            this.label_alamat.Text = "Alamat:";
            // 
            // textBox_terminal
            // 
            this.textBox_terminal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_terminal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_terminal.Location = new System.Drawing.Point(529, 330);
            this.textBox_terminal.Name = "textBox_terminal";
            this.textBox_terminal.Size = new System.Drawing.Size(233, 22);
            this.textBox_terminal.TabIndex = 13;
            this.textBox_terminal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_terminal_KeyPress);
            // 
            // richTextBox_alamat
            // 
            this.richTextBox_alamat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox_alamat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_alamat.Location = new System.Drawing.Point(464, 361);
            this.richTextBox_alamat.Name = "richTextBox_alamat";
            this.richTextBox_alamat.Size = new System.Drawing.Size(298, 85);
            this.richTextBox_alamat.TabIndex = 14;
            this.richTextBox_alamat.Text = "";
            // 
            // button_simpan
            // 
            this.button_simpan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_simpan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_simpan.Location = new System.Drawing.Point(538, 500);
            this.button_simpan.Name = "button_simpan";
            this.button_simpan.Size = new System.Drawing.Size(109, 33);
            this.button_simpan.TabIndex = 15;
            this.button_simpan.Text = "Simpan";
            this.button_simpan.UseVisualStyleBackColor = true;
            // 
            // button_batal
            // 
            this.button_batal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_batal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_batal.Location = new System.Drawing.Point(653, 500);
            this.button_batal.Name = "button_batal";
            this.button_batal.Size = new System.Drawing.Size(109, 33);
            this.button_batal.TabIndex = 16;
            this.button_batal.Text = "Batal";
            this.button_batal.UseVisualStyleBackColor = true;
            // 
            // nama
            // 
            this.nama.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nama.DataPropertyName = "Nama";
            this.nama.HeaderText = "Nama";
            this.nama.Name = "nama";
            this.nama.Width = 60;
            // 
            // kodeIATA
            // 
            this.kodeIATA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.kodeIATA.DataPropertyName = "KodeIATA";
            this.kodeIATA.HeaderText = "KodeIATA";
            this.kodeIATA.Name = "kodeIATA";
            this.kodeIATA.Width = 81;
            // 
            // kota
            // 
            this.kota.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.kota.DataPropertyName = "Kota";
            this.kota.HeaderText = "Kota";
            this.kota.Name = "kota";
            this.kota.Width = 54;
            // 
            // negaraID
            // 
            this.negaraID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.negaraID.DataPropertyName = "NegaraID";
            this.negaraID.HeaderText = "NegaraID";
            this.negaraID.Name = "negaraID";
            this.negaraID.Width = 78;
            // 
            // jumlahTerminal
            // 
            this.jumlahTerminal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.jumlahTerminal.DataPropertyName = "JumlahTerminal";
            this.jumlahTerminal.HeaderText = "JumlahTerminal";
            this.jumlahTerminal.Name = "jumlahTerminal";
            this.jumlahTerminal.Width = 105;
            // 
            // alamat
            // 
            this.alamat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.alamat.DataPropertyName = "Alamat";
            this.alamat.HeaderText = "Alamat";
            this.alamat.Name = "alamat";
            this.alamat.Width = 64;
            // 
            // ubah
            // 
            this.ubah.HeaderText = "";
            this.ubah.Name = "ubah";
            this.ubah.Text = "Ubah";
            this.ubah.UseColumnTextForButtonValue = true;
            // 
            // Hapus
            // 
            this.Hapus.HeaderText = "";
            this.Hapus.Name = "Hapus";
            this.Hapus.Text = "Hapus";
            this.Hapus.UseColumnTextForButtonValue = true;
            // 
            // MasterBandara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 560);
            this.Controls.Add(this.button_batal);
            this.Controls.Add(this.button_simpan);
            this.Controls.Add(this.richTextBox_alamat);
            this.Controls.Add(this.textBox_terminal);
            this.Controls.Add(this.label_alamat);
            this.Controls.Add(this.label_terminal);
            this.Controls.Add(this.comboBox_Negara);
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
            ((System.ComponentModel.ISupportInitialize)(this.bandaraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bromoAirlinesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bromoAirlines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bromoAirlinesDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bromoAirlinesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bromoAirlinesDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.negaraBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_master;
        private System.Windows.Forms.Label label_informasi;
        private System.Windows.Forms.DataGridView BandaraGV;
        private System.Windows.Forms.BindingSource bromoAirlinesDataSetBindingSource;
        private BromoAirlinesDataSet bromoAirlinesDataSet;
        private System.Windows.Forms.BindingSource bromoAirlinesDataSetBindingSource1;
        private BromoAirlines bromoAirlines;
        private System.Windows.Forms.BindingSource bromoAirlinesBindingSource;
        private System.Windows.Forms.BindingSource bandaraBindingSource;
        private BromoAirlinesTableAdapters.BandaraTableAdapter bandaraTableAdapter;
        private System.Windows.Forms.Label label_nama;
        private System.Windows.Forms.Label label_kodeIATA;
        private System.Windows.Forms.Label label_Kota;
        private System.Windows.Forms.Label label_negara;
        private System.Windows.Forms.TextBox textBox_nama;
        private System.Windows.Forms.TextBox textBox_kodeIATA;
        private System.Windows.Forms.TextBox textBox_kota;
        private System.Windows.Forms.ComboBox comboBox_Negara;
        private System.Windows.Forms.BindingSource negaraBindingSource;
        private BromoAirlinesTableAdapters.NegaraTableAdapter negaraTableAdapter;
        private System.Windows.Forms.Label label_terminal;
        private System.Windows.Forms.Label label_alamat;
        private System.Windows.Forms.TextBox textBox_terminal;
        private System.Windows.Forms.RichTextBox richTextBox_alamat;
        private System.Windows.Forms.Button button_simpan;
        private System.Windows.Forms.Button button_batal;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodeIATA;
        private System.Windows.Forms.DataGridViewTextBoxColumn kota;
        private System.Windows.Forms.DataGridViewTextBoxColumn negaraID;
        private System.Windows.Forms.DataGridViewTextBoxColumn jumlahTerminal;
        private System.Windows.Forms.DataGridViewTextBoxColumn alamat;
        private System.Windows.Forms.DataGridViewButtonColumn ubah;
        private System.Windows.Forms.DataGridViewButtonColumn Hapus;
    }
}