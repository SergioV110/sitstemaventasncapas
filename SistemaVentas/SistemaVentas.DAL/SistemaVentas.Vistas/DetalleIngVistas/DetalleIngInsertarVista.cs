﻿using SistemaVentas.BSS;
using SistemaVentas.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVentas.Vistas.DetalleIngVistas
{
    public partial class DetalleIngInsertarVista : Form
    {
        public DetalleIngInsertarVista()
        {
            InitializeComponent();
        }
        DetalleIngBss bss = new DetalleIngBss();
        private void button1_Click(object sender, EventArgs e)
        {
            DetalleIng d = new DetalleIng();
            d.IdIngreso = Convert.ToInt32(textBox1.Text);
            d.IdProducto = Convert.ToInt32(textBox2.Text);
            d.FechaVenc = dateTimePicker1.Value;
            d.Cantidad = Convert.ToInt32(textBox4.Text);
            d.PrecioCosto = Convert.ToDecimal(textBox5.Text);
            d.PrecioVenta = Convert.ToDecimal(textBox6.Text);
            d.SubTotal = Convert.ToDecimal(textBox7.Text);

            bss.InsertarDetalleIngBss(d);
            MessageBox.Show("Se a guardado correctame el detalleing");
        }

        private void DetalleIngInsertarVista_Load(object sender, EventArgs e)
        {

        }
    }
}
