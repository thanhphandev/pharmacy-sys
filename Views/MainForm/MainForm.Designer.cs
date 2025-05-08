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
            liênHệToolStripMenuItem = new ToolStripMenuItem();
            btnGuides = new ToolStripMenuItem();
            hóaĐơnToolStripMenuItem = new ToolStripMenuItem();
            btnIntroductionView = new ToolStripMenuItem();
            lợiNhuậnToolStripMenuItem = new ToolStripMenuItem();
            báoCáoTàiChínhToolStripMenuItem = new ToolStripMenuItem();
            báoCáoThuốcToolStripMenuItem = new ToolStripMenuItem();
            báoCáoToolStripMenuItem = new ToolStripMenuItem();
            thêmNhàCungCấpToolStripMenuItem = new ToolStripMenuItem();
            nhàCungCấpToolStripMenuItem = new ToolStripMenuItem();
            btnCategory = new ToolStripMenuItem();
            btnSuppliers = new ToolStripMenuItem();
            btnMedicines = new ToolStripMenuItem();
            thuốcToolStripMenuItem = new ToolStripMenuItem();
            nhânViênToolStripMenuItem = new ToolStripMenuItem();
            btnExit = new ToolStripMenuItem();
            thoátToolStripMenuItem = new ToolStripMenuItem();
            saoLưuToolStripMenuItem = new ToolStripMenuItem();
            btnChangePass = new ToolStripMenuItem();
            btnLogin = new ToolStripMenuItem();
            tàiKhoảnToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            panelMain = new Panel();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            lblConnection = new ToolStripStatusLabel();
            lblTime = new ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // liênHệToolStripMenuItem
            // 
            liênHệToolStripMenuItem.Name = "liênHệToolStripMenuItem";
            liênHệToolStripMenuItem.Size = new Size(134, 22);
            liênHệToolStripMenuItem.Text = "Liên hệ";
            // 
            // btnGuides
            // 
            btnGuides.Image = Properties.Resources.logo;
            btnGuides.Name = "btnGuides";
            btnGuides.Size = new Size(134, 22);
            btnGuides.Text = "Hướng dẫn";
            btnGuides.Click += btnGuides_Click;
            // 
            // hóaĐơnToolStripMenuItem
            // 
            hóaĐơnToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { btnGuides, btnIntroductionView, liênHệToolStripMenuItem });
            hóaĐơnToolStripMenuItem.Name = "hóaĐơnToolStripMenuItem";
            hóaĐơnToolStripMenuItem.Size = new Size(62, 20);
            hóaĐơnToolStripMenuItem.Text = "Trợ giúp";
            // 
            // btnIntroductionView
            // 
            btnIntroductionView.Name = "btnIntroductionView";
            btnIntroductionView.Size = new Size(134, 22);
            btnIntroductionView.Text = "Giới thiệu";
            btnIntroductionView.Click += btnIntroductionView_Click;
            // 
            // lợiNhuậnToolStripMenuItem
            // 
            lợiNhuậnToolStripMenuItem.Name = "lợiNhuậnToolStripMenuItem";
            lợiNhuậnToolStripMenuItem.Size = new Size(130, 22);
            lợiNhuậnToolStripMenuItem.Text = "Lợi nhuận";
            // 
            // báoCáoTàiChínhToolStripMenuItem
            // 
            báoCáoTàiChínhToolStripMenuItem.Name = "báoCáoTàiChínhToolStripMenuItem";
            báoCáoTàiChínhToolStripMenuItem.Size = new Size(130, 22);
            báoCáoTàiChínhToolStripMenuItem.Text = "Tồn kho";
            // 
            // báoCáoThuốcToolStripMenuItem
            // 
            báoCáoThuốcToolStripMenuItem.Name = "báoCáoThuốcToolStripMenuItem";
            báoCáoThuốcToolStripMenuItem.Size = new Size(130, 22);
            báoCáoThuốcToolStripMenuItem.Text = "Doanh thu";
            // 
            // báoCáoToolStripMenuItem
            // 
            báoCáoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { báoCáoThuốcToolStripMenuItem, báoCáoTàiChínhToolStripMenuItem, lợiNhuậnToolStripMenuItem });
            báoCáoToolStripMenuItem.Name = "báoCáoToolStripMenuItem";
            báoCáoToolStripMenuItem.Size = new Size(61, 20);
            báoCáoToolStripMenuItem.Text = "Báo cáo";
            // 
            // thêmNhàCungCấpToolStripMenuItem
            // 
            thêmNhàCungCấpToolStripMenuItem.Name = "thêmNhàCungCấpToolStripMenuItem";
            thêmNhàCungCấpToolStripMenuItem.Size = new Size(124, 22);
            thêmNhàCungCấpToolStripMenuItem.Text = "Bán hàng";
            // 
            // nhàCungCấpToolStripMenuItem
            // 
            nhàCungCấpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { thêmNhàCungCấpToolStripMenuItem });
            nhàCungCấpToolStripMenuItem.Name = "nhàCungCấpToolStripMenuItem";
            nhàCungCấpToolStripMenuItem.Size = new Size(69, 20);
            nhàCungCấpToolStripMenuItem.Text = "Giao dịch";
            // 
            // btnCategory
            // 
            btnCategory.Name = "btnCategory";
            btnCategory.Size = new Size(148, 22);
            btnCategory.Text = "Loại thuốc";
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
            thuốcToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { btnMedicines, btnSuppliers, nhânViênToolStripMenuItem, btnCategory });
            thuốcToolStripMenuItem.Name = "thuốcToolStripMenuItem";
            thuốcToolStripMenuItem.Size = new Size(60, 20);
            thuốcToolStripMenuItem.Text = "Quản lý";
            // 
            // nhânViênToolStripMenuItem
            // 
            nhânViênToolStripMenuItem.Name = "nhânViênToolStripMenuItem";
            nhânViênToolStripMenuItem.Size = new Size(148, 22);
            nhânViênToolStripMenuItem.Text = "Nhân viên";
            // 
            // btnExit
            // 
            btnExit.Name = "btnExit";
            btnExit.ShortcutKeys = Keys.Alt | Keys.F4;
            btnExit.Size = new Size(207, 22);
            btnExit.Text = "Thoát";
            btnExit.Click += btnExit_Click;
            // 
            // thoátToolStripMenuItem
            // 
            thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            thoátToolStripMenuItem.Size = new Size(207, 22);
            thoátToolStripMenuItem.Text = "Đăng xuất";
            // 
            // saoLưuToolStripMenuItem
            // 
            saoLưuToolStripMenuItem.Name = "saoLưuToolStripMenuItem";
            saoLưuToolStripMenuItem.Size = new Size(207, 22);
            saoLưuToolStripMenuItem.Text = "Sao lưu/ Phục hồi dữ liệu";
            // 
            // btnChangePass
            // 
            btnChangePass.Name = "btnChangePass";
            btnChangePass.Size = new Size(207, 22);
            btnChangePass.Text = "Đổi mật khẩu";
            // 
            // btnLogin
            // 
            btnLogin.Name = "btnLogin";
            btnLogin.ShortcutKeys = Keys.Alt | Keys.A;
            btnLogin.Size = new Size(207, 22);
            btnLogin.Text = "Tài khoản";
            btnLogin.Click += btnLogin_Click;
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            tàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { btnLogin, btnChangePass, saoLưuToolStripMenuItem, thoátToolStripMenuItem, btnExit });
            tàiKhoảnToolStripMenuItem.ForeColor = SystemColors.ControlText;
            tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            tàiKhoảnToolStripMenuItem.Size = new Size(69, 20);
            tàiKhoảnToolStripMenuItem.Text = "Hệ thống";
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(218, 223, 255);
            menuStrip1.Items.AddRange(new ToolStripItem[] { tàiKhoảnToolStripMenuItem, thuốcToolStripMenuItem, nhàCungCấpToolStripMenuItem, báoCáoToolStripMenuItem, hóaĐơnToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1084, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(245, 247, 255);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1084, 611);
            panelMain.TabIndex = 3;
            // 
            // statusStrip1
            // 
            statusStrip1.AutoSize = false;
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, lblConnection, lblTime });
            statusStrip1.Location = new Point(0, 589);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1084, 22);
            statusStrip1.TabIndex = 0;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(916, 17);
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
            ClientSize = new Size(1084, 611);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            Controls.Add(panelMain);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1200, 650);
            MinimumSize = new Size(800, 400);
            Name = "MainForm";
            Text = "Hệ thống quản lý thuốc";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStripMenuItem liênHệToolStripMenuItem;
        private ToolStripMenuItem btnGuides;
        private ToolStripMenuItem hóaĐơnToolStripMenuItem;
        private ToolStripMenuItem btnIntroductionView;
        private ToolStripMenuItem lợiNhuậnToolStripMenuItem;
        private ToolStripMenuItem báoCáoTàiChínhToolStripMenuItem;
        private ToolStripMenuItem báoCáoThuốcToolStripMenuItem;
        private ToolStripMenuItem báoCáoToolStripMenuItem;
        private ToolStripMenuItem thêmNhàCungCấpToolStripMenuItem;
        private ToolStripMenuItem nhàCungCấpToolStripMenuItem;
        private ToolStripMenuItem btnCategory;
        private ToolStripMenuItem btnSuppliers;
        private ToolStripMenuItem btnMedicines;
        private ToolStripMenuItem thuốcToolStripMenuItem;
        private ToolStripMenuItem nhânViênToolStripMenuItem;
        private ToolStripMenuItem btnExit;
        private ToolStripMenuItem thoátToolStripMenuItem;
        private ToolStripMenuItem saoLưuToolStripMenuItem;
        private ToolStripMenuItem btnChangePass;
        private ToolStripMenuItem btnLogin;
        private ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private MenuStrip menuStrip1;
        private Panel panelMain;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel lblConnection;
        private ToolStripStatusLabel lblTime;
    }
}