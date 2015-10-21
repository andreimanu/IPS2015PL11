
using CentroDeportivo.InterfazWeb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentroDeportivo
{
    public class MainClass
    {
        public static Generador gn;
        static int Main(string[] args)
        {
            printList();
            return 0;
        }

        public static void printList()
        {
            gn = new Generador();
            gn.generar();
            Control cs = new Control();
            cs.ShowDialog();
            cs.UpdateUsers();

            MainWeb mw = new MainWeb();
            mw.InicioWeb();
            
            
        }
    }
}
