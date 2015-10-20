using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentroDeportivo.InterfazWeb
{
    class MainWeb
    {

        private Database db = new Database();
        private Generador gn = new Generador();

        internal void InicioWeb()
        {
            
            this.gn.generar();
            this.db.Actividades = this.gn.Actividades;
            this.db.Alquileres = this.gn.Alquileres;
            this.db.Instalaciones = this.gn.Instalaciones;
            this.db.Socios = this.gn.Socios;
            inicio();

        }

        private void inicio()
        {
            WebInstalaciones wi = new WebInstalaciones(db);
            wi.ShowDialog();
        }
    }
}
