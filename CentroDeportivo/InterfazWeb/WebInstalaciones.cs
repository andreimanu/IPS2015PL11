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
            Alquiler al = new Alquiler(new DateTime(2015, 10, 20), 0.58, 0, 125, 0, new DateTime(2015, 10, 20, 11, 0, 0), new DateTime(2015, 10, 20, 12, 0, 0), true);
            db.Alquileres.Add(new Alquiler(new DateTime(2015, 10, 20), 0.58, 0, 129, 0, new DateTime(2015,10,20,9,0,0) , new DateTime(2015, 10, 20, 10,0,0),false));
            db.Alquileres.Add(new Alquiler(new DateTime(2015, 10, 20), 0.58, 1, 128, 0, new DateTime(2015, 10, 20, 11, 0, 0), new DateTime(2015, 10, 20, 12, 0, 0),false));
            db.Alquileres.Add(al);
            rellenarListaInstalaciones();
        }

        private void rellenarListaInstalaciones()
        {
            foreach (Instalacion i in db.Instalaciones)
            {
                listBox2.Items.Add(i);
            }
        }


        private void lswProductos_MouseClick(object sender, MouseEventArgs e)
        {
            Instalacion item = (Instalacion)listBox2.SelectedItem;

            if (item != null)
            {
                limpiarLista();
                DateTime fecha = monthCalendar1.SelectionRange.Start;
                foreach (Alquiler al in db.Alquileres)
                {
                    if (al.FechaAlquiler.CompareTo(fecha) == 0 && al.ID == item.IDInstalacion && al.IDSocio != 0)
                    {

                        listBox1.Items.RemoveAt(al.horaAlquiladaInicio.Hour - 8);
                        listBox1.Items.Insert((al.horaAlquiladaInicio.Hour - 8), al);
                        if (al.horaAlquiladaFin.Hour - al.horaAlquiladaInicio.Hour > 1)
                        {
                            listBox1.Items.RemoveAt(al.horaAlquiladaFin.Hour - 8);
                            listBox1.Items.Insert((al.horaAlquiladaFin.Hour - 8), al);
                            listBox1.ForeColor = Color.FromArgb(100, 44, 55);
                        }
                    }
                    else if (al.noDisponible == true && al.ID == item.IDInstalacion)
                    {
                        listBox1.Items.RemoveAt(al.horaAlquiladaInicio.Hour - 8);
                        listBox1.Items.Insert((al.horaAlquiladaInicio.Hour - 8), al);
                        if (al.horaAlquiladaFin.Hour - al.horaAlquiladaInicio.Hour > 1)
                        {
                            listBox1.Items.RemoveAt(al.horaAlquiladaFin.Hour - 8);
                            listBox1.Items.Insert((al.horaAlquiladaFin.Hour - 8), al);
                        }
                    }
                }
            }
        }

        private void limpiarLista()
        {
            Object[] alquileres = new Object[14];
            int hora1 = 8;
            int hora2 = 9;
            int ID = 0;
            Instalacion instalacion = (Instalacion)listBox2.SelectedItem;
            if(instalacion != null)
            {
                ID = instalacion.IDInstalacion;

            }

            for(int i = 0; i < 14; i++)
            {
                alquileres[i] = (new Alquiler(new DateTime(2015, 10, 20), 0.58, 0, instalacion.IDInstalacion, 0, new DateTime(2015, 10, 20, hora1, 0, 0), new DateTime(2015, 10, 20, hora2, 0, 0), false));
                hora1++;
                hora2++;
            }
            listBox1.Items.Clear();
            listBox1.Items.AddRange(alquileres);
        }

        private void button_MouseClick(object sender, MouseEventArgs e)
        {
            var lista = listBox1.SelectedItems;
            if (lista.Count <= 2 && lista.Count > 0)
            {
                foreach(Alquiler i in lista)
                 {
                    if (i.tp == Alquiler.tipos.OCUPADO)
                    {
                        MessageBox.Show("No se puede alquilar. Ya está reservado por otro usuario");
                    }
                    else
                    {
                        i.IDSocio = 1;
                        i.actualizar();
                        db.Alquileres.Add(i);
                    }
                 }

            }
            else
            {
                if (lista.Count > 2)
                {
                    MessageBox.Show("No se pueden alquilar más de dos horas seguidas. Lo sentimos.");
                }
            }
        }
    }
}