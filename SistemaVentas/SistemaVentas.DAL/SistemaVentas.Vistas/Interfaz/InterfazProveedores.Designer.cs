namespace SistemaVentas.Vistas.Interfaz
{
    partial class InterfazProveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InterfazProveedores));
            button6 = new Button();
            button5 = new Button();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            button4 = new Button();
            pictureBox1 = new PictureBox();
            button3 = new Button();
            button1 = new Button();
            button2 = new Button();
            button7 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button6
            // 
            button6.BackColor = Color.DimGray;
            button6.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold);
            button6.ForeColor = SystemColors.ButtonHighlight;
            button6.Location = new Point(672, 428);
            button6.Name = "button6";
            button6.Size = new Size(133, 41);
            button6.TabIndex = 7;
            button6.Text = "Eliminar";
            button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.DimGray;
            button5.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold);
            button5.ForeColor = SystemColors.ButtonHighlight;
            button5.Location = new Point(280, 428);
            button5.Name = "button5";
            button5.Size = new Size(133, 41);
            button5.TabIndex = 6;
            button5.Text = "Editar";
            button5.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Top;
            dataGridView1.Location = new Point(270, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(545, 410);
            dataGridView1.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DimGray;
            panel1.Controls.Add(button4);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(270, 477);
            panel1.TabIndex = 4;
            // 
            // button4
            // 
            button4.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold);
            button4.Location = new Point(21, 394);
            button4.Name = "button4";
            button4.Size = new Size(231, 45);
            button4.TabIndex = 4;
            button4.Text = "Productos";
            button4.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(79, 38);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 109);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // button3
            // 
            button3.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold);
            button3.Location = new Point(21, 326);
            button3.Name = "button3";
            button3.Size = new Size(231, 45);
            button3.TabIndex = 3;
            button3.Text = "Ingresos";
            button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold);
            button1.Location = new Point(21, 190);
            button1.Name = "button1";
            button1.Size = new Size(231, 45);
            button1.TabIndex = 1;
            button1.Text = "Usuarios";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold);
            button2.Location = new Point(21, 258);
            button2.Name = "button2";
            button2.Size = new Size(231, 45);
            button2.TabIndex = 2;
            button2.Text = "Proveedores";
            button2.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.BackColor = Color.DimGray;
            button7.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.ForeColor = SystemColors.ButtonHighlight;
            button7.Location = new Point(490, 428);
            button7.Name = "button7";
            button7.Size = new Size(104, 41);
            button7.TabIndex = 8;
            button7.Text = "Añadir\r\n";
            button7.UseVisualStyleBackColor = false;
            // 
            // InterfazProveedores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(815, 477);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "InterfazProveedores";
            Text = "InterfazProveedores";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button6;
        private Button button5;
        private DataGridView dataGridView1;
        private Panel panel1;
        private Button button4;
        private PictureBox pictureBox1;
        private Button button3;
        private Button button1;
        private Button button2;
        private Button button7;
    }
}