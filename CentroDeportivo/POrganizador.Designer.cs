namespace CentroDeportivo
{
    partial class POrganizador
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtDisponibilidad = new System.Windows.Forms.Button();
            this.ListInstalaciones = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtDisponibilidad);
            this.panel1.Controls.Add(this.ListInstalaciones);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(861, 359);
            this.panel1.TabIndex = 1;
            // 
            // BtDisponibilidad
            // 
            this.BtDisponibilidad.Location = new System.Drawing.Point(600, 111);
            this.BtDisponibilidad.Name = "BtDisponibilidad";
            this.BtDisponibilidad.Size = new System.Drawing.Size(132, 56);
            this.BtDisponibilidad.TabIndex = 1;
            this.BtDisponibilidad.Text = "Cambiar disponibilidad";
            this.BtDisponibilidad.UseVisualStyleBackColor = true;
            this.BtDisponibilidad.Click += new System.EventHandler(this.CambiarDisponibilidad);
            // 
            // ListInstalaciones
            // 
            this.ListInstalaciones.FormattingEnabled = true;
            this.ListInstalaciones.Location = new System.Drawing.Point(124, 67);
            this.ListInstalaciones.Name = "ListInstalaciones";
            this.ListInstalaciones.Size = new System.Drawing.Size(414, 173);
            this.ListInstalaciones.TabIndex = 0;
            // 
            // POrganizador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 359);
            this.Controls.Add(this.panel1);
            this.Name = "POrganizador";
            this.Text = "Organizador";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox ListInstalaciones;
        private System.Windows.Forms.Button BtDisponibilidad;
    }
}