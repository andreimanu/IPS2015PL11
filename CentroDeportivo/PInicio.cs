using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CentroDeportivo
{
    public partial class PInicio : Form
    {
        public PInicio()
        {
            InitializeComponent();
        }

        private void AbrirOrganizador(object sender, EventArgs e)
        {
            POrganizador organizador = new POrganizador();
            organizador.ShowDialog();
        }

        private void AbrirRecepcionista(object sender, EventArgs e)
        {
            
            Control cs = new Control();
            cs.ShowDialog();
        }
    }
}
