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
    public partial class PAviso : Form
    {
        private List<Alquiler> idAvisos;
        

        public PAviso(List<Alquiler> idAvisos)
        {
            InitializeComponent();
            this.idAvisos = idAvisos;
            foreach (Alquiler a in idAvisos)
                ListUsuarios.Items.Add("ID Socio: " + a.IDSocio + ". Inicio: " + a.horaAlquiladaInicio + ". Fin: " + a.horaAlquiladaFin);


        }

    }
}
