using SistemaVentas.BSS;
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

namespace SistemaVentas.Vistas.TipoProdVistas
{
    public partial class TipoProdEditarVista : Form
    {
        int idtipoprod = 0;
        TipoProd tipoprod = new TipoProd();
        TipoProdBss bss = new TipoProdBss();
        public TipoProdEditarVista(int idTipoProdSeleccionado)
        {
            idtipoprod = idTipoProdSeleccionado;
            InitializeComponent();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            tipoprod.Nombre = textBox1.Text;

            bss.EditarTipoProdBss(tipoprod);
            MessageBox.Show("El tipo de producto ha sido actualizado");
        }

        private void TipoProdEditarVista_Load(object sender, EventArgs e)
        {
            tipoprod = bss.ObtenerTipoProdIdBss(idtipoprod);
            textBox1.Text = tipoprod.Nombre;
        }
    }
}
