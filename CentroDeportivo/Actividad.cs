using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentroDeportivo
{
    public class Actividad
    {
        int ID { get; set; }
        DateTime fechaInscripcionClientes { get; set; }
        DateTime fechaInscripcionSocios { get; set; }
        DateTime Duracion { get; set; }
        double Precio { get; set; }
        List<Socio> listaApuntados { get; set; }

        public Actividad(int ID, DateTime fechaInscripcionSocios, DateTime fechaInscripcionClientes, DateTime Duracion, double Precio)
        {
            this.ID = ID;
            this.fechaInscripcionClientes = fechaInscripcionClientes;
            this.fechaInscripcionSocios = fechaInscripcionSocios;
            this.Duracion = Duracion;
            this.Precio = Precio;
        }

        public void addSocio(Socio sc)
        {
            listaApuntados.Add(sc);
            sc.AddActividad(this);
        }
        public override string ToString() {
            return "Fecha Inscripcion Clientes:\t" + fechaInscripcionClientes + "\nFecha Inscripcion Socios:\t" + fechaInscripcionSocios +
                "\nDuracion:\t" + Duracion + "\nPrecio:\t" + Precio;
        }
    }
}
