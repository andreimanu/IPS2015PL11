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
        internal DateTime FechaVencimiento { get; set; }
        internal double Precio { get; set; }
        internal int IDSocio { get; set; }
        internal int ID { get; set; }
        public enum metodosPago{METALICO = 0, TARJETA = 1, DOMICILIO = 2 }

        public metodosPago mp;
        internal Instalacion InstalacionReservada;

        public Alquiler(DateTime FechaAlquiler, DateTime FechaVencimiento, double Precio, int IDSocio, int ID, metodosPago mp)
        {
            this.FechaAlquiler = FechaAlquiler;
            this.FechaVencimiento = FechaVencimiento;
            this.Precio = Precio;
            this.ID = ID;
            this.IDSocio = IDSocio;
            this.mp = mp;
        }
    }
}
