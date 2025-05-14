namespace pharmacy_sys.Views.DatabaseForm
{
    partial class DatabaseView
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
            groupBox1 = new GroupBox();
            btnBackup = new Button();
            label1 = new Label();
            btnBrowseBackup = new Button();
            label2 = new Label();
            txtBackupPath = new TextBox();
            progressBar = new ProgressBar();
            groupBox2 = new GroupBox();
            btnRestore = new Button();
            btnBrowserRestore = new Button();
            label4 = new Label();
            label3 = new Label();
            txtRestorePath = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnBackup);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnBrowseBackup);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtBackupPath);
            groupBox1.Location = new Point(43, 31);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(692, 139);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // btnBackup
            // 
            btnBackup.Location = new Point(452, 90);
            btnBackup.Name = "btnBackup";
            btnBackup.Size = new Size(75, 23);
            btnBackup.TabIndex = 3;
            btnBackup.Text = "Sao lưu";
            btnBackup.UseVisualStyleBackColor = true;
            btnBackup.Click += btnBackup_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(128, 128, 255);
            label1.Location = new Point(15, 19);
            label1.Name = "label1";
            label1.Size = new Size(147, 25);
            label1.TabIndex = 0;
            label1.Text = "Sao lưu dữ liệu";
            // 
            // btnBrowseBackup
            // 
            btnBrowseBackup.Location = new Point(543, 49);
            btnBrowseBackup.Name = "btnBrowseBackup";
            btnBrowseBackup.Size = new Size(75, 23);
            btnBrowseBackup.TabIndex = 2;
            btnBrowseBackup.Text = "Chọn";
            btnBrowseBackup.UseVisualStyleBackColor = true;
            btnBrowseBackup.Click += btnBrowseBackup_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(42, 55);
            label2.Name = "label2";
            label2.Size = new Size(62, 17);
            label2.TabIndex = 1;
            label2.Text = "Vị trí lưu";
            // 
            // txtBackupPath
            // 
            txtBackupPath.Location = new Point(110, 50);
            txtBackupPath.Name = "txtBackupPath";
            txtBackupPath.ReadOnly = true;
            txtBackupPath.Size = new Size(417, 23);
            txtBackupPath.TabIndex = 0;
            // 
            // progressBar
            // 
            progressBar.ForeColor = Color.FromArgb(128, 128, 255);
            progressBar.Location = new Point(43, 348);
            progressBar.MarqueeAnimationSpeed = 30;
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(692, 23);
            progressBar.Style = ProgressBarStyle.Marquee;
            progressBar.TabIndex = 5;
            progressBar.Visible = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnRestore);
            groupBox2.Controls.Add(btnBrowserRestore);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(txtRestorePath);
            groupBox2.Location = new Point(43, 189);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(692, 136);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            // 
            // btnRestore
            // 
            btnRestore.Location = new Point(424, 88);
            btnRestore.Name = "btnRestore";
            btnRestore.Size = new Size(103, 23);
            btnRestore.TabIndex = 3;
            btnRestore.Text = "♻️ Phục hồi";
            btnRestore.UseVisualStyleBackColor = true;
            btnRestore.Click += btnRestore_Click;
            // 
            // btnBrowserRestore
            // 
            btnBrowserRestore.Location = new Point(543, 59);
            btnBrowserRestore.Name = "btnBrowserRestore";
            btnBrowserRestore.Size = new Size(75, 23);
            btnBrowserRestore.TabIndex = 2;
            btnBrowserRestore.Text = "Chọn";
            btnBrowserRestore.UseVisualStyleBackColor = true;
            btnBrowserRestore.Click += btnBrowserRestore_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Control;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(128, 128, 255);
            label4.Location = new Point(15, 19);
            label4.Name = "label4";
            label4.Size = new Size(156, 25);
            label4.TabIndex = 0;
            label4.Text = "Phục hồi dữ liệu";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(42, 65);
            label3.Name = "label3";
            label3.Size = new Size(55, 17);
            label3.TabIndex = 1;
            label3.Text = "file .bak";
            // 
            // txtRestorePath
            // 
            txtRestorePath.Location = new Point(110, 59);
            txtRestorePath.Name = "txtRestorePath";
            txtRestorePath.ReadOnly = true;
            txtRestorePath.Size = new Size(417, 23);
            txtRestorePath.TabIndex = 0;
            // 
            // DatabaseView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 422);
            Controls.Add(groupBox1);
            Controls.Add(progressBar);
            Controls.Add(groupBox2);
            Name = "DatabaseView";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Sao lưu và phục hồi dữ liệu";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnBackup;
        private Label label1;
        private Button btnBrowseBackup;
        private Label label2;
        private TextBox txtBackupPath;
        private ProgressBar progressBar;
        private GroupBox groupBox2;
        private Button btnRestore;
        private Button btnBrowserRestore;
        private Label label4;
        private Label label3;
        private TextBox txtRestorePath;
    }
}