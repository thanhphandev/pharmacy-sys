namespace pharmacy_sys.Views.UtilsForm
{
    partial class IntroductionView
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
            components = new System.ComponentModel.Container();
            mainPanel = new Panel();
            featuresPanel = new Panel();
            featuresHeaderLabel = new Label();
            featuresList = new FlowLayoutPanel();
            feature1Panel = new Panel();
            feature1Description = new Label();
            feature1Title = new Label();
            feature1Icon = new PictureBox();
            feature2Panel = new Panel();
            feature2Description = new Label();
            feature2Title = new Label();
            feature2Icon = new PictureBox();
            feature3Panel = new Panel();
            feature3Description = new Label();
            feature3Title = new Label();
            feature3Icon = new PictureBox();
            feature4Panel = new Panel();
            feature4Description = new Label();
            feature4Title = new Label();
            feature4Icon = new PictureBox();
            versionLabel = new Label();
            developerLabel = new Label();
            titleLabel = new Label();
            logoPictureBox = new PictureBox();
            loadingTimer = new System.Windows.Forms.Timer(components);
            mainPanel.SuspendLayout();
            featuresPanel.SuspendLayout();
            featuresList.SuspendLayout();
            feature1Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)feature1Icon).BeginInit();
            feature2Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)feature2Icon).BeginInit();
            feature3Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)feature3Icon).BeginInit();
            feature4Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)feature4Icon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).BeginInit();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.White;
            mainPanel.Controls.Add(featuresPanel);
            mainPanel.Controls.Add(versionLabel);
            mainPanel.Controls.Add(developerLabel);
            mainPanel.Controls.Add(titleLabel);
            mainPanel.Controls.Add(logoPictureBox);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1000, 600);
            mainPanel.TabIndex = 0;
            // 
            // featuresPanel
            // 
            featuresPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            featuresPanel.Controls.Add(featuresHeaderLabel);
            featuresPanel.Controls.Add(featuresList);
            featuresPanel.Location = new Point(30, 120);
            featuresPanel.Name = "featuresPanel";
            featuresPanel.Size = new Size(940, 400);
            featuresPanel.TabIndex = 4;
            // 
            // featuresHeaderLabel
            // 
            featuresHeaderLabel.AutoSize = true;
            featuresHeaderLabel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            featuresHeaderLabel.ForeColor = Color.FromArgb(64, 64, 64);
            featuresHeaderLabel.Location = new Point(3, 10);
            featuresHeaderLabel.Name = "featuresHeaderLabel";
            featuresHeaderLabel.Size = new Size(162, 25);
            featuresHeaderLabel.TabIndex = 0;
            featuresHeaderLabel.Text = "Tính năng nổi bật";
            // 
            // featuresList
            // 
            featuresList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            featuresList.Controls.Add(feature1Panel);
            featuresList.Controls.Add(feature2Panel);
            featuresList.Controls.Add(feature3Panel);
            featuresList.Controls.Add(feature4Panel);
            featuresList.Location = new Point(3, 45);
            featuresList.Name = "featuresList";
            featuresList.Size = new Size(934, 352);
            featuresList.TabIndex = 1;
            // 
            // feature1Panel
            // 
            feature1Panel.BackColor = Color.FromArgb(245, 247, 250);
            feature1Panel.BorderStyle = BorderStyle.FixedSingle;
            feature1Panel.Controls.Add(feature1Description);
            feature1Panel.Controls.Add(feature1Title);
            feature1Panel.Controls.Add(feature1Icon);
            feature1Panel.Location = new Point(3, 3);
            feature1Panel.Margin = new Padding(3, 3, 15, 15);
            feature1Panel.Name = "feature1Panel";
            feature1Panel.Size = new Size(445, 160);
            feature1Panel.TabIndex = 0;
            // 
            // feature1Description
            // 
            feature1Description.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            feature1Description.ForeColor = Color.FromArgb(64, 64, 64);
            feature1Description.Location = new Point(75, 45);
            feature1Description.Name = "feature1Description";
            feature1Description.Size = new Size(350, 100);
            feature1Description.TabIndex = 2;
            feature1Description.Text = "Theo dõi tồn kho, quản lý hạn sử dụng và tự động cảnh báo thuốc sắp hết hàng. Hỗ trợ nhập thuốc tự động và phân loại thuốc theo nhiều tiêu chí.";
            // 
            // feature1Title
            // 
            feature1Title.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            feature1Title.ForeColor = Color.FromArgb(0, 122, 204);
            feature1Title.Location = new Point(75, 15);
            feature1Title.Name = "feature1Title";
            feature1Title.Size = new Size(350, 25);
            feature1Title.TabIndex = 1;
            feature1Title.Text = "Quản lý thuốc chính xác";
            // 
            // feature1Icon
            // 
            feature1Icon.Image = Properties.Resources.cross;
            feature1Icon.Location = new Point(15, 15);
            feature1Icon.Name = "feature1Icon";
            feature1Icon.Size = new Size(48, 48);
            feature1Icon.SizeMode = PictureBoxSizeMode.Zoom;
            feature1Icon.TabIndex = 0;
            feature1Icon.TabStop = false;
            // 
            // feature2Panel
            // 
            feature2Panel.BackColor = Color.FromArgb(245, 247, 250);
            feature2Panel.BorderStyle = BorderStyle.FixedSingle;
            feature2Panel.Controls.Add(feature2Description);
            feature2Panel.Controls.Add(feature2Title);
            feature2Panel.Controls.Add(feature2Icon);
            feature2Panel.Location = new Point(466, 3);
            feature2Panel.Margin = new Padding(3, 3, 15, 15);
            feature2Panel.Name = "feature2Panel";
            feature2Panel.Size = new Size(445, 160);
            feature2Panel.TabIndex = 1;
            // 
            // feature2Description
            // 
            feature2Description.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            feature2Description.ForeColor = Color.FromArgb(64, 64, 64);
            feature2Description.Location = new Point(75, 45);
            feature2Description.Name = "feature2Description";
            feature2Description.Size = new Size(350, 100);
            feature2Description.TabIndex = 2;
            feature2Description.Text = "Giao diện bán hàng thông minh, tiện lợi dễ sử dụng\r\n, xử lý nhanh các giao dịchvà tự động xuất hóa đơn điện tử đúng quy định.";
            // 
            // feature2Title
            // 
            feature2Title.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            feature2Title.ForeColor = Color.FromArgb(0, 122, 204);
            feature2Title.Location = new Point(75, 15);
            feature2Title.Name = "feature2Title";
            feature2Title.Size = new Size(350, 25);
            feature2Title.TabIndex = 1;
            feature2Title.Text = "Bán hàng và xuất hóa đơn";
            // 
            // feature2Icon
            // 
            feature2Icon.Image = Properties.Resources.lending;
            feature2Icon.Location = new Point(15, 15);
            feature2Icon.Name = "feature2Icon";
            feature2Icon.Size = new Size(48, 48);
            feature2Icon.SizeMode = PictureBoxSizeMode.Zoom;
            feature2Icon.TabIndex = 0;
            feature2Icon.TabStop = false;
            // 
            // feature3Panel
            // 
            feature3Panel.BackColor = Color.FromArgb(245, 247, 250);
            feature3Panel.BorderStyle = BorderStyle.FixedSingle;
            feature3Panel.Controls.Add(feature3Description);
            feature3Panel.Controls.Add(feature3Title);
            feature3Panel.Controls.Add(feature3Icon);
            feature3Panel.Location = new Point(3, 181);
            feature3Panel.Margin = new Padding(3, 3, 15, 15);
            feature3Panel.Name = "feature3Panel";
            feature3Panel.Size = new Size(445, 160);
            feature3Panel.TabIndex = 2;
            // 
            // feature3Description
            // 
            feature3Description.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            feature3Description.ForeColor = Color.FromArgb(64, 64, 64);
            feature3Description.Location = new Point(75, 45);
            feature3Description.Name = "feature3Description";
            feature3Description.Size = new Size(350, 100);
            feature3Description.TabIndex = 2;
            feature3Description.Text = "Cơ sở dữ liệu nhà cung cấp chi tiết, lịch sử hóa đơn. Quản lý thông tin nhà cung cấp và lịch sử đặt hàng.";
            // 
            // feature3Title
            // 
            feature3Title.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            feature3Title.ForeColor = Color.FromArgb(0, 122, 204);
            feature3Title.Location = new Point(75, 15);
            feature3Title.Name = "feature3Title";
            feature3Title.Size = new Size(350, 25);
            feature3Title.TabIndex = 1;
            feature3Title.Text = "Quản lý khách hàng và nhà cung cấp";
            // 
            // feature3Icon
            // 
            feature3Icon.Image = Properties.Resources.helpdesk;
            feature3Icon.Location = new Point(15, 15);
            feature3Icon.Name = "feature3Icon";
            feature3Icon.Size = new Size(48, 48);
            feature3Icon.SizeMode = PictureBoxSizeMode.Zoom;
            feature3Icon.TabIndex = 0;
            feature3Icon.TabStop = false;
            // 
            // feature4Panel
            // 
            feature4Panel.BackColor = Color.FromArgb(245, 247, 250);
            feature4Panel.BorderStyle = BorderStyle.FixedSingle;
            feature4Panel.Controls.Add(feature4Description);
            feature4Panel.Controls.Add(feature4Title);
            feature4Panel.Controls.Add(feature4Icon);
            feature4Panel.Location = new Point(466, 181);
            feature4Panel.Margin = new Padding(3, 3, 15, 15);
            feature4Panel.Name = "feature4Panel";
            feature4Panel.Size = new Size(445, 160);
            feature4Panel.TabIndex = 3;
            // 
            // feature4Description
            // 
            feature4Description.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            feature4Description.ForeColor = Color.FromArgb(64, 64, 64);
            feature4Description.Location = new Point(75, 45);
            feature4Description.Name = "feature4Description";
            feature4Description.Size = new Size(350, 100);
            feature4Description.TabIndex = 2;
            feature4Description.Text = "Báo cáo doanh thu, lợi nhuận theo nhiều tiêu chí. Biểu đồ trực quan, xu hướng bán hàng và phân tích dữ liệu nâng cao giúp đưa ra quyết định kinh doanh.";
            // 
            // feature4Title
            // 
            feature4Title.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            feature4Title.ForeColor = Color.FromArgb(0, 122, 204);
            feature4Title.Location = new Point(75, 15);
            feature4Title.Name = "feature4Title";
            feature4Title.Size = new Size(350, 25);
            feature4Title.TabIndex = 1;
            feature4Title.Text = "Báo cáo và phân tích dữ liệu";
            // 
            // feature4Icon
            // 
            feature4Icon.Image = Properties.Resources.report;
            feature4Icon.Location = new Point(15, 15);
            feature4Icon.Name = "feature4Icon";
            feature4Icon.Size = new Size(48, 48);
            feature4Icon.SizeMode = PictureBoxSizeMode.Zoom;
            feature4Icon.TabIndex = 0;
            feature4Icon.TabStop = false;
            // 
            // versionLabel
            // 
            versionLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            versionLabel.AutoSize = true;
            versionLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            versionLabel.ForeColor = Color.FromArgb(128, 128, 128);
            versionLabel.Location = new Point(897, 30);
            versionLabel.Name = "versionLabel";
            versionLabel.Size = new Size(96, 17);
            versionLabel.TabIndex = 3;
            versionLabel.Text = "Phiên bản 1.0.0";
            // 
            // developerLabel
            // 
            developerLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            developerLabel.ForeColor = Color.FromArgb(64, 64, 64);
            developerLabel.Location = new Point(122, 75);
            developerLabel.Name = "developerLabel";
            developerLabel.Size = new Size(500, 25);
            developerLabel.TabIndex = 2;
            developerLabel.Text = "Phát triển bởi Phan Văn Thành © 2025";
            // 
            // titleLabel
            // 
            titleLabel.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleLabel.ForeColor = Color.FromArgb(0, 122, 204);
            titleLabel.Location = new Point(120, 30);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(600, 45);
            titleLabel.TabIndex = 1;
            titleLabel.Text = "Pharmacy System";
            // 
            // logoPictureBox
            // 
            logoPictureBox.Image = Properties.Resources.logo;
            logoPictureBox.Location = new Point(36, 34);
            logoPictureBox.Name = "logoPictureBox";
            logoPictureBox.Size = new Size(80, 80);
            logoPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            logoPictureBox.TabIndex = 0;
            logoPictureBox.TabStop = false;
            // 
            // loadingTimer
            // 
            loadingTimer.Interval = 30;
            // 
            // IntroductionView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 600);
            Controls.Add(mainPanel);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "IntroductionView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pharmacy System - Phần mềm quản lý nhà thuốc chuyên nghiệp";
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            featuresPanel.ResumeLayout(false);
            featuresPanel.PerformLayout();
            featuresList.ResumeLayout(false);
            feature1Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)feature1Icon).EndInit();
            feature2Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)feature2Icon).EndInit();
            feature3Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)feature3Icon).EndInit();
            feature4Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)feature4Icon).EndInit();
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label developerLabel;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.Panel featuresPanel;
        private System.Windows.Forms.Label featuresHeaderLabel;
        private System.Windows.Forms.FlowLayoutPanel featuresList;
        private System.Windows.Forms.Panel feature1Panel;
        private System.Windows.Forms.PictureBox feature1Icon;
        private System.Windows.Forms.Label feature1Title;
        private System.Windows.Forms.Label feature1Description;
        private System.Windows.Forms.Panel feature2Panel;
        private System.Windows.Forms.PictureBox feature2Icon;
        private System.Windows.Forms.Label feature2Title;
        private System.Windows.Forms.Label feature2Description;
        private System.Windows.Forms.Panel feature3Panel;
        private System.Windows.Forms.PictureBox feature3Icon;
        private System.Windows.Forms.Label feature3Title;
        private System.Windows.Forms.Label feature3Description;
        private System.Windows.Forms.Panel feature4Panel;
        private System.Windows.Forms.PictureBox feature4Icon;
        private System.Windows.Forms.Label feature4Title;
        private System.Windows.Forms.Label feature4Description;
        private System.Windows.Forms.Timer loadingTimer;
        
    }
}