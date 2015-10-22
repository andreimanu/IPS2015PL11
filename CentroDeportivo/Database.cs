using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentroDeportivo
{
    public class Database
    {
        

        public Database()
        {
            Socios = new HashSet<Socio>();
            Alquileres = new HashSet<Alquiler>();
            Actividades = new HashSet<Actividad>();
            Instalaciones = new HashSet<Instalacion>();
        }
        public HashSet<Socio> Socios { get; set; }
        public HashSet<Alquiler> Alquileres { get; set; }
        public HashSet<Actividad> Actividades { get; set; }
        public HashSet<Instalacion> Instalaciones { get; set; }

    }
}
