using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using pharmacy_sys.Models;
using pharmacy_sys.Views.CategoryForm;
using pharmacy_sys.Views.MedicineForm;
using pharmacy_sys.Views.POSForm;
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
    public partial class MainForm : Form
    {
        private System.Windows.Forms.Timer timerClock;
        public MainForm()
        {
            InitializeComponent();
            CheckDatabaseConnection();
            timerClock = new System.Windows.Forms.Timer
            {
                Interval = 1000 // mỗi 1 giây
            };
            timerClock.Tick += TimerClock_Tick;
            timerClock.Start();
            MedicineManagementView medicineForm = new MedicineManagementView();
            AddControls(medicineForm);
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
            Application.Exit();
        }

        private void btnAddMedicineView_Click(object sender, EventArgs e)
        {
            AddMedicineView addMedicineView = new AddMedicineView();
            addMedicineView.ShowDialog();
        }

        private void btnGuides_Click(object sender, EventArgs e)
        {

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
    }
}
