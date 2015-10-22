namespace CentroDeportivo
{
    partial class PNoDisponible
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
            this.LbError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LbError
            // 
            this.LbError.AutoSize = true;
            this.LbError.Location = new System.Drawing.Point(139, 58);
            this.LbError.Name = "LbError";
            this.LbError.Size = new System.Drawing.Size(204, 26);
            this.LbError.TabIndex = 0;
            this.LbError.Text = "No se pueden realizar alquileres para\r\n esa instalación porque no está disponible" +
    "";
            this.LbError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PNoDisponible
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 164);
            this.Controls.Add(this.LbError);
            this.Name = "PNoDisponible";
            this.Text = "Error";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbError;
    }
}