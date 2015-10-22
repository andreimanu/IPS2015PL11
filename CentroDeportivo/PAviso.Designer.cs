using System.Collections.Generic;

namespace CentroDeportivo
{
    partial class PAviso
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
            this.LbCambio = new System.Windows.Forms.Label();
            this.ListUsuarios = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // LbCambio
            // 
            this.LbCambio.AutoSize = true;
            this.LbCambio.Location = new System.Drawing.Point(187, 31);
            this.LbCambio.Name = "LbCambio";
            this.LbCambio.Size = new System.Drawing.Size(294, 26);
            this.LbCambio.TabIndex = 0;
            this.LbCambio.Text = "Debido a un cambio por parte del organizador se debe avisar\r\na los siguientes soc" +
    "ios de la cancelación de sus reservas:";
            // 
            // ListUsuarios
            // 
            this.ListUsuarios.FormattingEnabled = true;
            this.ListUsuarios.Location = new System.Drawing.Point(50, 112);
            this.ListUsuarios.Name = "ListUsuarios";
            this.ListUsuarios.Size = new System.Drawing.Size(557, 95);
            this.ListUsuarios.TabIndex = 1;
            // 
            // PAviso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 285);
            this.Controls.Add(this.ListUsuarios);
            this.Controls.Add(this.LbCambio);
            this.Name = "PAviso";
            this.Text = "Aviso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbCambio;
        private System.Windows.Forms.ListBox ListUsuarios;
        

        
    }
}