using SistemaVentas.BSS;
using SistemaVentas.Modelos;
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
    public partial class UsuarioInsertarVista : Form
    {
        public static int IdPersonaSeleccionada = 0;
        public UsuarioInsertarVista()
        {
            InitializeComponent();
        }
        PersonaBss bss = new PersonaBss();
        UsuarioBss bssusuario = new UsuarioBss();
        private void UsuarioInsertarVista_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.IdPersona = IdPersonaSeleccionada;
            usuario.NombreUser = textBox2.Text;
            usuario.Contraseña = textBox3.Text;
            usuario.FechaReg = dateTimePicker1.Value;

            bssusuario.InsertarUsuarioBss(usuario);
            MessageBox.Show("Se a guardado correctamente el usuario");
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void buttonSeleccionado_Click(object sender, EventArgs e)
        {
            PersonaListarVista fr = new PersonaListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Persona persona = bss.ObtenerIdBss(IdPersonaSeleccionada);
                textBox1.Text = persona.Nombre + " " + persona.Apellido;

            }
        }
    }
}
