namespace CentroDeportivo.InterfazWeb
{
    partial class WebInicio
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textLinkWeb
            // 
            this.textLinkWeb.Location = new System.Drawing.Point(4, 5);
            this.textLinkWeb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textLinkWeb.Name = "textLinkWeb";
            this.textLinkWeb.Size = new System.Drawing.Size(1344, 26);
            this.textLinkWeb.TabIndex = 3;
            this.textLinkWeb.Text = "http:\\\\www.centrodeportivouniovi.es\\login\\";
            this.textLinkWeb.TextChanged += new System.EventHandler(this.textLinkWeb_TextChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.textLinkWeb);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1352, 36);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // WebInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1352, 462);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "WebInicio";
            this.Text = "WebInicio";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textLinkWeb;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}