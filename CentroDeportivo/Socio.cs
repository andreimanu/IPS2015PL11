using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentroDeportivo
{
    public class Socio
    {
        string Nombre { get; set; }
        string Apellidos { get; set; }
        string NumeroCuenta { get; set; }
        double Importe {get; set; }
        List<Actividad> Actividades { get; set; }
        int ID { get; set; }

        
        public Socio(string Nombre, string Apellidos, string NumeroCuenta, double Importe, int ID)
        {
            this.ID = ID;
            this.Nombre = Nombre;
            this.Apellidos = Apellidos;
            this.NumeroCuenta = NumeroCuenta;
            this.Importe = Importe;
        }

        public void AddActividad(Actividad actividad) {

        }

        public override string ToString() {
            return "Nombre:\t" + Nombre + "\nApellidos:\t" + Apellidos + "\nNumero Cuenta:\t" + NumeroCuenta + "\nImporte:\t" + Importe;
        }
    }
}
