using GoodsFlow.Catppuccin.Components;

namespace GoodsFlow.Windows
{
    public partial class Dashboard : CatppuccinForm
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            if (Screen.PrimaryScreen is null) { return; }
            Width = Screen.PrimaryScreen.WorkingArea.Width / 2;
            Height = Screen.PrimaryScreen.WorkingArea.Height / 2;
            CenterToScreen();
        }
    }
}
