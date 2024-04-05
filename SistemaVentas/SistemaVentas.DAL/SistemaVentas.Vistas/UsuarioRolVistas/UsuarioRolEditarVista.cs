using SistemaVentas.Modelos;
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
using SistemaVentas.Vistas.VentaVistas;
using SistemaVentas.Vistas.UsuarioVistas;
using SistemaVentas.Vistas.RolVistas;

namespace SistemaVentas.Vistas.UsuarioRolVistas
{
    public partial class UsuarioRolEditarVista : Form
    {
        int idx = 0;
        UsuarioRol usuarioRol = new UsuarioRol();
        UsuarioRolBss bss = new UsuarioRolBss();

        public UsuarioRolEditarVista(int idUsuarioRolSeleccionado)
        {
            idx = idUsuarioRolSeleccionado;
            InitializeComponent();
        }
        public static int idUsuarioSeleccionado = 0;
        public static int idRolSeleccionado = 0;
        private void UsuarioRolEditarVista_Load(object sender, EventArgs e)
        {
            usuarioRol = bss.ObtenerUsuarioRolIdBss(idx);
            textBox1.Text = Convert.ToString(usuarioRol.IdUsuario);
            textBox2.Text = Convert.ToString(usuarioRol.IdRol);
            dateTimePicker1.Value = Convert.ToDateTime(usuarioRol.FechaAsigna);
        }
        UsuarioBss bssusuario = new UsuarioBss();
        private void buttonSelecUsuario_Click(object sender, EventArgs e)
        {
            UsuarioListarVista fr = new UsuarioListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Usuario usuario = bssusuario.ObtenerUsuarioIdBss(idUsuarioSeleccionado);
                textBox1.Text = Convert.ToString(usuario.IdUsuario);
            }
        }   
        RolBss bssrol = new RolBss();

        
        private void buttonSelecRol_Click(object sender, EventArgs e)
        {
            RolListarVista fr = new RolListarVista();
            if(fr.ShowDialog() == DialogResult.OK)
            {
                Rol rol = bssrol.ObtenerRolIdBss(idRolSeleccionado);
                textBox2.Text = rol.Nombre;
            }
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            usuarioRol.IdUsuario = idUsuarioSeleccionado;
            usuarioRol.IdRol = idRolSeleccionado;
            usuarioRol.FechaAsigna = dateTimePicker1.Value;

            bss.EditarUsuarioRolBss(usuarioRol);
        }
    }
}
