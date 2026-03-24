using GoodsFlow.Windows;
using System.Diagnostics;

namespace GoodsFlow
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            SplashScreen Splash = new();
            Splash.Show();
            Stopwatch Timer = Stopwatch.StartNew();
            Splash.LoadData();

            while ((Timer.ElapsedMilliseconds < 2000) || !Splash.Loaded)
            {
            }

            Splash.Close();
            Timer.Stop();

            Application.Run(new Dashboard());
        }
    }
}