namespace SistemaVentas.Vistas.UsuarioVistas
{
    partial class UsuarioListarVista
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            buttonSeleccionar = new Button();
            buttonEliminar = new Button();
            buttonEditar = new Button();
            buttonInsertar = new Button();
            panel2 = new Panel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 51);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(827, 359);
            dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(97, 71, 46);
            panel1.Controls.Add(buttonSeleccionar);
            panel1.Controls.Add(buttonEliminar);
            panel1.Controls.Add(buttonEditar);
            panel1.Controls.Add(buttonInsertar);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 416);
            panel1.Name = "panel1";
            panel1.Size = new Size(827, 77);
            panel1.TabIndex = 2;
            // 
            // buttonSeleccionar
            // 
            buttonSeleccionar.DialogResult = DialogResult.OK;
            buttonSeleccionar.Font = new Font("Impact", 16.2F);
            buttonSeleccionar.Location = new Point(627, 19);
            buttonSeleccionar.Name = "buttonSeleccionar";
            buttonSeleccionar.Size = new Size(173, 44);
            buttonSeleccionar.TabIndex = 3;
            buttonSeleccionar.Text = "SELECCIONAR";
            buttonSeleccionar.UseVisualStyleBackColor = true;
            buttonSeleccionar.Click += buttonSeleccionar_Click;
            // 
            // buttonEliminar
            // 
            buttonEliminar.Font = new Font("Impact", 16.2F);
            buttonEliminar.Location = new Point(427, 19);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(147, 44);
            buttonEliminar.TabIndex = 2;
            buttonEliminar.Text = "ELIMINAR";
            buttonEliminar.UseVisualStyleBackColor = true;
            buttonEliminar.Click += buttonEliminar_Click;
            // 
            // buttonEditar
            // 
            buttonEditar.Font = new Font("Impact", 16.2F);
            buttonEditar.Location = new Point(232, 19);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(142, 44);
            buttonEditar.TabIndex = 1;
            buttonEditar.Text = "EDITAR";
            buttonEditar.UseVisualStyleBackColor = true;
            buttonEditar.Click += buttonEditar_Click;
            // 
            // buttonInsertar
            // 
            buttonInsertar.Font = new Font("Impact", 16.2F);
            buttonInsertar.Location = new Point(32, 19);
            buttonInsertar.Name = "buttonInsertar";
            buttonInsertar.Size = new Size(147, 44);
            buttonInsertar.TabIndex = 0;
            buttonInsertar.Text = "INSERTAR";
            buttonInsertar.UseVisualStyleBackColor = true;
            buttonInsertar.Click += buttonInsertar_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DimGray;
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(827, 52);
            panel2.TabIndex = 3;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Impact", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(827, 52);
            label1.TabIndex = 0;
            label1.Text = "LISTA DE USUARIOS";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UsuarioListarVista
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(827, 493);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Name = "UsuarioListarVista";
            Text = "UsuarioListarVista";
            Load += UsuarioListarVista_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Panel panel1;
        private Button buttonSeleccionar;
        private Button buttonEliminar;
        private Button buttonEditar;
        private Button buttonInsertar;
        private Panel panel2;
        private Label label1;
    }
}