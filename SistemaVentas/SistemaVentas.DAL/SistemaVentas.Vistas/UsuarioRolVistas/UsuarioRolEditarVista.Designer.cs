namespace SistemaVentas.Vistas.UsuarioRolVistas
{
    partial class UsuarioRolEditarVista
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
            panel2 = new Panel();
            buttonGuardar = new Button();
            panel1 = new Panel();
            label4 = new Label();
            buttonSelecRol = new Button();
            buttonSelecUsuario = new Button();
            dateTimePicker1 = new DateTimePicker();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.DimGray;
            panel2.Controls.Add(buttonGuardar);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 301);
            panel2.Name = "panel2";
            panel2.Size = new Size(559, 60);
            panel2.TabIndex = 20;
            // 
            // buttonGuardar
            // 
            buttonGuardar.DialogResult = DialogResult.OK;
            buttonGuardar.Font = new Font("Impact", 12F);
            buttonGuardar.Location = new Point(226, 11);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(112, 37);
            buttonGuardar.TabIndex = 6;
            buttonGuardar.Text = "GUARDAR";
            buttonGuardar.UseVisualStyleBackColor = true;
            buttonGuardar.Click += buttonGuardar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DimGray;
            panel1.Controls.Add(label4);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(559, 52);
            panel1.TabIndex = 19;
            // 
            // label4
            // 
            label4.Dock = DockStyle.Top;
            label4.Font = new Font("Impact", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(559, 52);
            label4.TabIndex = 0;
            label4.Text = "EDITAR ROL DE USUARIO";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonSelecRol
            // 
            buttonSelecRol.Font = new Font("Impact", 12F);
            buttonSelecRol.Location = new Point(324, 159);
            buttonSelecRol.Name = "buttonSelecRol";
            buttonSelecRol.Size = new Size(130, 29);
            buttonSelecRol.TabIndex = 18;
            buttonSelecRol.Text = "SELECCIONAR";
            buttonSelecRol.UseVisualStyleBackColor = true;
            buttonSelecRol.Click += buttonSelecRol_Click;
            // 
            // buttonSelecUsuario
            // 
            buttonSelecUsuario.Font = new Font("Impact", 12F);
            buttonSelecUsuario.Location = new Point(324, 100);
            buttonSelecUsuario.Name = "buttonSelecUsuario";
            buttonSelecUsuario.Size = new Size(130, 29);
            buttonSelecUsuario.TabIndex = 17;
            buttonSelecUsuario.Text = "SELECCIONAR";
            buttonSelecUsuario.UseVisualStyleBackColor = true;
            buttonSelecUsuario.Click += buttonSelecUsuario_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(167, 216);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 16;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(167, 159);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 15;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(167, 102);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Impact", 12F);
            label3.Location = new Point(39, 218);
            label3.Name = "label3";
            label3.Size = new Size(118, 25);
            label3.TabIndex = 13;
            label3.Tag = "";
            label3.Text = "FECHAASIGNA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Impact", 12F);
            label2.Location = new Point(39, 161);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 12;
            label2.Text = "IDROL";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 12F);
            label1.Location = new Point(39, 104);
            label1.Name = "label1";
            label1.Size = new Size(99, 25);
            label1.TabIndex = 11;
            label1.Text = "IDUSUARIO";
            // 
            // UsuarioRolEditarVista
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(559, 361);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(buttonSelecRol);
            Controls.Add(buttonSelecUsuario);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UsuarioRolEditarVista";
            Text = "UsuarioRolEditarVista";
            Load += UsuarioRolEditarVista_Load;
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Button buttonGuardar;
        private Panel panel1;
        private Label label4;
        private Button buttonSelecRol;
        private Button buttonSelecUsuario;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}