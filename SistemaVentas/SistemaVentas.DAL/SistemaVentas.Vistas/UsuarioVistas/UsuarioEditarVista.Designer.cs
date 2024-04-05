namespace SistemaVentas.Vistas.UsuarioVistas
{
    partial class UsuarioEditarVista
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
            label5 = new Label();
            buttonSeleccionado = new Button();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            textBox1 = new TextBox();
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
            panel2.Location = new Point(0, 390);
            panel2.Name = "panel2";
            panel2.Size = new Size(514, 60);
            panel2.TabIndex = 22;
            // 
            // buttonGuardar
            // 
            buttonGuardar.DialogResult = DialogResult.OK;
            buttonGuardar.Font = new Font("Impact", 12F);
            buttonGuardar.Location = new Point(211, 16);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(106, 32);
            buttonGuardar.TabIndex = 0;
            buttonGuardar.Text = "GUARDAR";
            buttonGuardar.UseVisualStyleBackColor = true;
            buttonGuardar.Click += buttonGuardar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DimGray;
            panel1.Controls.Add(label5);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(514, 60);
            panel1.TabIndex = 21;
            // 
            // label5
            // 
            label5.Dock = DockStyle.Top;
            label5.Font = new Font("Impact", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(514, 60);
            label5.TabIndex = 0;
            label5.Text = "EDITAR USUARIO";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonSeleccionado
            // 
            buttonSeleccionado.Font = new Font("Impact", 12F);
            buttonSeleccionado.Location = new Point(347, 100);
            buttonSeleccionado.Name = "buttonSeleccionado";
            buttonSeleccionado.Size = new Size(135, 29);
            buttonSeleccionado.TabIndex = 20;
            buttonSeleccionado.Text = "SELECCIONAR";
            buttonSeleccionado.UseVisualStyleBackColor = true;
            buttonSeleccionado.Click += buttonSeleccionado_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(171, 216);
            textBox3.Name = "textBox3";
            textBox3.PasswordChar = '#';
            textBox3.Size = new Size(311, 27);
            textBox3.TabIndex = 19;
            textBox3.UseSystemPasswordChar = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(171, 158);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(311, 27);
            textBox2.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Impact", 12F);
            label4.Location = new Point(24, 276);
            label4.Name = "label4";
            label4.Size = new Size(90, 25);
            label4.TabIndex = 17;
            label4.Text = "FECHAREG";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Impact", 12F);
            label3.Location = new Point(24, 218);
            label3.Name = "label3";
            label3.Size = new Size(114, 25);
            label3.TabIndex = 16;
            label3.Text = "CONTRASEÑA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Impact", 12F);
            label2.Location = new Point(24, 160);
            label2.Name = "label2";
            label2.Size = new Size(118, 25);
            label2.TabIndex = 15;
            label2.Text = "NOMBREUSER";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(171, 274);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(311, 27);
            dateTimePicker1.TabIndex = 14;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(171, 100);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(156, 27);
            textBox1.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 12F);
            label1.Location = new Point(24, 102);
            label1.Name = "label1";
            label1.Size = new Size(100, 25);
            label1.TabIndex = 12;
            label1.Text = "IDPERSONA";
            // 
            // UsuarioEditarVista
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(514, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(buttonSeleccionado);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "UsuarioEditarVista";
            Text = "UsuarioEditarVista";
            Load += UsuarioEditarVista_Load;
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Button buttonGuardar;
        private Panel panel1;
        private Label label5;
        private Button buttonSeleccionado;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label label4;
        private Label label3;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox1;
        private Label label1;
    }
}