using SistemaVentas.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVentas.Vistas.Interfaz
{
    public partial class SesionGerente : Form
    {
        public SesionGerente()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string usuario = textBox1.Text;
            string contraseña = textBox2.Text;
            string rol = "administrador"; // Asigna el rol según tu lógica de negocio

            if (conexion.VerificarCredenciales(usuario,contraseña))
            {
                MessageBox.Show("inicio de session exitoso");
                InterfazGerente formulario = new InterfazGerente();
                formulario.Show();

            }
            else
            {
                MessageBox.Show("usuario o contrasena incorrectos");
            }

            /*if (conexion.VerificarCredenciales(usuario, contraseña, rol))
            {
                MessageBox.Show("Inicio de sesión exitoso");
                // Abre la interfaz correspondiente al rol
                if (rol == "gerente")
                {
                    InterfazGerente formulario = new InterfazGerente();
                    formulario.Show();
                }
                else if (rol == "vendedor")
                {
                    InterfazVendedor formulario = new InterfazVendedor();
                    formulario.Show();
                }
            }
            else
            {
                MessageBox.Show("Usuario o contraseña son incorrectos");
            }*/

            /*InterfazGerente Abrir = new InterfazGerente();
            Abrir.Show();*/
        }
    }
}
