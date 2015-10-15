using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentroDeportivo
{
    public class Instalacion
    {
        int IDInstalacion { get; set; }
        double Precio { get; set; }

        public HashSet<Alquiler> Reservado;

        public bool Disponible { get; set; }

        public Instalacion(int IDInstalacion, double Precio)
        {
            this.IDInstalacion = IDInstalacion;
            this.Precio = Precio;
            Reservado = new HashSet<Alquiler>();
        }

        public void Reservar(Alquiler al)
        {
            Reservado.Add(al);
        }
        public override string ToString() {
            return "IDInstalacion:\t" + IDInstalacion + "\nPrecio:\t" + Precio;
        }
    }
}
