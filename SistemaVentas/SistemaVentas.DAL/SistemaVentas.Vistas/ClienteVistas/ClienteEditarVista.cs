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
using SistemaVentas.Vistas.PersonasVistas;

namespace SistemaVentas.Vistas.ClienteVistas
{
    public partial class ClienteEditarVista : Form
    {
        int idcliente;
        Cliente cliente = new Cliente();
        ClienteBss bsscliente = new ClienteBss();

        public ClienteEditarVista(int idClienteSeleccionado)
        {
            idcliente = idClienteSeleccionado;
            InitializeComponent();
        }
        PersonaBss bss = new PersonaBss();
        private void buttonSeleccionar_Click(object sender, EventArgs e)
        {
            PersonaListarVista fr = new PersonaListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Persona persona = bss.ObtenerIdBss(IdPersonaSeleccionado);
                textBox1.Text = persona.Nombre + " " + persona.Apellido;
            }
        }
        public static int IdPersonaSeleccionado = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            cliente.IdPersona = IdPersonaSeleccionado;
            cliente.TipoCliente = textBox2.Text;
            cliente.CodigoCliente = textBox3.Text;

            bsscliente.EditarClienteBss(cliente);
            MessageBox.Show("El Cliente ha sido actualizado");

        }

        private void ClienteEditarVista_Load(object sender, EventArgs e)
        {
            cliente = bsscliente.ObtenerClienteIdBss(idcliente);
            textBox1.Text = IdPersonaSeleccionado.ToString();
            textBox2.Text = cliente.TipoCliente;
            textBox3.Text = cliente.CodigoCliente;
        }
    }
}
