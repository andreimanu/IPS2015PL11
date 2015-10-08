using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentroDeportivo
{
    class Instalacion
    {
        int IDInstalacion { get; set; }
        double Precio { get; set; }

        Alquiler Reservado;

        bool Disponible { get; set; }

        public Instalacion(int IDInstalacion, double Precio)
        {
            this.IDInstalacion = IDInstalacion;
            this.Precio = Precio;
        }

        public void Reservar(Alquiler al)
        {
            Reservado = al;
            Reservado.InstalacionReservada = this;
        }
        public override string ToString() {
            return "IDInstalacion:\t" + IDInstalacion + "\nPrecio:\t" + Precio;
        }
    }
}
