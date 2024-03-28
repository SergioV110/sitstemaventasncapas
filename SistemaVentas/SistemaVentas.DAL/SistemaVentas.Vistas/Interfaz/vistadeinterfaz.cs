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
    public partial class vistadeinterfaz : Form
    {
        public vistadeinterfaz()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void vistadeinterfaz_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string usuario = textBox1.Text;
            string contraseña = textBox2.Text;
            if(conexion.VerificarCredenciales(usuario,contraseña))
            {
                MessageBox.Show("Inicio de sesion exitoso");
                InterfazGerente formulario = new InterfazGerente();
                formulario.Show();
            }
            else
            {
                MessageBox.Show("Usuario incorrecto");
            }
            /*InterfazGerente Abrir = new InterfazGerente();
            Abrir.Show();*/
        }
    }
}
