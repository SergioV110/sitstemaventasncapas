using SistemaVentas.BSS;
using SistemaVentas.Modelos;
using SistemaVentas.Vistas.ClienteVistas;
using SistemaVentas.Vistas.PersonasVistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVentas.Vistas.UsuarioVistas
{
    public partial class UsuarioEditarVista : Form
    {
        int idusuario = 0;
        Usuario usuario = new Usuario();
        UsuarioBss bssusuario = new UsuarioBss();
        public UsuarioEditarVista(int idUsuarioSeleccionado)
        {
            idusuario = idUsuarioSeleccionado;
            InitializeComponent();
        }

        private void UsuarioEditarVista_Load(object sender, EventArgs e)
        {
            usuario = bssusuario.ObtenerUsuarioIdBss(idusuario);
            textBox1.Text = idPersonaSeleccionado.ToString();
            textBox2.Text = usuario.NombreUser;
            textBox3.Text = usuario.Contraseña;
            dateTimePicker1.Value = usuario.FechaReg;

        }
        public static int idPersonaSeleccionado = 0;
        PersonaBss bss = new PersonaBss();
        private void buttonSeleccionado_Click(object sender, EventArgs e)
        {
            PersonaListarVista fr = new PersonaListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Persona persona = bss.ObtenerIdBss(idPersonaSeleccionado);
                textBox1.Text = persona.Nombre + " " + persona.Apellido;
            }
        }
        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            usuario.IdPersona = idPersonaSeleccionado;
            usuario.NombreUser = textBox2.Text;
            usuario.Contraseña = textBox3.Text;
            usuario.FechaReg = dateTimePicker1.Value;

            bssusuario.EditarUsuarioBss(usuario);
            MessageBox.Show("El usuario ha sido actualizado correctamente el usuario");
        }
    }
}
