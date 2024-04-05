using SistemaVentas.BSS;
using SistemaVentas.Vistas.RolVistas;
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
    public partial class UsuarioRolListarVista : Form
    {
        public UsuarioRolListarVista()
        {
            InitializeComponent();
        }
        UsuarioRolBss bss = new UsuarioRolBss();
        private void UsuarioRolListarVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarUsuarioRolBss();
        }

        private void buttonInsertar_Click(object sender, EventArgs e)
        {
            UsuarioRolInsertarVista fr = new UsuarioRolInsertarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarUsuarioRolBss();
            }
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            int idUsuarioRolSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            UsuarioRolEditarVista fr = new UsuarioRolEditarVista(idUsuarioRolSeleccionado);
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarUsuarioRolBss();
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            int IdUsuarioRolSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DialogResult result = MessageBox.Show("Esta segura de eliminar esta persona", "cd", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                bss.EliminarUsuarioRolBss(IdUsuarioRolSeleccionado);
                dataGridView1.DataSource = bss.ListarUsuarioRolBss();
            }
        }
    }
}
