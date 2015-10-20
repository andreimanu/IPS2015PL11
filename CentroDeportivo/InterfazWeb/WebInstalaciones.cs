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
            db.Alquileres.Add(new Alquiler(new DateTime(2015,10,20),0.58,0,129,0,9,10));
            rellenarListaInstalaciones();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection instalacion =
                this.listView1.SelectedItems;

            foreach (ListViewItem item in instalacion)
            {
                
            }
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

        private void rellenarListaAlquileres()
        {
            foreach (Instalacion i in db.Instalaciones)
            {

                ListViewItem lvi = new ListViewItem(Convert.ToString(i.IDInstalacion));
                lvi.SubItems.Add(Convert.ToString(i.Precio));

                listView1.Items.Add(lvi);
            }
        }


        private void lswProductos_MouseClick(object sender, MouseEventArgs e)
        {
            ListViewItem item = listView1.GetItemAt(e.X, e.Y);

            if (item != null)
            {
                DateTime fecha = monthCalendar1.SelectionRange.Start;
                foreach (Alquiler al in db.Alquileres)
                {
                    if (al.FechaAlquiler.CompareTo(fecha) == 0 && Convert.ToString(al.ID) == item.Text)
                    {

                        String línea = al.horaAlquiladaInicio + ":00           OCUPADO";
                        listBox1.Items.RemoveAt(al.horaAlquiladaInicio - 8);
                        listBox1.Items.Insert((al.horaAlquiladaInicio - 8), línea);
                    }
                }
            }
        }

    }
}