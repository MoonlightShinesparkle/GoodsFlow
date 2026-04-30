namespace GoodsFlow.Windows
{
    partial class login
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
            UserIn = new GoodsFlow.Catppuccin.Components.CatppuccinTextBox();
            PasswordIn = new GoodsFlow.Catppuccin.Components.CatppuccinTextBox();
            catppuccinLabel1 = new GoodsFlow.Catppuccin.Components.CatppuccinLabel();
            catppuccinLabel2 = new GoodsFlow.Catppuccin.Components.CatppuccinLabel();
            catppuccinLabel3 = new GoodsFlow.Catppuccin.Components.CatppuccinLabel();
            catppuccinLabel4 = new GoodsFlow.Catppuccin.Components.CatppuccinLabel();
            LoginBtn = new GoodsFlow.Catppuccin.Components.CatppuccinButton();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            catppuccinLabel5 = new GoodsFlow.Catppuccin.Components.CatppuccinLabel();
            StoreIn = new GoodsFlow.Catppuccin.Components.CatppuccinTextBox();
            CreateBtn = new GoodsFlow.Catppuccin.Components.CatppuccinButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // UserIn
            // 
            UserIn.BackColor = Color.FromArgb(204, 208, 218);
            UserIn.BackgroundColor = Catppuccin.CatppuccinColor.Surface0;
            UserIn.ForeColor = Color.FromArgb(64, 160, 43);
            UserIn.ForegroundColor = Catppuccin.CatppuccinColor.Green;
            UserIn.Location = new Point(666, 447);
            UserIn.Margin = new Padding(5);
            UserIn.Name = "UserIn";
            UserIn.Size = new Size(820, 39);
            UserIn.TabIndex = 0;
            // 
            // PasswordIn
            // 
            PasswordIn.BackColor = Color.FromArgb(204, 208, 218);
            PasswordIn.BackgroundColor = Catppuccin.CatppuccinColor.Surface0;
            PasswordIn.ForeColor = Color.FromArgb(64, 160, 43);
            PasswordIn.ForegroundColor = Catppuccin.CatppuccinColor.Green;
            PasswordIn.Location = new Point(666, 612);
            PasswordIn.Margin = new Padding(5);
            PasswordIn.Name = "PasswordIn";
            PasswordIn.PasswordChar = '*';
            PasswordIn.Size = new Size(820, 39);
            PasswordIn.TabIndex = 1;
            PasswordIn.UseSystemPasswordChar = true;
            // 
            // catppuccinLabel1
            // 
            catppuccinLabel1.AutoSize = true;
            catppuccinLabel1.BackColor = Color.Transparent;
            catppuccinLabel1.BackgroundColor = Catppuccin.CatppuccinColor.Transparent;
            catppuccinLabel1.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            catppuccinLabel1.ForeColor = Color.FromArgb(76, 79, 105);
            catppuccinLabel1.ForegroundColor = Catppuccin.CatppuccinColor.Text;
            catppuccinLabel1.Location = new Point(600, 98);
            catppuccinLabel1.Margin = new Padding(5, 0, 5, 0);
            catppuccinLabel1.Name = "catppuccinLabel1";
            catppuccinLabel1.Size = new Size(504, 47);
            catppuccinLabel1.TabIndex = 2;
            catppuccinLabel1.Text = "Bienvenido al inicio de sesión";
            // 
            // catppuccinLabel2
            // 
            catppuccinLabel2.AutoSize = true;
            catppuccinLabel2.BackColor = Color.Transparent;
            catppuccinLabel2.BackgroundColor = Catppuccin.CatppuccinColor.Transparent;
            catppuccinLabel2.ForeColor = Color.FromArgb(76, 79, 105);
            catppuccinLabel2.ForegroundColor = Catppuccin.CatppuccinColor.Text;
            catppuccinLabel2.Location = new Point(600, 176);
            catppuccinLabel2.Margin = new Padding(5, 0, 5, 0);
            catppuccinLabel2.Name = "catppuccinLabel2";
            catppuccinLabel2.Size = new Size(886, 32);
            catppuccinLabel2.TabIndex = 3;
            catppuccinLabel2.Text = "No recuerdas tus datos de inicio de sesión? Envia un correo a xxxxxxx@gmail.com";
            // 
            // catppuccinLabel3
            // 
            catppuccinLabel3.AutoSize = true;
            catppuccinLabel3.BackColor = Color.Transparent;
            catppuccinLabel3.BackgroundColor = Catppuccin.CatppuccinColor.Transparent;
            catppuccinLabel3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            catppuccinLabel3.ForeColor = Color.FromArgb(76, 79, 105);
            catppuccinLabel3.ForegroundColor = Catppuccin.CatppuccinColor.Text;
            catppuccinLabel3.Location = new Point(600, 393);
            catppuccinLabel3.Margin = new Padding(5, 0, 5, 0);
            catppuccinLabel3.Name = "catppuccinLabel3";
            catppuccinLabel3.Size = new Size(109, 32);
            catppuccinLabel3.TabIndex = 4;
            catppuccinLabel3.Text = "Usuario:";
            // 
            // catppuccinLabel4
            // 
            catppuccinLabel4.AutoSize = true;
            catppuccinLabel4.BackColor = Color.Transparent;
            catppuccinLabel4.BackgroundColor = Catppuccin.CatppuccinColor.Transparent;
            catppuccinLabel4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            catppuccinLabel4.ForeColor = Color.FromArgb(76, 79, 105);
            catppuccinLabel4.ForegroundColor = Catppuccin.CatppuccinColor.Text;
            catppuccinLabel4.Location = new Point(600, 556);
            catppuccinLabel4.Margin = new Padding(5, 0, 5, 0);
            catppuccinLabel4.Name = "catppuccinLabel4";
            catppuccinLabel4.Size = new Size(150, 32);
            catppuccinLabel4.TabIndex = 5;
            catppuccinLabel4.Text = "Contraseña:";
            // 
            // LoginBtn
            // 
            LoginBtn.BackColor = Color.FromArgb(204, 208, 218);
            LoginBtn.BackgroundColor = Catppuccin.CatppuccinColor.Surface0;
            LoginBtn.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            LoginBtn.ForeColor = Color.FromArgb(32, 159, 181);
            LoginBtn.ForegroundColor = Catppuccin.CatppuccinColor.Sapphire;
            LoginBtn.Location = new Point(600, 722);
            LoginBtn.Margin = new Padding(5);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(433, 93);
            LoginBtn.TabIndex = 6;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.carrito;
            pictureBox1.Location = new Point(2, 157);
            pictureBox1.Margin = new Padding(5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(559, 494);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.fondo_;
            pictureBox2.Location = new Point(2, 854);
            pictureBox2.Margin = new Padding(5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1701, 99);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // catppuccinLabel5
            // 
            catppuccinLabel5.AutoSize = true;
            catppuccinLabel5.BackColor = Color.Transparent;
            catppuccinLabel5.BackgroundColor = Catppuccin.CatppuccinColor.Transparent;
            catppuccinLabel5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            catppuccinLabel5.ForeColor = Color.FromArgb(76, 79, 105);
            catppuccinLabel5.ForegroundColor = Catppuccin.CatppuccinColor.Text;
            catppuccinLabel5.Location = new Point(600, 222);
            catppuccinLabel5.Margin = new Padding(5, 0, 5, 0);
            catppuccinLabel5.Name = "catppuccinLabel5";
            catppuccinLabel5.Size = new Size(98, 32);
            catppuccinLabel5.TabIndex = 10;
            catppuccinLabel5.Text = "Tienda:";
            // 
            // StoreIn
            // 
            StoreIn.BackColor = Color.FromArgb(204, 208, 218);
            StoreIn.BackgroundColor = Catppuccin.CatppuccinColor.Surface0;
            StoreIn.ForeColor = Color.FromArgb(64, 160, 43);
            StoreIn.ForegroundColor = Catppuccin.CatppuccinColor.Green;
            StoreIn.Location = new Point(666, 276);
            StoreIn.Margin = new Padding(5);
            StoreIn.Name = "StoreIn";
            StoreIn.Size = new Size(820, 39);
            StoreIn.TabIndex = 9;
            // 
            // CreateBtn
            // 
            CreateBtn.BackColor = Color.FromArgb(204, 208, 218);
            CreateBtn.BackgroundColor = Catppuccin.CatppuccinColor.Surface0;
            CreateBtn.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            CreateBtn.ForeColor = Color.FromArgb(114, 135, 253);
            CreateBtn.ForegroundColor = Catppuccin.CatppuccinColor.Lavender;
            CreateBtn.Location = new Point(1069, 722);
            CreateBtn.Margin = new Padding(5);
            CreateBtn.Name = "CreateBtn";
            CreateBtn.Size = new Size(417, 93);
            CreateBtn.TabIndex = 11;
            CreateBtn.Text = "Crear nueva tienda";
            CreateBtn.UseVisualStyleBackColor = false;
            CreateBtn.Click += CreateBtn_Click;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1540, 944);
            Controls.Add(CreateBtn);
            Controls.Add(catppuccinLabel5);
            Controls.Add(StoreIn);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(LoginBtn);
            Controls.Add(catppuccinLabel4);
            Controls.Add(catppuccinLabel3);
            Controls.Add(catppuccinLabel2);
            Controls.Add(catppuccinLabel1);
            Controls.Add(PasswordIn);
            Controls.Add(UserIn);
            Margin = new Padding(5);
            Name = "login";
            Text = "MicroVentas";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Catppuccin.Components.CatppuccinTextBox UserIn;
        private Catppuccin.Components.CatppuccinTextBox PasswordIn;
        private Catppuccin.Components.CatppuccinLabel catppuccinLabel1;
        private Catppuccin.Components.CatppuccinLabel catppuccinLabel2;
        private Catppuccin.Components.CatppuccinLabel catppuccinLabel3;
        private Catppuccin.Components.CatppuccinLabel catppuccinLabel4;
        private Catppuccin.Components.CatppuccinButton LoginBtn;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Catppuccin.Components.CatppuccinLabel catppuccinLabel5;
        private Catppuccin.Components.CatppuccinTextBox StoreIn;
        private Catppuccin.Components.CatppuccinButton CreateBtn;
    }
}