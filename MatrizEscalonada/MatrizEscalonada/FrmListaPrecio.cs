﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatrizEscalonada
{
    public partial class FrmListaPrecio : Form
    {
        //[,] = quiere decir que tiene dos dimensiones
        //tres filas, dos columnas -- filas (precio // producto)
                                
        public string[,] Producto = new string[3, 2];
        public decimal[] Precio = new decimal[3];
        public int[,] codigo = new int[3,2];

        public int fila;



        public FrmListaPrecio()
        {
            InitializeComponent();
        }

        private void btsalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btaceptar_Click(object sender, EventArgs e)
        {
            if (fila >= 2)
            {
                MessageBox.Show("no se pueden ingresar mas productos");
            }
            else
            {
                Producto [fila, 0] = txproducto.Text;
                Producto [fila, 1] = txproducto.Text;

                Producto [fila, 0] = (txcodigo.Text);
                Producto[fila, 1] = (txcodigo.Text);

                Precio[fila] = Convert.ToDecimal(txprecio.Text);

                fila = fila + 1;
            }


        }

        private void btlistar_Click(object sender, EventArgs e)
        {

            lblListaPrecio.Text = "lista de precios \r\n";

            for (int incremento = 0; incremento < Producto.Length; incremento++)
            {
                lblListaPrecio.Text =
                    Producto[incremento, 0] + " " + Producto[incremento, 1] + codigo[incremento, 0] + codigo[incremento,1] + " " +
                    " - " + Convert.ToString(Precio[incremento]) + "\r\n";
            }
        }
    }
}
