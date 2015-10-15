namespace CentroDeportivo
{
    partial class Control
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.databaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sociosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alquileresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actividadesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instalacionesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sociosDataGridViewTextBoxColumn,
            this.alquileresDataGridViewTextBoxColumn,
            this.actividadesDataGridViewTextBoxColumn,
            this.instalacionesDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.databaseBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(1, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(938, 518);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // databaseBindingSource
            // 
            this.databaseBindingSource.DataSource = typeof(CentroDeportivo.Database);
            // 
            // sociosDataGridViewTextBoxColumn
            // 
            this.sociosDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.sociosDataGridViewTextBoxColumn.DataPropertyName = "Socios";
            this.sociosDataGridViewTextBoxColumn.HeaderText = "Socios";
            this.sociosDataGridViewTextBoxColumn.Name = "sociosDataGridViewTextBoxColumn";
            this.sociosDataGridViewTextBoxColumn.Width = 64;
            // 
            // alquileresDataGridViewTextBoxColumn
            // 
            this.alquileresDataGridViewTextBoxColumn.DataPropertyName = "Alquileres";
            this.alquileresDataGridViewTextBoxColumn.HeaderText = "Alquileres";
            this.alquileresDataGridViewTextBoxColumn.Name = "alquileresDataGridViewTextBoxColumn";
            // 
            // actividadesDataGridViewTextBoxColumn
            // 
            this.actividadesDataGridViewTextBoxColumn.DataPropertyName = "Actividades";
            this.actividadesDataGridViewTextBoxColumn.HeaderText = "Actividades";
            this.actividadesDataGridViewTextBoxColumn.Name = "actividadesDataGridViewTextBoxColumn";
            // 
            // instalacionesDataGridViewTextBoxColumn
            // 
            this.instalacionesDataGridViewTextBoxColumn.DataPropertyName = "Instalaciones";
            this.instalacionesDataGridViewTextBoxColumn.HeaderText = "Instalaciones";
            this.instalacionesDataGridViewTextBoxColumn.Name = "instalacionesDataGridViewTextBoxColumn";
            // 
            // Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 570);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Control";
            this.Text = "Control";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource databaseBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn sociosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alquileresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn actividadesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn instalacionesDataGridViewTextBoxColumn;


    }
}