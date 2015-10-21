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
    public partial class NuevoAlquiler : Form
    {
        Database db;
        DateTime fechaInicio;
        DateTime fechaFin;
        Instalacion inst;
        Control cs;
        public Alquiler.metodosPago mp;
        public NuevoAlquiler(Database db, Instalacion inst, Control cs)
        {
            this.db = db;
            this.inst = inst;
            this.cs = cs;
            InitializeComponent();
            populate();
        }

        private void populate()
        {
            foreach (Socio sc in db.Socios)
                this.lbSocio.Items.Add(sc);
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void rbMetalico_CheckedChanged(object sender, EventArgs e)
        {
            this.mp = Alquiler.metodosPago.METALICO;
        }

        private void rbTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            this.mp = Alquiler.metodosPago.TARJETA;
        }

        private void rbDomicilio_CheckedChanged(object sender, EventArgs e)
        {
            this.mp = Alquiler.metodosPago.DOMICILIO;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Alquiler al;
            Socio sc = lbSocio.SelectedItem as Socio;
            DateTime fechaAlquiler = DateTime.Now;
            al = new Alquiler(fechaAlquiler, inst.Precio, sc.getID(), db.Alquileres.Count, mp, fechaInicio, fechaFin, false);
            db.Alquileres.Add(al);
            inst.Reservar(al);
            cs.RefreshAlquileres();
            cs.RefreshInstalaciones();
            this.Dispose();
        }

        private void dtFechaInicio_ValueChanged(object sender, EventArgs e)
        {
            this.fechaInicio = dtFechaInicio.Value;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            this.fechaFin = dateTimePicker1.Value;
        }
    }
}
