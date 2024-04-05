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
    public partial class SesionVendedor : Form
    {
        public SesionVendedor()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string usuario = textBox1.Text;
            string contraseña = textBox2.Text;
            string rol = "administrador"; // Asigna el rol según tu lógica de negocio

            if (conexion.VerificarCredenciales(usuario, contraseña))
            {
                
                MessageBox.Show("inicio de session exitoso");
                InterfazVendedor formulario = new InterfazVendedor();
                formulario.Show();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña son incorrectos");
            }
        }
    }
}
