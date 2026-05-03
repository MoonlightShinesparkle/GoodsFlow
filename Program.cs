using GoodsFlow.Windows;
using System.Diagnostics;
using GoodsFlow.Data.DataStore;

namespace GoodsFlow
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static async Task Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            SplashScreen Splash = new();
            Splash.Show();
            Stopwatch Timer = Stopwatch.StartNew();
            await SQLDSS.InitializeConnection();
            Splash.LoadData();

            while ((Timer.ElapsedMilliseconds < 2000) || !Splash.Loaded)
            {
                Application.DoEvents(); // <--- linea para que se muestre el splash
            }

            Splash.Close();
            Timer.Stop();
            //perdon moon lo cambie para trabajar jeje
            Application.Run(new login());
        }
    }
}