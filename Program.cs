using System.Runtime.InteropServices;

namespace WinFormsApp
{
    internal static class Program
    {
        [DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            SetProcessDPIAware();
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}