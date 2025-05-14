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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginView));
            label1 = new Label();
            txtPassword = new TextBox();
            label4 = new Label();
            txtEmail = new TextBox();
            chkDisplayPassword = new CheckBox();
            label5 = new Label();
            lkRegister = new LinkLabel();
            lbUsername = new Label();
            btnLogin = new Button();
            btnExit = new Button();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(516, 173);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(319, 25);
            label1.TabIndex = 1;
            label1.Text = "Chào mừng bạn! Xin mời đăng nhập";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(522, 310);
            txtPassword.Margin = new Padding(4, 3, 4, 3);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(255, 23);
            txtPassword.TabIndex = 3;
            txtPassword.Text = "thanhphanvan";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(552, 290);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(62, 17);
            label4.TabIndex = 2;
            label4.Text = "Mật khẩu";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(522, 256);
            txtEmail.Margin = new Padding(4, 3, 4, 3);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(255, 23);
            txtEmail.TabIndex = 3;
            txtEmail.Text = "thanhphanvan1610@gmail.com";
            // 
            // chkDisplayPassword
            // 
            chkDisplayPassword.AutoSize = true;
            chkDisplayPassword.Location = new Point(522, 340);
            chkDisplayPassword.Margin = new Padding(4, 3, 4, 3);
            chkDisplayPassword.Name = "chkDisplayPassword";
            chkDisplayPassword.Size = new Size(121, 19);
            chkDisplayPassword.TabIndex = 5;
            chkDisplayPassword.Text = "Hiển thị mật khẩu";
            chkDisplayPassword.UseVisualStyleBackColor = true;
            chkDisplayPassword.CheckedChanged += chkDisplayPassword_CheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(518, 402);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(129, 15);
            label5.TabIndex = 6;
            label5.Text = "Bạn chưa có tài khoản?";
            // 
            // lkRegister
            // 
            lkRegister.AutoSize = true;
            lkRegister.Location = new Point(644, 402);
            lkRegister.Margin = new Padding(4, 0, 4, 0);
            lkRegister.Name = "lkRegister";
            lkRegister.Size = new Size(79, 15);
            lkRegister.TabIndex = 7;
            lkRegister.TabStop = true;
            lkRegister.Text = "Đăng ký ngay";
            lkRegister.LinkClicked += lkRegister_LinkClicked;
            // 
            // lbUsername
            // 
            lbUsername.AutoSize = true;
            lbUsername.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbUsername.Location = new Point(552, 233);
            lbUsername.Margin = new Padding(4, 0, 4, 0);
            lbUsername.Name = "lbUsername";
            lbUsername.Size = new Size(39, 17);
            lbUsername.TabIndex = 8;
            lbUsername.Text = "Email";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(522, 368);
            btnLogin.Margin = new Padding(4, 3, 4, 3);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(88, 27);
            btnLogin.TabIndex = 9;
            btnLogin.Text = "Đăng nhập";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(653, 368);
            btnExit.Margin = new Padding(4, 3, 4, 3);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(88, 27);
            btnExit.TabIndex = 10;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.shield;
            pictureBox2.Location = new Point(522, 287);
            pictureBox2.Margin = new Padding(4, 3, 4, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(20, 20);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.user;
            pictureBox1.Location = new Point(522, 230);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(20, 20);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(227, 242, 253);
            panel1.BackgroundImage = Properties.Resources.bg_pharmacy;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Dock = DockStyle.Left;
            panel1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(475, 532);
            panel1.TabIndex = 0;
            // 
            // LoginView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(252, 250, 250);
            ClientSize = new Size(915, 532);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnExit);
            Controls.Add(btnLogin);
            Controls.Add(lbUsername);
            Controls.Add(lkRegister);
            Controls.Add(label5);
            Controls.Add(chkDisplayPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtPassword);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximumSize = new Size(931, 571);
            Name = "LoginView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập tài khoản";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.CheckBox chkDisplayPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel lkRegister;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}