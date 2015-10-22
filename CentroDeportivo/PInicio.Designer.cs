namespace CentroDeportivo
{
    partial class PInicio
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
            this.BtOrganizador = new System.Windows.Forms.Button();
            this.BtRecepcionista = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtOrganizador);
            this.panel1.Controls.Add(this.BtRecepcionista);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1101, 529);
            this.panel1.TabIndex = 0;
            // 
            // BtOrganizador
            // 
            this.BtOrganizador.Location = new System.Drawing.Point(430, 230);
            this.BtOrganizador.Name = "BtOrganizador";
            this.BtOrganizador.Size = new System.Drawing.Size(178, 55);
            this.BtOrganizador.TabIndex = 1;
            this.BtOrganizador.Text = "Organizador";
            this.BtOrganizador.UseVisualStyleBackColor = true;
            this.BtOrganizador.Click += new System.EventHandler(this.AbrirOrganizador);
            // 
            // BtRecepcionista
            // 
            this.BtRecepcionista.Location = new System.Drawing.Point(430, 141);
            this.BtRecepcionista.Name = "BtRecepcionista";
            this.BtRecepcionista.Size = new System.Drawing.Size(179, 50);
            this.BtRecepcionista.TabIndex = 0;
            this.BtRecepcionista.Text = "Recepcionista";
            this.BtRecepcionista.UseVisualStyleBackColor = true;
            this.BtRecepcionista.Click += new System.EventHandler(this.AbrirRecepcionista);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 529);
            this.Controls.Add(this.panel1);
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtOrganizador;
        private System.Windows.Forms.Button BtRecepcionista;
    }
}