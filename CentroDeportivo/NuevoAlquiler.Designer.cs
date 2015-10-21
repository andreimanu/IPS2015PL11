namespace CentroDeportivo
{
    partial class NuevoAlquiler
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
            this.lbSocio = new System.Windows.Forms.ListBox();
            this.lblSocio = new System.Windows.Forms.Label();
            this.dtFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.rbMetalico = new System.Windows.Forms.RadioButton();
            this.rbTarjeta = new System.Windows.Forms.RadioButton();
            this.rbDomicilio = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbSocio
            // 
            this.lbSocio.FormattingEnabled = true;
            this.lbSocio.Location = new System.Drawing.Point(13, 34);
            this.lbSocio.Name = "lbSocio";
            this.lbSocio.Size = new System.Drawing.Size(526, 95);
            this.lbSocio.TabIndex = 0;
            // 
            // lblSocio
            // 
            this.lblSocio.AutoSize = true;
            this.lblSocio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSocio.Location = new System.Drawing.Point(13, 7);
            this.lblSocio.Name = "lblSocio";
            this.lblSocio.Size = new System.Drawing.Size(53, 20);
            this.lblSocio.TabIndex = 1;
            this.lblSocio.Text = "Socio:";
            // 
            // dtFechaInicio
            // 
            this.dtFechaInicio.CustomFormat = "yyyy.MM.dd HH:mm";
            this.dtFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFechaInicio.Location = new System.Drawing.Point(13, 166);
            this.dtFechaInicio.Name = "dtFechaInicio";
            this.dtFechaInicio.ShowUpDown = true;
            this.dtFechaInicio.Size = new System.Drawing.Size(122, 20);
            this.dtFechaInicio.TabIndex = 2;
            this.dtFechaInicio.ValueChanged += new System.EventHandler(this.dtFechaInicio_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fecha inicio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(252, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fecha fin:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy.MM.dd HH:mm";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(256, 166);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(127, 20);
            this.dateTimePicker1.TabIndex = 5;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // rbMetalico
            // 
            this.rbMetalico.AutoSize = true;
            this.rbMetalico.Location = new System.Drawing.Point(6, 19);
            this.rbMetalico.Name = "rbMetalico";
            this.rbMetalico.Size = new System.Drawing.Size(65, 17);
            this.rbMetalico.TabIndex = 6;
            this.rbMetalico.TabStop = true;
            this.rbMetalico.Text = "Metalico";
            this.rbMetalico.UseVisualStyleBackColor = true;
            this.rbMetalico.CheckedChanged += new System.EventHandler(this.rbMetalico_CheckedChanged);
            // 
            // rbTarjeta
            // 
            this.rbTarjeta.AutoSize = true;
            this.rbTarjeta.Location = new System.Drawing.Point(86, 19);
            this.rbTarjeta.Name = "rbTarjeta";
            this.rbTarjeta.Size = new System.Drawing.Size(58, 17);
            this.rbTarjeta.TabIndex = 7;
            this.rbTarjeta.TabStop = true;
            this.rbTarjeta.Text = "Tarjeta";
            this.rbTarjeta.UseVisualStyleBackColor = true;
            this.rbTarjeta.CheckedChanged += new System.EventHandler(this.rbTarjeta_CheckedChanged);
            // 
            // rbDomicilio
            // 
            this.rbDomicilio.AutoSize = true;
            this.rbDomicilio.Location = new System.Drawing.Point(150, 19);
            this.rbDomicilio.Name = "rbDomicilio";
            this.rbDomicilio.Size = new System.Drawing.Size(67, 17);
            this.rbDomicilio.TabIndex = 8;
            this.rbDomicilio.TabStop = true;
            this.rbDomicilio.Text = "Domicilio";
            this.rbDomicilio.UseVisualStyleBackColor = true;
            this.rbDomicilio.CheckedChanged += new System.EventHandler(this.rbDomicilio_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbMetalico);
            this.groupBox1.Controls.Add(this.rbTarjeta);
            this.groupBox1.Controls.Add(this.rbDomicilio);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 215);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 100);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Metodos de pago:";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(386, 436);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Registrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NuevoAlquiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 482);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtFechaInicio);
            this.Controls.Add(this.lblSocio);
            this.Controls.Add(this.lbSocio);
            this.Name = "NuevoAlquiler";
            this.Text = "NuevoAlquiler";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbSocio;
        private System.Windows.Forms.Label lblSocio;
        private System.Windows.Forms.DateTimePicker dtFechaInicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RadioButton rbMetalico;
        private System.Windows.Forms.RadioButton rbTarjeta;
        private System.Windows.Forms.RadioButton rbDomicilio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
    }
}