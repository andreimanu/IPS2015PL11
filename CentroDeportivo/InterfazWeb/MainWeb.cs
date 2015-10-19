using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentroDeportivo.InterfazWeb
{
    class MainWeb
    {

        internal void InicioWeb()
        {
            inicio();
        }

        private void inicio()
        {
            WebInicio wi = new WebInicio();
            wi.ShowDialog();
        }
    }
}
