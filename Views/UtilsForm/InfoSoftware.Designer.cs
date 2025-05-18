namespace pharmacy_sys.Views.UtilsForm
{
    partial class InfoSoftware
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
            panelMain = new Panel();
            lblHeader = new Label();
            picLogo = new PictureBox();
            panelContact = new Panel();
            lblContactTitle = new Label();
            lblWebsite = new Label();
            lblHotline = new Label();
            lblEmail = new Label();
            panelFeatures = new Panel();
            checkBox5 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            lblFeaturesTitle = new Label();
            panelInfo = new Panel();
            lblSoftwareName = new Label();
            lblVersion = new Label();
            lblReleaseDate = new Label();
            lblDeveloper = new Label();
            panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            panelContact.SuspendLayout();
            panelFeatures.SuspendLayout();
            panelInfo.SuspendLayout();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.White;
            panelMain.BorderStyle = BorderStyle.FixedSingle;
            panelMain.Controls.Add(lblHeader);
            panelMain.Controls.Add(picLogo);
            panelMain.Controls.Add(panelContact);
            panelMain.Controls.Add(panelFeatures);
            panelMain.Controls.Add(panelInfo);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1168, 572);
            panelMain.TabIndex = 0;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.BackColor = Color.White;
            lblHeader.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeader.ForeColor = Color.FromArgb(128, 128, 255);
            lblHeader.Location = new Point(442, 62);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(351, 25);
            lblHeader.TabIndex = 1;
            lblHeader.Text = "💊 PHẦN MỀM QUẢN LÝ NHÀ THUỐC";
            // 
            // picLogo
            // 
            picLogo.Image = Properties.Resources.logo;
            picLogo.Location = new Point(22, 49);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(50, 50);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // panelContact
            // 
            panelContact.BorderStyle = BorderStyle.FixedSingle;
            panelContact.Controls.Add(lblContactTitle);
            panelContact.Controls.Add(lblWebsite);
            panelContact.Controls.Add(lblHotline);
            panelContact.Controls.Add(lblEmail);
            panelContact.Location = new Point(22, 438);
            panelContact.Name = "panelContact";
            panelContact.Size = new Size(1105, 100);
            panelContact.TabIndex = 3;
            // 
            // lblContactTitle
            // 
            lblContactTitle.AutoSize = true;
            lblContactTitle.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblContactTitle.ForeColor = Color.FromArgb(128, 128, 255);
            lblContactTitle.Location = new Point(5, 5);
            lblContactTitle.Name = "lblContactTitle";
            lblContactTitle.Size = new Size(134, 17);
            lblContactTitle.TabIndex = 0;
            lblContactTitle.Text = "📞 Hỗ trợ và liên hệ";
            // 
            // lblWebsite
            // 
            lblWebsite.AutoSize = true;
            lblWebsite.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWebsite.Location = new Point(20, 30);
            lblWebsite.Name = "lblWebsite";
            lblWebsite.Size = new Size(172, 15);
            lblWebsite.TabIndex = 1;
            lblWebsite.Text = "▪ Website: www.pharmacy.com";
            // 
            // lblHotline
            // 
            lblHotline.AutoSize = true;
            lblHotline.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHotline.Location = new Point(20, 50);
            lblHotline.Name = "lblHotline";
            lblHotline.Size = new Size(125, 15);
            lblHotline.TabIndex = 2;
            lblHotline.Text = "▪ Hotline: 1900 123 456";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(20, 70);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(181, 15);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "▪ Email: support@pharmacy.com";
            // 
            // panelFeatures
            // 
            panelFeatures.BorderStyle = BorderStyle.FixedSingle;
            panelFeatures.Controls.Add(checkBox5);
            panelFeatures.Controls.Add(checkBox4);
            panelFeatures.Controls.Add(checkBox3);
            panelFeatures.Controls.Add(checkBox2);
            panelFeatures.Controls.Add(checkBox1);
            panelFeatures.Controls.Add(lblFeaturesTitle);
            panelFeatures.Location = new Point(22, 262);
            panelFeatures.Name = "panelFeatures";
            panelFeatures.Size = new Size(1105, 170);
            panelFeatures.TabIndex = 2;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Checked = true;
            checkBox5.CheckState = CheckState.Checked;
            checkBox5.Location = new Point(20, 133);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(249, 19);
            checkBox5.TabIndex = 6;
            checkBox5.Text = "Tích hợp đăng nhập, phân quyền chặt chẽ";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Checked = true;
            checkBox4.CheckState = CheckState.Checked;
            checkBox4.Location = new Point(20, 108);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(253, 19);
            checkBox4.TabIndex = 6;
            checkBox4.Text = "Thuốc kê doanh thu theo ngày/tháng/năm";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Checked = true;
            checkBox3.CheckState = CheckState.Checked;
            checkBox3.Location = new Point(20, 83);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(261, 19);
            checkBox3.TabIndex = 6;
            checkBox3.Text = "Quản lý nhà cung cấp, thuốc chuyên nghiệp";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Checked = true;
            checkBox2.CheckState = CheckState.Checked;
            checkBox2.Location = new Point(20, 58);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(287, 19);
            checkBox2.TabIndex = 6;
            checkBox2.Text = "Bán hàng nhanh chóng, giao diện chuyên nghiệp";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Checked = true;
            checkBox1.CheckState = CheckState.Checked;
            checkBox1.Location = new Point(20, 33);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(276, 19);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "Quản lý kho thuốc: Nhập xuất hàng tồn theo lô";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // lblFeaturesTitle
            // 
            lblFeaturesTitle.AutoSize = true;
            lblFeaturesTitle.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFeaturesTitle.ForeColor = Color.FromArgb(128, 128, 255);
            lblFeaturesTitle.Location = new Point(5, 5);
            lblFeaturesTitle.Name = "lblFeaturesTitle";
            lblFeaturesTitle.Size = new Size(132, 17);
            lblFeaturesTitle.TabIndex = 0;
            lblFeaturesTitle.Text = "💼 Tính năng chính";
            // 
            // panelInfo
            // 
            panelInfo.BorderStyle = BorderStyle.FixedSingle;
            panelInfo.Controls.Add(lblSoftwareName);
            panelInfo.Controls.Add(lblVersion);
            panelInfo.Controls.Add(lblReleaseDate);
            panelInfo.Controls.Add(lblDeveloper);
            panelInfo.Location = new Point(22, 135);
            panelInfo.Name = "panelInfo";
            panelInfo.Size = new Size(1105, 121);
            panelInfo.TabIndex = 1;
            // 
            // lblSoftwareName
            // 
            lblSoftwareName.AutoSize = true;
            lblSoftwareName.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSoftwareName.Location = new Point(20, 10);
            lblSoftwareName.Name = "lblSoftwareName";
            lblSoftwareName.Size = new Size(225, 17);
            lblSoftwareName.TabIndex = 0;
            lblSoftwareName.Text = "▪ Tên phần mềm: Pharmacy System";
            // 
            // lblVersion
            // 
            lblVersion.AutoSize = true;
            lblVersion.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVersion.Location = new Point(23, 36);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new Size(110, 17);
            lblVersion.TabIndex = 1;
            lblVersion.Text = "▪ Phiên bản: 1.0.0";
            // 
            // lblReleaseDate
            // 
            lblReleaseDate.AutoSize = true;
            lblReleaseDate.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReleaseDate.Location = new Point(20, 63);
            lblReleaseDate.Name = "lblReleaseDate";
            lblReleaseDate.Size = new Size(187, 17);
            lblReleaseDate.TabIndex = 2;
            lblReleaseDate.Text = "▪ Ngày phát hành: 17/05/2025";
            // 
            // lblDeveloper
            // 
            lblDeveloper.AutoSize = true;
            lblDeveloper.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblDeveloper.Location = new Point(20, 90);
            lblDeveloper.Name = "lblDeveloper";
            lblDeveloper.Size = new Size(212, 17);
            lblDeveloper.TabIndex = 3;
            lblDeveloper.Text = "▪ Nhà phát triển: Phan Văn Thành";
            // 
            // InfoSoftware
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1168, 572);
            Controls.Add(panelMain);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "InfoSoftware";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thông tin phần mềm";
            Load += InfoSoftware_Load;
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            panelContact.ResumeLayout(false);
            panelContact.PerformLayout();
            panelFeatures.ResumeLayout(false);
            panelFeatures.PerformLayout();
            panelInfo.ResumeLayout(false);
            panelInfo.PerformLayout();
            ResumeLayout(false);
        }

        // Code sự kiện khi nhấn nút Đóng
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Load form
        private void InfoSoftware_Load(object sender, EventArgs e)
        {
            // Load logo từ resources (Nếu có)
            try
            {
                // picLogo.Image = Properties.Resources.LogoApp;
                // Hoặc load từ file
                // picLogo.Image = Image.FromFile("path_to_logo.png");
            }
            catch (Exception)
            {
                // Xử lý nếu không tìm thấy logo
            }
        }

        // Khai báo các control
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelContact;
        private System.Windows.Forms.Label lblContactTitle;
        private System.Windows.Forms.Label lblWebsite;
        private System.Windows.Forms.Label lblHotline;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Panel panelFeatures;
        private System.Windows.Forms.Label lblFeaturesTitle;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Label lblSoftwareName;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblReleaseDate;
        private System.Windows.Forms.Label lblDeveloper;
        #endregion

        private CheckBox checkBox1;
        private CheckBox checkBox5;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private Label lblHeader;
        private PictureBox picLogo;
    }
}