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
    public partial class Control : Form
    {
        public Database db = new Database();
        public Control()
        {
            InitializeComponent();
            UpdateUsers();
        }

        public bool SignUp(Socio soc) {
            return db.Socios.Add(soc);
        }

        public bool Remove(Socio soc)
        {
            return db.Socios.Remove(soc);
        }

        public bool Reserva(Alquiler al, Instalacion inst) {
            bool InstalacionDisponible = true;
            foreach (Alquiler a in db.Alquileres)
            {
                if ((a.horaAlquiladaInicio > al.horaAlquiladaInicio) && (a.horaAlquiladaFin <= al.horaAlquiladaFin))
                    InstalacionDisponible = false;
            }
            if ((al.InstalacionReservada == null) && InstalacionDisponible)
            {
                al.InstalacionReservada = inst;
                inst.Reservar(al);
                return db.Alquileres.Add(al);
            }
            return false;
            
        }

        public HashSet<Alquiler> ConsultarAlquileres() {
            return db.Alquileres;
        }

        public HashSet<Socio> ConsultarSocios() {
            return db.Socios;
        }

        public HashSet<Instalacion> ConsultarInstalaciones() {
            return db.Instalaciones;
        }

        private void Populate(string selectComm)
        {
            DataTable table = new DataTable();
            table.Locale = System.Globalization.CultureInfo.InvariantCulture;
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            UpdateUsers();
        }


        internal void UpdateUsers()
        {
            foreach(Socio s in db.Socios)
            {
                listBox1.Items.Add(s);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Alta alta = new Alta(db, this);
            alta.ShowDialog();
        }

        public void RefreshUsers()
        {
            listBox1.Items.Clear();
            UpdateUsers();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Socio sc = listBox1.SelectedItem as Socio;
            Remove(sc);
            RefreshUsers();
        }
    }
}
