using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentroDeportivo
{
    public class Generador
    {
        int id = 0;
        public HashSet<Socio> Socios { get; set; }
        public HashSet<Actividad> Actividades { get; set; }
        public HashSet<Alquiler> Alquileres { get; set; }
        public HashSet<Instalacion> Instalaciones { get; set; }
        private Random rangen;
        public List<int> randomNum { get; set; }
        List<string> Nombres = new List<string>() { "Santiago", "Mateo", "Sebastian",
        "Alejandro", "Matias", "Diego", "Samuel", "Nicolas", "Daniel", "Martin", "Benjamin",
        "Emiliano", "Leonardo", "Joaquin", "Lucas", "Paloma", "Maria", "Segismunda", "Mercedes", "Sigisfrilda", "Ruka", "Laura", 
        "Paula", "Dominica"};

        List<string> Apellidos = new List<string>() { "Abendano", "Bondia", "Abenhacar", 
        "Bravo", "Costa", "Ximenes", "Barbosa", "Dormido", "Abraham", "Aguero", "Aros",
        "Baiz", "Baez", "Barda", "Baruel", "Cadiz", "Branda", "Diaz", "Pulgar", "Ozorio", 
        "Donate", "Elias", "Garcia", "Wayne"};

        public void generar()
        {
            Socios = new HashSet<Socio>();
            Actividades = new HashSet<Actividad>();
            Alquileres = new HashSet<Alquiler>();
            Instalaciones = new HashSet<Instalacion>();
            randomNum = new List<int>();
            rangen = new Random();
            for (int i = 0; i < 100; i++)
                generarSocios();

            for (int i = 0; i < 20; i++)
                generarActividades();

            for (int i = 0; i < 12; i++)
                generarInstalaciones();
        }

        public void testRandom()
        {
            Console.WriteLine(rangen.Next(50));
        }
        public void generarSocios() {
            int nombre = rangen.Next(Nombres.Count-1);
            int apellido1 = rangen.Next(Apellidos.Count - 1);
            int apellido2 = rangen.Next(Apellidos.Count - 1);

            StringBuilder Hanz = new StringBuilder();
            Hanz.Append("ES");
            for (int i = 0; i < 22; i++)
            {
                Hanz.Append(rangen.Next(9));
            }

            string NombreSocio = Nombres.ToArray()[nombre];
            StringBuilder Franz = new StringBuilder();
            Franz.Append(Apellidos.ToArray()[apellido1]);
            Franz.Append(" ");
            Franz.Append(Apellidos.ToArray()[apellido2]);

            Socios.Add(new Socio(NombreSocio, Franz.ToString(), Hanz.ToString(), 250, this.Socios.Count+1));
        }

        public void generarActividades()
        {
            DateTime start = new DateTime(1995, 1, 1);
            int range = (DateTime.Today - start).Days;
            DateTime random = start.AddDays(rangen.Next(range));
            DateTime random2 = random.AddDays(rangen.Next(25));
            DateTime duracion = random2.AddDays(90);
            Actividades.Add(new Actividad(id++, random, random2, duracion, rangen.NextDouble()));
        }

        public void generarAlquileres()
        {

        }

        public void generarInstalaciones()
        {
            id++;
            double precio = rangen.NextDouble();
            Instalaciones.Add(new Instalacion(this.Instalaciones.Count+1, precio));

        }
    }
}
