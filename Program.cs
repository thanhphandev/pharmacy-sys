using Microsoft.EntityFrameworkCore;
using pharmacy_sys.Models;
using pharmacy_sys.Views.LoginForm;
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
            ApplicationConfiguration.Initialize();

            if (CanConnectToDatabase())
            {
                Application.Run(new LoginView());
            }
            else
            {
                MessageBox.Show("Không thể kết nối đến CSDL. Vui lòng kiểm tra cấu hình!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        static bool CanConnectToDatabase()
        {
            try
            {
                using var context = new PharmacyDbContext();
                return context.Database.CanConnect();
            }
            catch
            {
                return false;
            }
        }

    }
}