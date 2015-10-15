namespace CentroDeportivo
{
    partial class Web
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
            this.textLinkWeb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textLinkWeb
            // 
            this.textLinkWeb.Location = new System.Drawing.Point(12, 12);
            this.textLinkWeb.Name = "textLinkWeb";
            this.textLinkWeb.Size = new System.Drawing.Size(921, 20);
            this.textLinkWeb.TabIndex = 1;
            this.textLinkWeb.Text = "http:\\\\www.centrodeportivouniovi.es";
            this.textLinkWeb.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Web
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 563);
            this.Controls.Add(this.textLinkWeb);
            this.Name = "Web";
            this.Text = "Web";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textLinkWeb;

    }
}