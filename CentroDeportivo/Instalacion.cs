﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentroDeportivo
{
    public class Instalacion
    {
        internal int IDInstalacion { get; set; }
        internal double Precio { get; set; }

        public HashSet<Alquiler> Reservado;

        public bool Disponible { get; set; }

        public Instalacion(int IDInstalacion, double Precio)
        {
            this.IDInstalacion = IDInstalacion;
            this.Precio = Precio;
            Reservado = new HashSet<Alquiler>();
            this.Disponible = true;
        }

        public void Reservar(Alquiler al)
        {
            Reservado.Add(al);
            Disponible = false;
            al.InstalacionReservada = this;
        }

        public void Liberar(Alquiler al)
        {
            Reservado.Remove(al);
            al.InstalacionReservada = null;
            Disponible = true;
        }
        public override string ToString() {
            return "IDInstalacion:\t" + IDInstalacion + " \nPrecio:\t" + Precio + (Disponible ? " Disponible" : "Alquilado");
        }
    }
}
