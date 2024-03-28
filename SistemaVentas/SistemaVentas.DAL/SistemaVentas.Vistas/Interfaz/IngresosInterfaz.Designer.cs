namespace SistemaVentas.Vistas.Interfaz
{
    partial class IngresosInterfaz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IngresosInterfaz));
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            button4 = new Button();
            pictureBox1 = new PictureBox();
            button3 = new Button();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(270, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(545, 468);
            dataGridView1.TabIndex = 10;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
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
            panel1.Size = new Size(270, 468);
            panel1.TabIndex = 9;
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
            // IngresosInterfaz
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(815, 468);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "IngresosInterfaz";
            Text = "IngresosInterfaz";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Panel panel1;
        private Button button4;
        private PictureBox pictureBox1;
        private Button button3;
        private Button button1;
        private Button button2;
    }
}