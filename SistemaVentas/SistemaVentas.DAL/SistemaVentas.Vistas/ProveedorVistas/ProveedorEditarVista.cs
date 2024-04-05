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

namespace SistemaVentas.Vistas.ProveedorVistas
{
    public partial class ProveedorEditarVista : Form
    {
        int idproveedor = 0;
        Proveedor proveedor = new Proveedor();
        ProveedorBss bss = new ProveedorBss();
        public ProveedorEditarVista(int idProveedorSeleccionado)
        {
            idproveedor = idProveedorSeleccionado;
            InitializeComponent();
        }

        private void ProveedorEditarVista_Load(object sender, EventArgs e)
        {
            proveedor = bss.ObtenerProveedorIdBss(idproveedor);
            textBox1.Text = proveedor.Nombre;
            textBox2.Text = proveedor.Telefono;
            textBox3.Text = proveedor.Direccion;
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            proveedor.Nombre = textBox1.Text;
            proveedor.Telefono = textBox2.Text;
            proveedor.Direccion = textBox3.Text;

            bss.EditarProveedorBss(proveedor);
            MessageBox.Show("El proveedor ha sido actualizado");
        }
    }
}
