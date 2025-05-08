namespace pharmacy_sys.Views.LoginForm
{
    partial class LoginView
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
            panelLeft = new Panel();
            lblSlogan = new Label();
            pictureBox2 = new PictureBox();
            lblAppName = new Label();
            panelRight = new Panel();
            lblForgotPassword = new LinkLabel();
            btnExit = new Button();
            btnLogin = new Button();
            lkRegister = new LinkLabel();
            label5 = new Label();
            chkDisplayPassword = new CheckBox();
            panelPassword = new Panel();
            txtPassword = new TextBox();
            pictureBoxPassword = new PictureBox();
            lblPassword = new Label();
            panelUsername = new Panel();
            txtUsername = new TextBox();
            pictureBoxUser = new PictureBox();
            lbUsername = new Label();
            lblWelcome = new Label();
            panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelRight.SuspendLayout();
            panelPassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPassword).BeginInit();
            panelUsername.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxUser).BeginInit();
            SuspendLayout();
            // 
            // panelLeft
            // 
            panelLeft.BackColor = Color.FromArgb(245, 247, 255);
            panelLeft.Controls.Add(lblSlogan);
            panelLeft.Controls.Add(pictureBox2);
            panelLeft.Controls.Add(lblAppName);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 0);
            panelLeft.Margin = new Padding(4, 3, 4, 3);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(387, 612);
            panelLeft.TabIndex = 0;
            // 
            // lblSlogan
            // 
            lblSlogan.AutoSize = true;
            lblSlogan.Font = new Font("Segoe UI", 14F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblSlogan.ForeColor = Color.FromArgb(192, 100, 255);
            lblSlogan.Location = new Point(89, 240);
            lblSlogan.Margin = new Padding(4, 0, 4, 0);
            lblSlogan.Name = "lblSlogan";
            lblSlogan.Size = new Size(204, 25);
            lblSlogan.TabIndex = 1;
            lblSlogan.Text = "Hệ thống quản lý thuốc";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.logo;
            pictureBox2.Location = new Point(67, 152);
            pictureBox2.Margin = new Padding(4, 3, 4, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(65, 58);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.BackColor = Color.White;
            lblAppName.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAppName.ForeColor = Color.FromArgb(128, 128, 255);
            lblAppName.Location = new Point(140, 165);
            lblAppName.Margin = new Padding(4, 0, 4, 0);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(202, 45);
            lblAppName.TabIndex = 0;
            lblAppName.Text = "PHARMACY";
            // 
            // panelRight
            // 
            panelRight.BackColor = Color.White;
            panelRight.Controls.Add(lblForgotPassword);
            panelRight.Controls.Add(btnExit);
            panelRight.Controls.Add(btnLogin);
            panelRight.Controls.Add(lkRegister);
            panelRight.Controls.Add(label5);
            panelRight.Controls.Add(chkDisplayPassword);
            panelRight.Controls.Add(panelPassword);
            panelRight.Controls.Add(panelUsername);
            panelRight.Controls.Add(lblWelcome);
            panelRight.Dock = DockStyle.Fill;
            panelRight.Location = new Point(387, 0);
            panelRight.Margin = new Padding(4, 3, 4, 3);
            panelRight.Name = "panelRight";
            panelRight.Size = new Size(605, 612);
            panelRight.TabIndex = 1;
            // 
            // lblForgotPassword
            // 
            lblForgotPassword.AutoSize = true;
            lblForgotPassword.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblForgotPassword.ForeColor = Color.FromArgb(41, 128, 185);
            lblForgotPassword.Location = new Point(309, 358);
            lblForgotPassword.Margin = new Padding(4, 0, 4, 0);
            lblForgotPassword.Name = "lblForgotPassword";
            lblForgotPassword.Size = new Size(94, 15);
            lblForgotPassword.TabIndex = 5;
            lblForgotPassword.TabStop = true;
            lblForgotPassword.Text = "Quên mật khẩu?";
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(224, 224, 224);
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.FromArgb(41, 128, 185);
            btnExit.Location = new Point(266, 398);
            btnExit.Margin = new Padding(4, 3, 4, 3);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(163, 46);
            btnExit.TabIndex = 4;
            btnExit.Text = "THOÁT";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(41, 128, 185);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(93, 398);
            btnLogin.Margin = new Padding(4, 3, 4, 3);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(163, 46);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "ĐĂNG NHẬP";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lkRegister
            // 
            lkRegister.AutoSize = true;
            lkRegister.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lkRegister.ForeColor = Color.FromArgb(41, 128, 185);
            lkRegister.Location = new Point(254, 467);
            lkRegister.Margin = new Padding(4, 0, 4, 0);
            lkRegister.Name = "lkRegister";
            lkRegister.Size = new Size(93, 17);
            lkRegister.TabIndex = 6;
            lkRegister.TabStop = true;
            lkRegister.Text = "Đăng ký ngay";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Gray;
            label5.Location = new Point(113, 467);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(142, 17);
            label5.TabIndex = 5;
            label5.Text = "Bạn chưa có tài khoản?";
            // 
            // chkDisplayPassword
            // 
            chkDisplayPassword.AutoSize = true;
            chkDisplayPassword.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkDisplayPassword.ForeColor = Color.Gray;
            chkDisplayPassword.Location = new Point(93, 358);
            chkDisplayPassword.Margin = new Padding(4, 3, 4, 3);
            chkDisplayPassword.Name = "chkDisplayPassword";
            chkDisplayPassword.Size = new Size(121, 19);
            chkDisplayPassword.TabIndex = 2;
            chkDisplayPassword.Text = "Hiển thị mật khẩu";
            chkDisplayPassword.UseVisualStyleBackColor = true;
            chkDisplayPassword.CheckedChanged += chkDisplayPassword_CheckedChanged;
            // 
            // panelPassword
            // 
            panelPassword.BackColor = Color.White;
            panelPassword.BorderStyle = BorderStyle.FixedSingle;
            panelPassword.Controls.Add(txtPassword);
            panelPassword.Controls.Add(pictureBoxPassword);
            panelPassword.Controls.Add(lblPassword);
            panelPassword.Location = new Point(88, 271);
            panelPassword.Margin = new Padding(4, 3, 4, 3);
            panelPassword.Name = "panelPassword";
            panelPassword.Size = new Size(338, 69);
            panelPassword.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.White;
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.ForeColor = Color.FromArgb(41, 128, 185);
            txtPassword.Location = new Point(64, 35);
            txtPassword.Margin = new Padding(4, 3, 4, 3);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '•';
            txtPassword.Size = new Size(268, 22);
            txtPassword.TabIndex = 0;
            // 
            // pictureBoxPassword
            // 
            pictureBoxPassword.Image = Properties.Resources.shield;
            pictureBoxPassword.Location = new Point(18, 18);
            pictureBoxPassword.Margin = new Padding(4, 3, 4, 3);
            pictureBoxPassword.Name = "pictureBoxPassword";
            pictureBoxPassword.Size = new Size(28, 28);
            pictureBoxPassword.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxPassword.TabIndex = 1;
            pictureBoxPassword.TabStop = false;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassword.ForeColor = Color.Gray;
            lblPassword.Location = new Point(61, 9);
            lblPassword.Margin = new Padding(4, 0, 4, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(67, 15);
            lblPassword.TabIndex = 0;
            lblPassword.Text = "MẬT KHẨU";
            // 
            // panelUsername
            // 
            panelUsername.BackColor = Color.White;
            panelUsername.BorderStyle = BorderStyle.FixedSingle;
            panelUsername.Controls.Add(txtUsername);
            panelUsername.Controls.Add(pictureBoxUser);
            panelUsername.Controls.Add(lbUsername);
            panelUsername.Location = new Point(88, 196);
            panelUsername.Margin = new Padding(4, 3, 4, 3);
            panelUsername.Name = "panelUsername";
            panelUsername.Size = new Size(338, 69);
            panelUsername.TabIndex = 0;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.White;
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.ForeColor = Color.FromArgb(41, 128, 185);
            txtUsername.Location = new Point(64, 35);
            txtUsername.Margin = new Padding(4, 3, 4, 3);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(268, 23);
            txtUsername.TabIndex = 0;
            // 
            // pictureBoxUser
            // 
            pictureBoxUser.Image = Properties.Resources.user;
            pictureBoxUser.Location = new Point(18, 29);
            pictureBoxUser.Margin = new Padding(4, 3, 4, 3);
            pictureBoxUser.Name = "pictureBoxUser";
            pictureBoxUser.Size = new Size(28, 28);
            pictureBoxUser.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxUser.TabIndex = 1;
            pictureBoxUser.TabStop = false;
            // 
            // lbUsername
            // 
            lbUsername.AutoSize = true;
            lbUsername.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbUsername.ForeColor = Color.Gray;
            lbUsername.Location = new Point(61, 9);
            lbUsername.Margin = new Padding(4, 0, 4, 0);
            lbUsername.Name = "lbUsername";
            lbUsername.Size = new Size(100, 15);
            lbUsername.TabIndex = 0;
            lbUsername.Text = "TÊN ĐĂNG NHẬP";
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = Color.FromArgb(41, 128, 185);
            lblWelcome.Location = new Point(166, 128);
            lblWelcome.Margin = new Padding(4, 0, 4, 0);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(181, 37);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "ĐĂNG NHẬP";
            // 
            // LoginView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(992, 612);
            Controls.Add(panelRight);
            Controls.Add(panelLeft);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            panelLeft.ResumeLayout(false);
            panelLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelRight.ResumeLayout(false);
            panelRight.PerformLayout();
            panelPassword.ResumeLayout(false);
            panelPassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPassword).EndInit();
            panelUsername.ResumeLayout(false);
            panelUsername.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxUser).EndInit();
            ResumeLayout(false);
        }

        #region Fields
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Label lblAppName;
        private System.Windows.Forms.Label lblSlogan;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Panel panelUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.PictureBox pictureBoxUser;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Panel panelPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.PictureBox pictureBoxPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.CheckBox chkDisplayPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel lkRegister;
        private System.Windows.Forms.LinkLabel lblForgotPassword;
        private System.Windows.Forms.PictureBox pictureBox2;
        #endregion

        private void chkDisplayPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = chkDisplayPassword.Checked ? '\0' : '•';
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Thêm logic đăng nhập ở đây
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

    }
}