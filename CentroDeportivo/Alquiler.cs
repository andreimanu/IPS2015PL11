using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentroDeportivo
{
    public class Alquiler
    {
        internal DateTime FechaAlquiler { get; set; }
        internal double Precio { get; set; }
        internal int IDSocio { get; set; }
        internal int ID { get; set; }
        internal int horaAlquiladaInicio { get; set; }
        internal int horaAlquiladaFin { get; set; }
        public enum metodosPago{METALICO = 0, TARJETA = 1, DOMICILIO = 2 }

        public metodosPago mp;
        internal Instalacion InstalacionReservada;

        public Alquiler(DateTime FechaAlquiler, double Precio, int IDSocio, int ID, metodosPago mp,int horaAlquiladaInicio, int horaAlquiladaFin)
        {
            this.FechaAlquiler = FechaAlquiler;
            this.Precio = Precio;
            this.ID = ID;
            this.IDSocio = IDSocio;
            this.mp = mp;
            this.horaAlquiladaFin = horaAlquiladaFin;
            this.horaAlquiladaInicio = horaAlquiladaInicio;
        }
    }
}
