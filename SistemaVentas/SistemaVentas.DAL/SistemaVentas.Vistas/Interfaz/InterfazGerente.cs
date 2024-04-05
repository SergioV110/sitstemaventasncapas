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
using SistemaVentas.Vistas.RolVistas;
using SistemaVentas.Vistas.TipoProdVistas;
using SistemaVentas.Vistas.PersonaVistas;
using SistemaVentas.Vistas.PersonasVistas;
using SistemaVentas.Vistas.MarcaVistas;
using SistemaVentas.Vistas.ProveedorVistas;
using SistemaVentas.Vistas.UsuarioVistas;
using SistemaVentas.Vistas.ClienteVistas;
using SistemaVentas.Vistas.DetalleIngVistas;
using SistemaVentas.Vistas.DetalleVentaVistas;
using SistemaVentas.Vistas.IngresoVistas;
using SistemaVentas.Vistas.ProductoVistas;
using SistemaVentas.Vistas.ProveeVistas;
using SistemaVentas.Vistas.VentaVistas;
using SistemaVentas.Vistas.UsuarioRolVistas;



namespace SistemaVentas.Vistas.Interfaz
{
    public partial class InterfazGerente : Form
    {
        public InterfazGerente()
        {
            InitializeComponent();
        }
        private Form activeform = null;
        private void abrirformulariohijo(Form hijo)
        {
            if (activeform != null)
                activeform.Close();
            activeform = hijo;
            hijo.TopLevel = false;
            hijo.FormBorderStyle = FormBorderStyle.None;
            hijo.Dock = DockStyle.Fill;
            panelHIJO.Controls.Add(hijo);
            panelHIJO.Tag = hijo;
            hijo.BringToFront();
            hijo.Show();
        }
        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //UsuarioBss bss = new UsuarioBss();
            //dataGridView1.DataSource = bss.UsuarioDatosBss();
            abrirformulariohijo(new UsuarioListarVista());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //ProveedorBss bss = new ProveedorBss();
            //dataGridView1.DataSource = bss.ListarProveedorBss();
            abrirformulariohijo(new ProveedorListarVista());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            abrirformulariohijo(new IngresoListarVista());
            //IngresoBss bss = new IngresoBss();
            //dataGridView1.DataSource = bss.IngresoDatosBss();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            abrirformulariohijo(new ProductoListarVista());
            //ProductoBss bss = new ProductoBss();
            //dataGridView1.DataSource = bss.ProductoDatosBss();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            abrirformulariohijo(new DetalleVentaListarVista());
            //DetalleVentaBss bss = new DetalleVentaBss();
            //dataGridView1.DataSource = bss.DetalleVentaDatosBss();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            abrirformulariohijo(new VentaListarVista());
            //VentaBss bss = new VentaBss();
            //dataGridView1.DataSource = bss.VentaDatosBss();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            PersonaBss bss = new PersonaBss();
            //dataGridView1.DataSource = bss.ListarPersonaBss();
            abrirformulariohijo(new PersonaListarVista());
        }

        private void button10_Click(object sender, EventArgs e)
        {
            RolBss bss = new RolBss();
            //dataGridView1.DataSource = bss.ListarRolBss();
            abrirformulariohijo(new RolListarVista());
        }

        private void button11_Click(object sender, EventArgs e)
        {
            TipoProdBss bss = new TipoProdBss();
            //dataGridView1.DataSource = bss.ListarTipoProdBss();
            abrirformulariohijo(new TipoProdListarVista());
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //MarcaBss bss = new MarcaBss();
            //dataGridView1.DataSource = bss.ListarMarcaBss();
            abrirformulariohijo(new MarcaListarVista());
        }

        private void button13_Click(object sender, EventArgs e)
        {
            abrirformulariohijo(new UsuarioRolListarVista());
            //UsuarioRolBss bss = new UsuarioRolBss();
            //dataGridView1.DataSource = bss.UsuarioRolDatosBss();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            abrirformulariohijo(new ClienteListarVista());
            //ClienteBss bss = new ClienteBss();
            //dataGridView1.DataSource = bss.ClienteDatosBss();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            abrirformulariohijo(new ProveeListarVista());
            //ProveeBss bss = new ProveeBss();
            //dataGridView1.DataSource = bss.ProveeDatosBss();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            abrirformulariohijo(new DetalleIngListarVista());
            //DetalleIngBss bss = new DetalleIngBss();
            //dataGridView1.DataSource = bss.DetalleIngDatosBss();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
