﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercitacionArreglos
{
    public partial class Datos : Form
    {
        public Persona[] personas = new Persona[1];
        int posicion = 0;

        public Datos()
        {
            InitializeComponent();
        }


        private void btCargar_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();

            persona.Nombre = txNombre.Text;
            persona.Apellido = txApellido.Text;
            persona.Documento = Convert.ToInt64(txDocumento.Text);
            persona.Cuil = Convert.ToInt64(txCuil.Text);
            persona.Telefono = Convert.ToInt64(txTelefono.Text);
            persona.Direccion = txDireccion.Text;

            txNombre.Text = "";
            txApellido.Text = "";
            txDocumento.Text = "";
            txCuil.Text = "";
            txTelefono.Text = "";
            txDireccion.Text = "";

            posicion = posicion + 1;
            personas[posicion - 1] = persona;
        }

        private void btMostrar_Click(object sender, EventArgs e)
        {
            lbLista.Text = "Lista de personas cargadas: " + "\r\n" + "\r\n"
                + "Nombre: " + personas[0].Nombre + "\r\n"
                + "Apellido: " + personas[0].Apellido + "\r\n"
                + "Documento: " + personas[0].Documento + "\r\n"
                + "Cuil: " + personas[0].Cuil + "\r\n"
                + "Teléfono: " + personas[0].Telefono + "\r\n"
                + "Dirección: " + personas[0].Direccion;

            lbLista.Visible = true;
        }
        private void btSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}


       
