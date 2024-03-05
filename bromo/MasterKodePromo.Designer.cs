namespace bromo
{
    partial class MasterKodePromo
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
            this.dataGridView_kodepromo = new System.Windows.Forms.DataGridView();
            this.label_kodePromo = new System.Windows.Forms.Label();
            this.textBox_kodePromo = new System.Windows.Forms.TextBox();
            this.label_berlakuSampai = new System.Windows.Forms.Label();
            this.label_persentaseDiskon = new System.Windows.Forms.Label();
            this.label_minimumDiskon = new System.Windows.Forms.Label();
            this.numericUpDown_persentasediskon = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_minimumdiskon = new System.Windows.Forms.NumericUpDown();
            this.dateTimePicker_berlakusampai = new System.Windows.Forms.DateTimePicker();
            this.label_deskripsi = new System.Windows.Forms.Label();
            this.richTextBox_deskripsi = new System.Windows.Forms.RichTextBox();
            this.button_batal = new System.Windows.Forms.Button();
            this.button_simpan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_kodepromo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_persentasediskon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_minimumdiskon)).BeginInit();
            this.SuspendLayout();
            // 
            // label_headline
            // 
            this.label_headline.AutoSize = true;
            this.label_headline.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_headline.Location = new System.Drawing.Point(12, 22);
            this.label_headline.Name = "label_headline";
            this.label_headline.Size = new System.Drawing.Size(281, 32);
            this.label_headline.TabIndex = 0;
            this.label_headline.Text = "Master Kode Promo";
            // 
            // label_body
            // 
            this.label_body.AutoSize = true;
            this.label_body.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_body.Location = new System.Drawing.Point(15, 54);
            this.label_body.Name = "label_body";
            this.label_body.Size = new System.Drawing.Size(271, 18);
            this.label_body.TabIndex = 1;
            this.label_body.Text = "Semua kode promo akan terdaftar disini";
            // 
            // dataGridView_kodepromo
            // 
            this.dataGridView_kodepromo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_kodepromo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_kodepromo.Location = new System.Drawing.Point(12, 75);
            this.dataGridView_kodepromo.Name = "dataGridView_kodepromo";
            this.dataGridView_kodepromo.Size = new System.Drawing.Size(787, 261);
            this.dataGridView_kodepromo.TabIndex = 2;
            this.dataGridView_kodepromo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_kodepromo_CellContentClick);
            // 
            // label_kodePromo
            // 
            this.label_kodePromo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_kodePromo.AutoSize = true;
            this.label_kodePromo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_kodePromo.Location = new System.Drawing.Point(15, 370);
            this.label_kodePromo.Name = "label_kodePromo";
            this.label_kodePromo.Size = new System.Drawing.Size(93, 18);
            this.label_kodePromo.TabIndex = 3;
            this.label_kodePromo.Text = "Kode Promo";
            // 
            // textBox_kodePromo
            // 
            this.textBox_kodePromo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_kodePromo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox_kodePromo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_kodePromo.Location = new System.Drawing.Point(156, 369);
            this.textBox_kodePromo.Name = "textBox_kodePromo";
            this.textBox_kodePromo.Size = new System.Drawing.Size(162, 21);
            this.textBox_kodePromo.TabIndex = 4;
            // 
            // label_berlakuSampai
            // 
            this.label_berlakuSampai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_berlakuSampai.AutoSize = true;
            this.label_berlakuSampai.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_berlakuSampai.Location = new System.Drawing.Point(15, 406);
            this.label_berlakuSampai.Name = "label_berlakuSampai";
            this.label_berlakuSampai.Size = new System.Drawing.Size(110, 18);
            this.label_berlakuSampai.TabIndex = 5;
            this.label_berlakuSampai.Text = "Berlaku sampai";
            // 
            // label_persentaseDiskon
            // 
            this.label_persentaseDiskon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_persentaseDiskon.AutoSize = true;
            this.label_persentaseDiskon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_persentaseDiskon.Location = new System.Drawing.Point(15, 438);
            this.label_persentaseDiskon.Name = "label_persentaseDiskon";
            this.label_persentaseDiskon.Size = new System.Drawing.Size(131, 18);
            this.label_persentaseDiskon.TabIndex = 6;
            this.label_persentaseDiskon.Text = "Persentase diskon";
            // 
            // label_minimumDiskon
            // 
            this.label_minimumDiskon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_minimumDiskon.AutoSize = true;
            this.label_minimumDiskon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_minimumDiskon.Location = new System.Drawing.Point(15, 468);
            this.label_minimumDiskon.Name = "label_minimumDiskon";
            this.label_minimumDiskon.Size = new System.Drawing.Size(117, 18);
            this.label_minimumDiskon.TabIndex = 7;
            this.label_minimumDiskon.Text = "Minimum diskon";
            // 
            // numericUpDown_persentasediskon
            // 
            this.numericUpDown_persentasediskon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numericUpDown_persentasediskon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_persentasediskon.Location = new System.Drawing.Point(156, 435);
            this.numericUpDown_persentasediskon.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.numericUpDown_persentasediskon.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_persentasediskon.Name = "numericUpDown_persentasediskon";
            this.numericUpDown_persentasediskon.Size = new System.Drawing.Size(162, 21);
            this.numericUpDown_persentasediskon.TabIndex = 8;
            this.numericUpDown_persentasediskon.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown_minimumdiskon
            // 
            this.numericUpDown_minimumdiskon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numericUpDown_minimumdiskon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_minimumdiskon.Location = new System.Drawing.Point(156, 468);
            this.numericUpDown_minimumdiskon.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.numericUpDown_minimumdiskon.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_minimumdiskon.Name = "numericUpDown_minimumdiskon";
            this.numericUpDown_minimumdiskon.Size = new System.Drawing.Size(162, 21);
            this.numericUpDown_minimumdiskon.TabIndex = 9;
            this.numericUpDown_minimumdiskon.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dateTimePicker_berlakusampai
            // 
            this.dateTimePicker_berlakusampai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dateTimePicker_berlakusampai.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_berlakusampai.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimePicker_berlakusampai.Location = new System.Drawing.Point(156, 405);
            this.dateTimePicker_berlakusampai.Name = "dateTimePicker_berlakusampai";
            this.dateTimePicker_berlakusampai.Size = new System.Drawing.Size(162, 20);
            this.dateTimePicker_berlakusampai.TabIndex = 10;
            // 
            // label_deskripsi
            // 
            this.label_deskripsi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_deskripsi.AutoSize = true;
            this.label_deskripsi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_deskripsi.Location = new System.Drawing.Point(379, 370);
            this.label_deskripsi.Name = "label_deskripsi";
            this.label_deskripsi.Size = new System.Drawing.Size(70, 18);
            this.label_deskripsi.TabIndex = 11;
            this.label_deskripsi.Text = "Deskripsi";
            // 
            // richTextBox_deskripsi
            // 
            this.richTextBox_deskripsi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox_deskripsi.Location = new System.Drawing.Point(455, 369);
            this.richTextBox_deskripsi.Name = "richTextBox_deskripsi";
            this.richTextBox_deskripsi.Size = new System.Drawing.Size(328, 83);
            this.richTextBox_deskripsi.TabIndex = 12;
            this.richTextBox_deskripsi.Text = "";
            // 
            // button_batal
            // 
            this.button_batal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_batal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_batal.Location = new System.Drawing.Point(575, 493);
            this.button_batal.Name = "button_batal";
            this.button_batal.Size = new System.Drawing.Size(93, 36);
            this.button_batal.TabIndex = 13;
            this.button_batal.Text = "Batal";
            this.button_batal.UseVisualStyleBackColor = true;
            this.button_batal.Click += new System.EventHandler(this.button_batal_Click);
            // 
            // button_simpan
            // 
            this.button_simpan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_simpan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_simpan.Location = new System.Drawing.Point(674, 493);
            this.button_simpan.Name = "button_simpan";
            this.button_simpan.Size = new System.Drawing.Size(93, 36);
            this.button_simpan.TabIndex = 14;
            this.button_simpan.Text = "Simpan";
            this.button_simpan.UseVisualStyleBackColor = true;
            this.button_simpan.Click += new System.EventHandler(this.button_simpan_Click);
            // 
            // MasterKodePromo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 560);
            this.Controls.Add(this.button_simpan);
            this.Controls.Add(this.button_batal);
            this.Controls.Add(this.richTextBox_deskripsi);
            this.Controls.Add(this.label_deskripsi);
            this.Controls.Add(this.dateTimePicker_berlakusampai);
            this.Controls.Add(this.numericUpDown_minimumdiskon);
            this.Controls.Add(this.numericUpDown_persentasediskon);
            this.Controls.Add(this.label_minimumDiskon);
            this.Controls.Add(this.label_persentaseDiskon);
            this.Controls.Add(this.label_berlakuSampai);
            this.Controls.Add(this.textBox_kodePromo);
            this.Controls.Add(this.label_kodePromo);
            this.Controls.Add(this.dataGridView_kodepromo);
            this.Controls.Add(this.label_body);
            this.Controls.Add(this.label_headline);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MasterKodePromo";
            this.Text = "Bromo AirLines - Admin";
            this.Load += new System.EventHandler(this.MasterKodePromo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_kodepromo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_persentasediskon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_minimumdiskon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_headline;
        private System.Windows.Forms.Label label_body;
        private System.Windows.Forms.DataGridView dataGridView_kodepromo;
        private System.Windows.Forms.Label label_kodePromo;
        private System.Windows.Forms.TextBox textBox_kodePromo;
        private System.Windows.Forms.Label label_berlakuSampai;
        private System.Windows.Forms.Label label_persentaseDiskon;
        private System.Windows.Forms.Label label_minimumDiskon;
        private System.Windows.Forms.NumericUpDown numericUpDown_persentasediskon;
        private System.Windows.Forms.NumericUpDown numericUpDown_minimumdiskon;
        private System.Windows.Forms.DateTimePicker dateTimePicker_berlakusampai;
        private System.Windows.Forms.Label label_deskripsi;
        private System.Windows.Forms.RichTextBox richTextBox_deskripsi;
        private System.Windows.Forms.Button button_batal;
        private System.Windows.Forms.Button button_simpan;
    }
}