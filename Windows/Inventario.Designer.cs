namespace GoodsFlow.Windows
{
    partial class Inventario
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
            catppuccinTextBox1 = new GoodsFlow.Catppuccin.Components.CatppuccinTextBox();
            catppuccinLabel1 = new GoodsFlow.Catppuccin.Components.CatppuccinLabel();
            catppuccinDataGridView1 = new GoodsFlow.Catppuccin.Components.CatppuccinDataGridView();
            ID = new DataGridViewTextBoxColumn();
            Producto = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Marca = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            catppuccinLabel2 = new GoodsFlow.Catppuccin.Components.CatppuccinLabel();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)catppuccinDataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // catppuccinTextBox1
            // 
            catppuccinTextBox1.BackColor = Color.FromArgb(204, 208, 218);
            catppuccinTextBox1.BackgroundColor = Catppuccin.CatppuccinColor.Surface0;
            catppuccinTextBox1.ForeColor = Color.FromArgb(64, 160, 43);
            catppuccinTextBox1.ForegroundColor = Catppuccin.CatppuccinColor.Green;
            catppuccinTextBox1.Location = new Point(47, 123);
            catppuccinTextBox1.Margin = new Padding(5, 5, 5, 5);
            catppuccinTextBox1.Name = "catppuccinTextBox1";
            catppuccinTextBox1.Size = new Size(1198, 39);
            catppuccinTextBox1.TabIndex = 0;
            // 
            // catppuccinLabel1
            // 
            catppuccinLabel1.AutoSize = true;
            catppuccinLabel1.BackColor = Color.Transparent;
            catppuccinLabel1.BackgroundColor = Catppuccin.CatppuccinColor.Transparent;
            catppuccinLabel1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            catppuccinLabel1.ForeColor = Color.FromArgb(30, 102, 245);
            catppuccinLabel1.ForegroundColor = Catppuccin.CatppuccinColor.Blue;
            catppuccinLabel1.Location = new Point(20, 14);
            catppuccinLabel1.Margin = new Padding(5, 0, 5, 0);
            catppuccinLabel1.Name = "catppuccinLabel1";
            catppuccinLabel1.Size = new Size(173, 45);
            catppuccinLabel1.TabIndex = 1;
            catppuccinLabel1.Text = "Inventario";
            // 
            // catppuccinDataGridView1
            // 
            catppuccinDataGridView1.BackgroundColor = Color.FromArgb(230, 233, 239);
            catppuccinDataGridView1.CBackgroundColor = Catppuccin.CatppuccinColor.Base;
            catppuccinDataGridView1.CGridColor = Catppuccin.CatppuccinColor.Crust;
            catppuccinDataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            catppuccinDataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, Producto, Cantidad, Precio, Marca, Categoria });
            catppuccinDataGridView1.DataBackgroundColor = Catppuccin.CatppuccinColor.Mantle;
            catppuccinDataGridView1.ForegroundColor = Catppuccin.CatppuccinColor.Sky;
            catppuccinDataGridView1.GridColor = Color.FromArgb(220, 224, 232);
            catppuccinDataGridView1.Location = new Point(47, 197);
            catppuccinDataGridView1.Margin = new Padding(5, 5, 5, 5);
            catppuccinDataGridView1.Name = "catppuccinDataGridView1";
            catppuccinDataGridView1.ReadOnly = true;
            catppuccinDataGridView1.RowHeadersWidth = 51;
            catppuccinDataGridView1.Size = new Size(1233, 427);
            catppuccinDataGridView1.TabIndex = 2;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Width = 125;
            // 
            // Producto
            // 
            Producto.HeaderText = "Producto";
            Producto.MinimumWidth = 6;
            Producto.Name = "Producto";
            Producto.ReadOnly = true;
            Producto.Width = 125;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.MinimumWidth = 6;
            Cantidad.Name = "Cantidad";
            Cantidad.ReadOnly = true;
            Cantidad.Width = 125;
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.MinimumWidth = 6;
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            Precio.Width = 125;
            // 
            // Marca
            // 
            Marca.HeaderText = "Marca";
            Marca.MinimumWidth = 6;
            Marca.Name = "Marca";
            Marca.ReadOnly = true;
            Marca.Width = 125;
            // 
            // Categoria
            // 
            Categoria.HeaderText = "Categoria";
            Categoria.MinimumWidth = 6;
            Categoria.Name = "Categoria";
            Categoria.ReadOnly = true;
            Categoria.Width = 125;
            // 
            // catppuccinLabel2
            // 
            catppuccinLabel2.AutoSize = true;
            catppuccinLabel2.BackColor = Color.Transparent;
            catppuccinLabel2.BackgroundColor = Catppuccin.CatppuccinColor.Transparent;
            catppuccinLabel2.ForeColor = Color.FromArgb(76, 79, 105);
            catppuccinLabel2.ForegroundColor = Catppuccin.CatppuccinColor.Text;
            catppuccinLabel2.Location = new Point(47, 86);
            catppuccinLabel2.Margin = new Padding(5, 0, 5, 0);
            catppuccinLabel2.Name = "catppuccinLabel2";
            catppuccinLabel2.Size = new Size(397, 32);
            catppuccinLabel2.TabIndex = 3;
            catppuccinLabel2.Text = "Consulta existencia en el inventario:";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.fondo_;
            pictureBox2.Location = new Point(-47, 634);
            pictureBox2.Margin = new Padding(5, 5, 5, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1701, 99);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // Inventario
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 720);
            Controls.Add(pictureBox2);
            Controls.Add(catppuccinLabel2);
            Controls.Add(catppuccinDataGridView1);
            Controls.Add(catppuccinLabel1);
            Controls.Add(catppuccinTextBox1);
            Margin = new Padding(5, 5, 5, 5);
            Name = "Inventario";
            Text = "Inventario";
            ((System.ComponentModel.ISupportInitialize)catppuccinDataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Catppuccin.Components.CatppuccinTextBox catppuccinTextBox1;
        private Catppuccin.Components.CatppuccinLabel catppuccinLabel1;
        private Catppuccin.Components.CatppuccinDataGridView catppuccinDataGridView1;
        private Catppuccin.Components.CatppuccinLabel catppuccinLabel2;
        private PictureBox pictureBox2;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Marca;
        private DataGridViewTextBoxColumn Categoria;
    }
}