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
            foreach(Socio sc in gn.Socios)
                System.Console.WriteLine(sc);

            Console.WriteLine("Instalaciones:\n");
            foreach (Instalacion ic in gn.Instalaciones)
                System.Console.WriteLine(ic);

            Console.WriteLine("Actividades:\n");
            foreach (Actividad ac in gn.Actividades)
                System.Console.WriteLine(ac);
        }
    }
}
