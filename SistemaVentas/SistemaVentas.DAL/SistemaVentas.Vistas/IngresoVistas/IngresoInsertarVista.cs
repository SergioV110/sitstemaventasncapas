﻿using SistemaVentas.Modelos;
using SistemaVentas.BSS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVentas.Vistas.IngresoVistas
{
    public partial class IngresoInsertarVista : Form
    {
        public IngresoInsertarVista()
        {
            InitializeComponent();
        }
        IngresoBss bss = new IngresoBss();
        private void button1_Click(object sender, EventArgs e)
        {
            Ingreso i = new Ingreso();
            i.IdProveedor =Convert.ToInt32(textBox1.Text);
            i.FechaIngreso= dateTimePicker1.Value;
            i.Total= Convert.ToDecimal(textBox2.Text);

            bss.InsertarIngresoBss(i);
            MessageBox.Show("Se a guardado ingreso correctamente");

        }
        private void IngresoInsertarVista_Load(object sender, EventArgs e)
        {

        }

        
    }
}
