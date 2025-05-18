using System.Windows.Forms;

namespace pharmacy_sys.Views.MainForm
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            btnInfoSoftware = new ToolStripMenuItem();
            hóaĐơnToolStripMenuItem = new ToolStripMenuItem();
            btnIntroductionView = new ToolStripMenuItem();
            btnInventory = new ToolStripMenuItem();
            btnSales = new ToolStripMenuItem();
            btnReport = new ToolStripMenuItem();
            btnPOSView = new ToolStripMenuItem();
            nhàCungCấpToolStripMenuItem = new ToolStripMenuItem();
            btnCategory = new ToolStripMenuItem();
            btnSuppliers = new ToolStripMenuItem();
            btnMedicines = new ToolStripMenuItem();
            thuốcToolStripMenuItem = new ToolStripMenuItem();
            btnBills = new ToolStripMenuItem();
            btnExit = new ToolStripMenuItem();
            btnLogout = new ToolStripMenuItem();
            btnDatabase = new ToolStripMenuItem();
            btnChangePassword = new ToolStripMenuItem();
            tàiKhoảnToolStripMenuItem = new ToolStripMenuItem();
            btnLogs = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            panelMain = new Panel();
            statusStrip1 = new StatusStrip();
            txtFullName = new ToolStripStatusLabel();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            lblConnection = new ToolStripStatusLabel();
            lblTime = new ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnInfoSoftware
            // 
            btnInfoSoftware.Name = "btnInfoSoftware";
            btnInfoSoftware.Size = new Size(186, 22);
            btnInfoSoftware.Text = "Thông tin phần mềm";
            btnInfoSoftware.Click += btnInfoSoftware_Click;
            // 
            // hóaĐơnToolStripMenuItem
            // 
            hóaĐơnToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { btnIntroductionView, btnInfoSoftware });
            hóaĐơnToolStripMenuItem.Image = Properties.Resources.question__1_;
            hóaĐơnToolStripMenuItem.Name = "hóaĐơnToolStripMenuItem";
            hóaĐơnToolStripMenuItem.Size = new Size(78, 20);
            hóaĐơnToolStripMenuItem.Text = "Trợ giúp";
            // 
            // btnIntroductionView
            // 
            btnIntroductionView.Name = "btnIntroductionView";
            btnIntroductionView.Size = new Size(186, 22);
            btnIntroductionView.Text = "Giới thiệu";
            btnIntroductionView.Click += btnIntroductionView_Click;
            // 
            // btnInventory
            // 
            btnInventory.Name = "btnInventory";
            btnInventory.Size = new Size(180, 22);
            btnInventory.Text = "Tồn kho";
            btnInventory.Click += btnInventory_Click;
            // 
            // btnSales
            // 
            btnSales.Name = "btnSales";
            btnSales.Size = new Size(180, 22);
            btnSales.Text = "Doanh số";
            btnSales.Click += btnSales_Click;
            // 
            // btnReport
            // 
            btnReport.DropDownItems.AddRange(new ToolStripItem[] { btnSales, btnInventory });
            btnReport.Image = Properties.Resources.add_task;
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(77, 20);
            btnReport.Text = "Báo cáo";
            // 
            // btnPOSView
            // 
            btnPOSView.Name = "btnPOSView";
            btnPOSView.Size = new Size(180, 22);
            btnPOSView.Text = "Bán hàng";
            btnPOSView.Click += btnPOSView_Click;
            // 
            // nhàCungCấpToolStripMenuItem
            // 
            nhàCungCấpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { btnPOSView });
            nhàCungCấpToolStripMenuItem.Image = Properties.Resources.transaction;
            nhàCungCấpToolStripMenuItem.Name = "nhàCungCấpToolStripMenuItem";
            nhàCungCấpToolStripMenuItem.Size = new Size(85, 20);
            nhàCungCấpToolStripMenuItem.Text = "Giao dịch";
            // 
            // btnCategory
            // 
            btnCategory.Name = "btnCategory";
            btnCategory.Size = new Size(148, 22);
            btnCategory.Text = "Nhóm thuốc";
            btnCategory.Click += btnCategory_Click;
            // 
            // btnSuppliers
            // 
            btnSuppliers.Name = "btnSuppliers";
            btnSuppliers.Size = new Size(148, 22);
            btnSuppliers.Text = "Nhà cung cấp";
            btnSuppliers.Click += btnSuppliers_Click;
            // 
            // btnMedicines
            // 
            btnMedicines.Name = "btnMedicines";
            btnMedicines.Size = new Size(148, 22);
            btnMedicines.Text = "Thuốc";
            btnMedicines.Click += btnMedicines_Click;
            // 
            // thuốcToolStripMenuItem
            // 
            thuốcToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { btnCategory, btnMedicines, btnSuppliers, btnBills });
            thuốcToolStripMenuItem.Image = Properties.Resources.software;
            thuốcToolStripMenuItem.Name = "thuốcToolStripMenuItem";
            thuốcToolStripMenuItem.Size = new Size(76, 20);
            thuốcToolStripMenuItem.Text = "Quản lý";
            // 
            // btnBills
            // 
            btnBills.Name = "btnBills";
            btnBills.Size = new Size(148, 22);
            btnBills.Text = "Hóa đơn";
            btnBills.Click += btnBills_Click;
            // 
            // btnExit
            // 
            btnExit.Name = "btnExit";
            btnExit.ShortcutKeys = Keys.Alt | Keys.F4;
            btnExit.Size = new Size(207, 22);
            btnExit.Text = "Thoát";
            btnExit.Click += btnExit_Click;
            // 
            // btnLogout
            // 
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(207, 22);
            btnLogout.Text = "Đăng xuất";
            btnLogout.Click += btnLogout_Click;
            // 
            // btnDatabase
            // 
            btnDatabase.Name = "btnDatabase";
            btnDatabase.Size = new Size(207, 22);
            btnDatabase.Text = "Sao lưu/ Phục hồi dữ liệu";
            btnDatabase.Click += btnDatabase_Click;
            // 
            // btnChangePassword
            // 
            btnChangePassword.Name = "btnChangePassword";
            btnChangePassword.Size = new Size(207, 22);
            btnChangePassword.Text = "Đổi mật khẩu";
            btnChangePassword.Click += btnChangePassword_Click;
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            tàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { btnChangePassword, btnLogs, btnDatabase, btnLogout, btnExit });
            tàiKhoảnToolStripMenuItem.ForeColor = SystemColors.ControlText;
            tàiKhoảnToolStripMenuItem.Image = Properties.Resources.user;
            tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            tàiKhoảnToolStripMenuItem.Size = new Size(85, 20);
            tàiKhoảnToolStripMenuItem.Text = "Hệ thống";
            // 
            // btnLogs
            // 
            btnLogs.Name = "btnLogs";
            btnLogs.Size = new Size(207, 22);
            btnLogs.Text = "Nhật ký hệ thống";
            btnLogs.Click += btnLogs_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(218, 223, 255);
            menuStrip1.Items.AddRange(new ToolStripItem[] { tàiKhoảnToolStripMenuItem, thuốcToolStripMenuItem, nhàCungCấpToolStripMenuItem, btnReport, hóaĐơnToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1184, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(245, 247, 255);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1184, 611);
            panelMain.TabIndex = 3;
            // 
            // statusStrip1
            // 
            statusStrip1.AutoSize = false;
            statusStrip1.Items.AddRange(new ToolStripItem[] { txtFullName, toolStripStatusLabel1, lblConnection, lblTime });
            statusStrip1.Location = new Point(0, 589);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1184, 22);
            statusStrip1.TabIndex = 0;
            statusStrip1.Text = "statusStrip1";
            // 
            // txtFullName
            // 
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(30, 17);
            txtFullName.Text = "User";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(986, 17);
            toolStripStatusLabel1.Spring = true;
            toolStripStatusLabel1.Text = "🔖 v1.0.0";
            // 
            // lblConnection
            // 
            lblConnection.Name = "lblConnection";
            lblConnection.Size = new Size(120, 17);
            lblConnection.Text = "⛔ Chưa kết nối CSDL";
            // 
            // lblTime
            // 
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(33, 17);
            lblTime.Text = "Time";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 611);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            Controls.Add(panelMain);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1200, 650);
            MinimumSize = new Size(800, 400);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hệ thống quản lý thuốc";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ToolStripMenuItem btnInfoSoftware;
        private ToolStripMenuItem hóaĐơnToolStripMenuItem;
        private ToolStripMenuItem btnIntroductionView;
        private ToolStripMenuItem btnInventory;
        private ToolStripMenuItem btnSales;
        private ToolStripMenuItem btnReport;
        private ToolStripMenuItem btnPOSView;
        private ToolStripMenuItem nhàCungCấpToolStripMenuItem;
        private ToolStripMenuItem btnCategory;
        private ToolStripMenuItem btnSuppliers;
        private ToolStripMenuItem btnMedicines;
        private ToolStripMenuItem thuốcToolStripMenuItem;
        private ToolStripMenuItem btnExit;
        private ToolStripMenuItem btnLogout;
        private ToolStripMenuItem btnDatabase;
        private ToolStripMenuItem btnChangePassword;
        private ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private MenuStrip menuStrip1;
        private Panel panelMain;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel lblConnection;
        private ToolStripStatusLabel lblTime;
        private ToolStripStatusLabel txtFullName;
        private ToolStripMenuItem btnBills;
        private ToolStripMenuItem btnLogs;
    }
}