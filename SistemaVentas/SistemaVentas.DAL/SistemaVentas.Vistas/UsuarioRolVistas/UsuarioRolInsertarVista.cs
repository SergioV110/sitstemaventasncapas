using SistemaVentas.BSS;
using SistemaVentas.Modelos;
using SistemaVentas.Vistas.RolVistas;
using SistemaVentas.Vistas.UsuarioVistas;
using SistemaVentas.Vistas.VentaVistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVentas.Vistas.UsuarioRolVistas
{
    public partial class UsuarioRolInsertarVista : Form
    {
        public static int IdUsuarioSeleccionado { get; internal set; }
        public static int IdRolSeleccionado { get; internal set; }
        public UsuarioRolInsertarVista()
        {
            InitializeComponent();
        }
        UsuarioRolBss bss = new UsuarioRolBss();
        private void UsuarioRolInsertarVista_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UsuarioRol ur = new UsuarioRol();
            ur.IdUsuario = IdUsuarioSeleccionado;
            ur.IdRol = IdRolSeleccionado;
            ur.FechaAsigna = dateTimePicker1.Value;

            bss.InsertarUsuarioRolBss(ur);
            MessageBox.Show("Se guardo correctamente el usuariorol");
        }
        UsuarioBss bssusario = new UsuarioBss();
        private void buttonSelecUsuario_Click(object sender, EventArgs e)
        {
            UsuarioListarVista fr = new UsuarioListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Usuario usuario = bssusario.ObtenerUsuarioIdBss(IdUsuarioSeleccionado);
                textBox1.Text = Convert.ToString(usuario.IdUsuario);
            }
        }
        RolBss bssrol = new RolBss();
        private void buttonSelecRol_Click(object sender, EventArgs e)
        {
            RolListarVista fr = new RolListarVista();
            if(fr.ShowDialog() == DialogResult.OK)
            {
                Rol rol = bssrol.ObtenerRolIdBss(IdRolSeleccionado);
                textBox2.Text = Convert.ToString(rol.Nombre);
            }
        }
    }
}
