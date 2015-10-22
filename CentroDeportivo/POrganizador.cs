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
    public partial class POrganizador : Form
    {
        public Database db = new Database();

        public POrganizador()
        {
            InitializeComponent();
            db.Socios = MainClass.gn.Socios;
            db.Instalaciones = MainClass.gn.Instalaciones;
            UpdateInstalaciones();
        }

        internal void UpdateInstalaciones()
        {
            foreach (Instalacion i in db.Instalaciones)
                ListInstalaciones.Items.Add(i);
        }

        private void CambiarDisponibilidad(object sender, EventArgs e)
        {
            Instalacion ins = ListInstalaciones.SelectedItem as Instalacion;

            if (ins != null)
            {
                if (ins.Disponible)
                {

                    ins.Disponible = false;

                }
                else
                {
                    ins.Disponible = true;
                }
                RefreshInstalaciones();
            }
        }

        public void RefreshInstalaciones()
        {
            ListInstalaciones.Items.Clear();
            UpdateInstalaciones();
        }
    }
}

