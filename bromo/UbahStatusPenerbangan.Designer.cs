namespace bromo
{
    partial class UbahStatusPenerbangan
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
            this.dataGridView_statusPenerbangan = new System.Windows.Forms.DataGridView();
            this.comboBox_status = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_status = new System.Windows.Forms.Label();
            this.maskedTextBox_pdd = new System.Windows.Forms.MaskedTextBox();
            this.panel_delay = new System.Windows.Forms.Panel();
            this.panel_status = new System.Windows.Forms.Panel();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_statusPenerbangan)).BeginInit();
            this.panel_delay.SuspendLayout();
            this.panel_status.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_headline
            // 
            this.label_headline.AutoSize = true;
            this.label_headline.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_headline.Location = new System.Drawing.Point(22, 25);
            this.label_headline.Name = "label_headline";
            this.label_headline.Size = new System.Drawing.Size(372, 32);
            this.label_headline.TabIndex = 0;
            this.label_headline.Text = "Ubah Status Penerbangan";
            // 
            // label_body
            // 
            this.label_body.AutoSize = true;
            this.label_body.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_body.Location = new System.Drawing.Point(35, 66);
            this.label_body.Name = "label_body";
            this.label_body.Size = new System.Drawing.Size(360, 18);
            this.label_body.TabIndex = 1;
            this.label_body.Text = "Anda bisa mengubah status jadwal penerbangan disini";
            // 
            // dataGridView_statusPenerbangan
            // 
            this.dataGridView_statusPenerbangan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_statusPenerbangan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_statusPenerbangan.Location = new System.Drawing.Point(12, 87);
            this.dataGridView_statusPenerbangan.Name = "dataGridView_statusPenerbangan";
            this.dataGridView_statusPenerbangan.Size = new System.Drawing.Size(787, 361);
            this.dataGridView_statusPenerbangan.TabIndex = 2;
            this.dataGridView_statusPenerbangan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_statusPenerbangan_CellContentClick);
            // 
            // comboBox_status
            // 
            this.comboBox_status.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBox_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_status.FormattingEnabled = true;
            this.comboBox_status.Location = new System.Drawing.Point(58, 4);
            this.comboBox_status.Name = "comboBox_status";
            this.comboBox_status.Size = new System.Drawing.Size(160, 24);
            this.comboBox_status.TabIndex = 3;
            this.comboBox_status.SelectedIndexChanged += new System.EventHandler(this.comboBox_status_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Status";
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_status.Location = new System.Drawing.Point(3, 4);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(159, 18);
            this.label_status.TabIndex = 5;
            this.label_status.Text = "Perkiraan Durasi Delay";
            // 
            // maskedTextBox_pdd
            // 
            this.maskedTextBox_pdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox_pdd.Location = new System.Drawing.Point(174, 3);
            this.maskedTextBox_pdd.Mask = "00 J\\am 00 Menit";
            this.maskedTextBox_pdd.Name = "maskedTextBox_pdd";
            this.maskedTextBox_pdd.Size = new System.Drawing.Size(234, 23);
            this.maskedTextBox_pdd.TabIndex = 6;
            // 
            // panel_delay
            // 
            this.panel_delay.Controls.Add(this.maskedTextBox_pdd);
            this.panel_delay.Controls.Add(this.label_status);
            this.panel_delay.Location = new System.Drawing.Point(376, 3);
            this.panel_delay.Name = "panel_delay";
            this.panel_delay.Size = new System.Drawing.Size(411, 31);
            this.panel_delay.TabIndex = 7;
            // 
            // panel_status
            // 
            this.panel_status.Controls.Add(this.button1);
            this.panel_status.Controls.Add(this.button_cancel);
            this.panel_status.Controls.Add(this.label1);
            this.panel_status.Controls.Add(this.panel_delay);
            this.panel_status.Controls.Add(this.comboBox_status);
            this.panel_status.Location = new System.Drawing.Point(12, 458);
            this.panel_status.Name = "panel_status";
            this.panel_status.Size = new System.Drawing.Size(787, 90);
            this.panel_status.TabIndex = 8;
            // 
            // button_cancel
            // 
            this.button_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cancel.Location = new System.Drawing.Point(608, 51);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(85, 36);
            this.button_cancel.TabIndex = 9;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(699, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 36);
            this.button1.TabIndex = 10;
            this.button1.Text = "Simpan";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UbahStatusPenerbangan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 560);
            this.Controls.Add(this.panel_status);
            this.Controls.Add(this.dataGridView_statusPenerbangan);
            this.Controls.Add(this.label_body);
            this.Controls.Add(this.label_headline);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UbahStatusPenerbangan";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.UbahStatusPenerbangan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_statusPenerbangan)).EndInit();
            this.panel_delay.ResumeLayout(false);
            this.panel_delay.PerformLayout();
            this.panel_status.ResumeLayout(false);
            this.panel_status.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_headline;
        private System.Windows.Forms.Label label_body;
        private System.Windows.Forms.DataGridView dataGridView_statusPenerbangan;
        private System.Windows.Forms.ComboBox comboBox_status;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_pdd;
        private System.Windows.Forms.Panel panel_delay;
        private System.Windows.Forms.Panel panel_status;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_cancel;
    }
}