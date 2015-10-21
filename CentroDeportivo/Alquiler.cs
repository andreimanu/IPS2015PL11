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
        internal DateTime horaAlquiladaInicio { get; set; }
        internal DateTime horaAlquiladaFin { get; set; }
        internal bool noDisponible { get; set; }
        public enum metodosPago{METALICO = 0, TARJETA = 1, DOMICILIO = 2}
        public enum tipos{LIBRE = 0, NO_DISPONIBLE = 1, OCUPADO = 2 }

        public metodosPago mp;
        public tipos tp;
        public Instalacion InstalacionReservada;
       

        public Alquiler(DateTime FechaAlquiler, double Precio, int IDSocio, int ID, metodosPago mp,DateTime horaAlquiladaInicio, DateTime horaAlquiladaFin, bool nd)
        {
            this.FechaAlquiler = FechaAlquiler;
            this.Precio = Precio;
            this.ID = ID;
            this.IDSocio = IDSocio;
            this.mp = mp;
            this.horaAlquiladaFin = horaAlquiladaFin;
            this.horaAlquiladaInicio = horaAlquiladaInicio;
            noDisponible = nd;
            actualizar();
            
        }

        public void actualizar()
        {
            if (this.IDSocio == 0 && !this.noDisponible)
            {
                this.tp = tipos.LIBRE;
            }
            else if (this.noDisponible)
            {
                this.tp = tipos.NO_DISPONIBLE;
            }
            else
            {
                this.tp = tipos.OCUPADO;
            }
        }

        public override string ToString()
        {
            return horaAlquiladaInicio.Hour  + ":"+ horaAlquiladaInicio.Minute + horaAlquiladaInicio.Second + " "+ "-" + horaAlquiladaFin.Hour + ":" + horaAlquiladaFin.Minute + horaAlquiladaFin.Second + " " + tp;
        }



        

        }
    }
