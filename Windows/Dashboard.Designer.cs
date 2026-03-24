namespace GoodsFlow.Windows
{
    partial class Dashboard
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
            catppuccinTextBox2 = new GoodsFlow.Catppuccin.Components.CatppuccinTextBox();
            SuspendLayout();
            // 
            // catppuccinTextBox1
            // 
            catppuccinTextBox1.BackColor = Color.FromArgb(239, 241, 245);
            catppuccinTextBox1.BackgroundColor = Catppuccin.CatppuccinColor.Surface0;
            catppuccinTextBox1.ForeColor = Color.FromArgb(114, 135, 253);
            catppuccinTextBox1.ForegroundColor = Catppuccin.CatppuccinColor.Lavender;
            catppuccinTextBox1.Location = new Point(1506, 995);
            catppuccinTextBox1.Name = "catppuccinTextBox1";
            catppuccinTextBox1.Size = new Size(200, 39);
            catppuccinTextBox1.TabIndex = 0;
            catppuccinTextBox1.Text = "Meow";
            // 
            // catppuccinTextBox2
            // 
            catppuccinTextBox2.BackColor = Color.FromArgb(239, 241, 245);
            catppuccinTextBox2.BackgroundColor = Catppuccin.CatppuccinColor.Surface0;
            catppuccinTextBox2.ForeColor = Color.FromArgb(114, 135, 253);
            catppuccinTextBox2.ForegroundColor = Catppuccin.CatppuccinColor.Lavender;
            catppuccinTextBox2.Location = new Point(327, 995);
            catppuccinTextBox2.Name = "catppuccinTextBox2";
            catppuccinTextBox2.Size = new Size(200, 39);
            catppuccinTextBox2.TabIndex = 1;
            catppuccinTextBox2.Text = "Meow";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1718, 1046);
            Controls.Add(catppuccinTextBox2);
            Controls.Add(catppuccinTextBox1);
            Name = "Dashboard";
            Text = "Form1";
            Load += Dashboard_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Catppuccin.Components.CatppuccinTextBox catppuccinTextBox1;
        private Catppuccin.Components.CatppuccinTextBox catppuccinTextBox2;
    }
}