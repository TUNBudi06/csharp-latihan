﻿namespace bromo
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
            ((System.ComponentModel.ISupportInitialize)(this.bromoAirlines)).BeginInit();
            this.SuspendLayout();
            // 
            // bromoAirlines
            // 
            this.bromoAirlines.DataSetName = "BromoAirlines";
            this.bromoAirlines.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // MasterMaskapai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 560);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MasterMaskapai";
            this.Text = "Form";
            ((System.ComponentModel.ISupportInitialize)(this.bromoAirlines)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private BromoAirlines bromoAirlines;
    }
}