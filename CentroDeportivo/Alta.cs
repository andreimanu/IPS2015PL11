using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CentroDeportivo
{
    public partial class Alta : Form
    {
        Database db;
        Control cs;
        public Alta(Database db, Control cs)
        {
            this.db = db;
            this.cs = cs;
            InitializeComponent();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            Socio sc;
            string nombre = tbNombre.Text;
            string apellidos = tbApellidos.Text;
            string iban = tbIBAN.Text;
            double importe = Double.Parse(tbImporte.Text);
            int id = db.Socios.Count;
            sc = new Socio(nombre, apellidos, iban, importe, id);
            db.Socios.Add(sc);
            cs.RefreshUsers();
            this.Dispose();
        }
    }
}
