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
            Alquiler al = new Alquiler(new DateTime(2015, 10, 21), 0.58, 0, 5, 0, new DateTime(2015, 10, 21, 11, 0, 0), new DateTime(2015, 10, 21, 12, 0, 0), true);
            db.Alquileres.Add(new Alquiler(new DateTime(2015, 10, 21), 0.58, 0, 9, 0, new DateTime(2015,10,21,9,0,0) , new DateTime(2015, 10, 21, 10,0,0),false));
            db.Alquileres.Add(new Alquiler(new DateTime(2015, 10, 21), 0.58, 1, 8, 0, new DateTime(2015, 10, 21, 11, 0, 0), new DateTime(2015, 10, 21, 12, 0, 0),false));
            Alquiler al2 = new Alquiler(new DateTime(2015, 10, 22), 0.58, 0, 5, 0, new DateTime(2015, 10, 22, 11, 0, 0), new DateTime(2015, 10, 22, 12, 0, 0), true);
            db.Alquileres.Add(new Alquiler(new DateTime(2015, 10, 22), 0.58, 0, 9, 0, new DateTime(2015, 10, 22, 9, 0, 0), new DateTime(2015, 10, 22, 10, 0, 0), false));
            db.Alquileres.Add(new Alquiler(new DateTime(2015, 10, 22), 0.58, 1, 8, 0, new DateTime(2015, 10, 22, 11, 0, 0), new DateTime(2015, 10, 22, 12, 0, 0), false));
            Alquiler al3 = new Alquiler(new DateTime(2015, 10, 23), 0.58, 0, 5, 0, new DateTime(2015, 10, 23, 11, 0, 0), new DateTime(2015, 10, 23, 12, 0, 0), true);
            db.Alquileres.Add(new Alquiler(new DateTime(2015, 10, 23), 0.58, 0, 9, 0, new DateTime(2015, 10, 23, 9, 0, 0), new DateTime(2015, 10, 23, 10, 0, 0), false));
            db.Alquileres.Add(new Alquiler(new DateTime(2015, 10, 23), 0.58, 1, 8, 0, new DateTime(2015, 10, 23, 11, 0, 0), new DateTime(2015, 10, 23, 12, 0, 0), false));
            db.Alquileres.Add(al);
            db.Alquileres.Add(al2);
            db.Alquileres.Add(al3);
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
                actualizarListaAlquileres(item);
            }
        }

        private void actualizarListaAlquileres(Instalacion item)
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
                if (instalacion != null) { 
                alquileres[i] = (new Alquiler(new DateTime(2015, 10, monthCalendar1.SelectionRange.Start.Day), 0.58, 0, instalacion.IDInstalacion, 0, new DateTime(2015, 10, monthCalendar1.SelectionRange.Start.Day, hora1, 0, 0), new DateTime(2015, 10, monthCalendar1.SelectionRange.Start.Day, hora2, 0, 0), false));
                hora1++;
                hora2++;
            }
        
            }
            listBox1.Items.Clear();
            listBox1.Items.AddRange(alquileres);
        }

        private void button_MouseClick(object sender, MouseEventArgs e)
        {
            var lista = listBox1.SelectedItems;
            if (lista != null)
            {
                if (lista.Count <= 2 && lista.Count > 0)
                {
                    foreach (Alquiler i in lista)
                    {
                        if (i != null)
                        {
                            if (i.tp == Alquiler.tipos.OCUPADO ||i.tp == Alquiler.tipos.NO_DISPONIBLE)
                            {
                                MessageBox.Show("No se puede alquilar. Ya está reservado por otro usuario");
                            }
                            else
                            {
                                i.IDSocio = 2;
                                i.actualizar();
                                db.Alquileres.Add(i);
                                var result = MessageBox.Show("¿Quiere realizar el pago haciendo un cargo a su cuenta?", "",
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);
                                if (result == DialogResult.No)
                                {
                                    i.mp = Alquiler.metodosPago.METALICO;
                                }
                                else
                                {
                                    i.mp = Alquiler.metodosPago.TARJETA;
                                }
                                MessageBox.Show("la instalación ha sido alquilada satisfactoriamente");


                            }
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
                if (lista.Count == 0)
                {

                }
                else
                    actualizarListaAlquileres((Instalacion)listBox2.SelectedItem);
            }
        }
    }
}
