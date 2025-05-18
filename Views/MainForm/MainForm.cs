using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using pharmacy_sys.Models;
using pharmacy_sys.Presenters.MainPresenter;
using pharmacy_sys.Repositories.LogRepositories;
using pharmacy_sys.Repositories.UserRepositories;
using pharmacy_sys.Services.AuthServices;
using pharmacy_sys.Services.LogServices;
using pharmacy_sys.Views.BillForm;
using pharmacy_sys.Views.CategoryForm;
using pharmacy_sys.Views.ChangePasswordForm;
using pharmacy_sys.Views.DatabaseForm;
using pharmacy_sys.Views.LoginForm;
using pharmacy_sys.Views.LogsForm;
using pharmacy_sys.Views.MedicineForm;
using pharmacy_sys.Views.POSForm;
using pharmacy_sys.Views.ReportForm;
using pharmacy_sys.Views.SupplierForm;
using pharmacy_sys.Views.UtilsForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pharmacy_sys.Views.MainForm
{
    public partial class MainForm : Form, IMainView
    {
        private System.Windows.Forms.Timer timerClock;

        public event EventHandler LogOut;

        public MainForm()
        {
            InitializeComponent();
            var logRepository = new LogRepository();
            var userRepository = new UserRepository();

            var logService = new LogService(logRepository);

            var authService = new AuthService(userRepository, logService);

            new MainPresenter(this, authService);
            CheckDatabaseConnection();
            // check admin permission
            if (UserSession.Role != UserRole.Admin)
            {
                btnLogs.Visible = false;
                btnDatabase.Visible = false;
                btnMedicines.Visible = false;
                btnCategory.Visible = false;
                btnSuppliers.Visible = false;
            }

            txtFullName.Text = $"Xin chào {(UserSession.Role == UserRole.Admin ? "Quản trị viên" : "Nhân viên")} - {UserSession.FullName}";

            timerClock = new System.Windows.Forms.Timer
            {
                Interval = 1000 // mỗi 1 giây
            };
            timerClock.Tick += TimerClock_Tick;
            timerClock.Start();
            IntroductionView introductionView = new IntroductionView();
            AddControls(introductionView);

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void AddControls(Form form)
        {
            panelMain.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.TopLevel = false;
            panelMain.Controls.Add(form);
            form.Show();
        }

        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            SupplierView supplierForm = new SupplierView();
            AddControls(supplierForm);

        }

        private void btnMedicines_Click(object sender, EventArgs e)
        {
            MedicineManagementView medicineForm = new MedicineManagementView();
            AddControls(medicineForm);
        }


        private void btnCategory_Click(object sender, EventArgs e)
        {
            CategoryView categoryView = new CategoryView();
            AddControls(categoryView);
        }

        private void TimerClock_Tick(object sender, EventArgs e)
        {
            lblTime.Text = "🕒 " + DateTime.Now.ToString("HH:mm:ss dd/MM/yyyy");
        }

        private void CheckDatabaseConnection()
        {
            try
            {

                using (var context = new PharmacyDbContext())
                {
                    if (context.Database.CanConnect())
                    {
                        lblConnection.Text = "🟢 Đã kết nối CSDL";
                        lblConnection.ForeColor = Color.Green;
                    }
                    else
                    {
                        lblConnection.Text = "⛔ Mất kết nối CSDL";
                        lblConnection.ForeColor = Color.Red;
                    }
                }
            }
            catch (Exception)
            {
                lblConnection.Text = "⛔ Mất kết nối CSDL";
                lblConnection.ForeColor = Color.Red;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }
            Application.Exit();
        }

        private void btnAddMedicineView_Click(object sender, EventArgs e)
        {
            AddMedicineView addMedicineView = new AddMedicineView();
            addMedicineView.ShowDialog();
        }

        private void btnIntroductionView_Click(object sender, EventArgs e)
        {
            IntroductionView introductionView = new IntroductionView();
            AddControls(introductionView);
        }

        private void btnPOSView_Click(object sender, EventArgs e)
        {
            POSView posView = new POSView();
            AddControls(posView);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LogOut?.Invoke(this, EventArgs.Empty);
        }

        private void btnBills_Click(object sender, EventArgs e)
        {
            BillsView billsView = new BillsView();
            AddControls(billsView);
        }

        public void ShowLoginPage()
        {
            LoginView loginView = new LoginView();
            loginView.Show();
            this.Hide();
        }

        private void btnLogs_Click(object sender, EventArgs e)
        {
            LogsView logsView = new LogsView();
            AddControls(logsView);
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            SalesReportView salesReport = new SalesReportView();
            AddControls(salesReport);
        }

        private void btnDatabase_Click(object sender, EventArgs e)
        {
            DatabaseView databaseView = new DatabaseView();
            databaseView.ShowDialog();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            ChangePasswordView changePasswordView = new ChangePasswordView();
            changePasswordView.ShowDialog();
        }

        private void btnInfoSoftware_Click(object sender, EventArgs e)
        {
            InfoSoftware infoSoftware = new InfoSoftware();
            AddControls(infoSoftware);
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            InventoryView inventoryView = new InventoryView();
            AddControls(inventoryView);
        }
    }
}
