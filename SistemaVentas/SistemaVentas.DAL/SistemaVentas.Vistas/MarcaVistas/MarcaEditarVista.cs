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

namespace SistemaVentas.Vistas.MarcaVistas
{
    public partial class MarcaEditarVista : Form
    {
        int idmarca = 0;
        Marca marca = new Marca();
        MarcaBss bss = new MarcaBss();
        public MarcaEditarVista(int idMarcaSeleccionado)
        {
            idmarca = idMarcaSeleccionado;
            InitializeComponent();
        }

        private void MarcaEditarVista_Load(object sender, EventArgs e)
        {
            marca = bss.ObtenerMarcaIdBss(idmarca);
            textBox1.Text = marca.Nombre;
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            marca.Nombre = textBox1.Text;

            bss.EditarMarcaBss(marca);
            MessageBox.Show("La marca ha sido actualizada");
        }
    }
}
