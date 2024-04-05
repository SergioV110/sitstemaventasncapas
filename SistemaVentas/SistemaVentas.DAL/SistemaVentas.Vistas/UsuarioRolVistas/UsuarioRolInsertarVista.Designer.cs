namespace SistemaVentas.Vistas.UsuarioRolVistas
{
    partial class UsuarioRolInsertarVista
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
            buttonSelecUsuario = new Button();
            buttonSelecRol = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            label4 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 12F);
            label1.Location = new Point(39, 104);
            label1.Name = "label1";
            label1.Size = new Size(99, 25);
            label1.TabIndex = 0;
            label1.Text = "IDUSUARIO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Impact", 12F);
            label2.Location = new Point(39, 161);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 1;
            label2.Text = "IDROL";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Impact", 12F);
            label3.Location = new Point(39, 218);
            label3.Name = "label3";
            label3.Size = new Size(118, 25);
            label3.TabIndex = 2;
            label3.Tag = "";
            label3.Text = "FECHAASIGNA";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(167, 102);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(167, 159);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(167, 216);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 5;
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Font = new Font("Impact", 12F);
            button1.Location = new Point(226, 11);
            button1.Name = "button1";
            button1.Size = new Size(112, 37);
            button1.TabIndex = 6;
            button1.Text = "GUARDAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // buttonSelecUsuario
            // 
            buttonSelecUsuario.Font = new Font("Impact", 12F);
            buttonSelecUsuario.Location = new Point(324, 100);
            buttonSelecUsuario.Name = "buttonSelecUsuario";
            buttonSelecUsuario.Size = new Size(130, 29);
            buttonSelecUsuario.TabIndex = 7;
            buttonSelecUsuario.Text = "SELECCIONAR";
            buttonSelecUsuario.UseVisualStyleBackColor = true;
            buttonSelecUsuario.Click += buttonSelecUsuario_Click;
            // 
            // buttonSelecRol
            // 
            buttonSelecRol.Font = new Font("Impact", 12F);
            buttonSelecRol.Location = new Point(324, 159);
            buttonSelecRol.Name = "buttonSelecRol";
            buttonSelecRol.Size = new Size(130, 29);
            buttonSelecRol.TabIndex = 8;
            buttonSelecRol.Text = "SELECCIONAR";
            buttonSelecRol.UseVisualStyleBackColor = true;
            buttonSelecRol.Click += buttonSelecRol_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DimGray;
            panel1.Controls.Add(label4);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(559, 52);
            panel1.TabIndex = 9;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DimGray;
            panel2.Controls.Add(button1);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 301);
            panel2.Name = "panel2";
            panel2.Size = new Size(559, 60);
            panel2.TabIndex = 10;
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
            label4.Text = "INSERTAR ROL DE USUARIO";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UsuarioRolInsertarVista
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
            Name = "UsuarioRolInsertarVista";
            Text = "UsuarioRolInsertarVista";
            Load += UsuarioRolInsertarVista_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private DateTimePicker dateTimePicker1;
        private Button button1;
        private Button buttonSelecUsuario;
        private Button buttonSelecRol;
        private Panel panel1;
        private Panel panel2;
        private Label label4;
    }
}