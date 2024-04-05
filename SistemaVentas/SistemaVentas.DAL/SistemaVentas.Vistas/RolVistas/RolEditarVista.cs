using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaVentas.BSS;
using SistemaVentas.Modelos;

namespace SistemaVentas.Vistas.RolVistas
{
    public partial class RolEditarVista : Form
    {
        int idrol = 0;
        Rol rol = new Rol();
        RolBss bss = new RolBss();
        public RolEditarVista(int idRolSeleccionado)
        {
            idrol = idRolSeleccionado;
            InitializeComponent();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            rol.Nombre = textBox1.Text;

            bss.EditarRolBss(rol);
            MessageBox.Show("El rol ha sido actualizado");
        }

        private void RolEditarVista_Load(object sender, EventArgs e)
        {
            rol = bss.ObtenerRolIdBss(idrol);
            textBox1.Text = rol.Nombre;
        }
    }
}
