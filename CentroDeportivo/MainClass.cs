using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentroDeportivo
{
    class MainClass
    {
        static Generador gn;
        static int Main(string[] args)
        {
            printList();
            return 0;
        }

        public static void printList()
        {
            gn = new Generador();
            gn.generar();
            Console.WriteLine("Socios:\n");
            var sc = gn.Socios;
            for (int i = 0; i < gn.Socios.Count; i++ )
                System.Console.WriteLine(gn.Socios.ToArray()[i]);

            Console.WriteLine("Instalaciones:\n");
            foreach (Instalacion ic in gn.Instalaciones)
                System.Console.WriteLine(ic);

            Console.WriteLine("Actividades:\n");
            foreach (Actividad ac in gn.Actividades)
                System.Console.WriteLine(ac);
        }
    }
}
