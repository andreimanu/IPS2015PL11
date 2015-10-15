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
                if ((a.FechaAlquiler > al.FechaAlquiler) && (a.FechaVencimiento <= al.FechaVencimiento))
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

        

    }
}
