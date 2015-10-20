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
    public partial class WebInstalaciones : Form
    {

        private Database db;

        public WebInstalaciones(Database db)
        {
            InitializeComponent();
            this.db = db;
            rellenarListaInstalaciones();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rellenarListaInstalaciones()
        {
            foreach (Instalacion i in db.Instalaciones)
            {

                ListViewItem lvi = new ListViewItem(Convert.ToString(i.IDInstalacion));
                lvi.SubItems.Add(Convert.ToString(i.Precio));

                listView1.Items.Add(lvi);
            }
        }
    }
}