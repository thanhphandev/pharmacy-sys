using Microsoft.EntityFrameworkCore;
using pharmacy_sys.Models;
using pharmacy_sys.Views.LoginForm;
using pharmacy_sys.Views.MainForm;
using pharmacy_sys.Views.SupplierForm;

namespace pharmacy_sys
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
            Application.Run(new MainForm());
        }
    }
}