namespace pharmacy_sys.Views.RegisterForm
{
    partial class RegisterView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterView));
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            btnExit = new Button();
            btnRegister = new Button();
            lbUsername = new Label();
            lkRegister = new LinkLabel();
            label5 = new Label();
            chkDisplayPassword = new CheckBox();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            label4 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            pictureBox3 = new PictureBox();
            txtPhone = new TextBox();
            txtFullname = new TextBox();
            label6 = new Label();
            pictureBox5 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.shield;
            pictureBox2.Location = new Point(505, 230);
            pictureBox2.Margin = new Padding(4, 3, 4, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(20, 20);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 23;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.user;
            pictureBox1.Location = new Point(505, 175);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(20, 20);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(636, 368);
            btnExit.Margin = new Padding(4, 3, 4, 3);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(88, 27);
            btnExit.TabIndex = 22;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(505, 368);
            btnRegister.Margin = new Padding(4, 3, 4, 3);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(88, 27);
            btnRegister.TabIndex = 21;
            btnRegister.Text = "Đăng ký";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // lbUsername
            // 
            lbUsername.AutoSize = true;
            lbUsername.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbUsername.Location = new Point(531, 178);
            lbUsername.Margin = new Padding(4, 0, 4, 0);
            lbUsername.Name = "lbUsername";
            lbUsername.Size = new Size(39, 17);
            lbUsername.TabIndex = 20;
            lbUsername.Text = "Email";
            // 
            // lkRegister
            // 
            lkRegister.AutoSize = true;
            lkRegister.Location = new Point(616, 402);
            lkRegister.Margin = new Padding(4, 0, 4, 0);
            lkRegister.Name = "lkRegister";
            lkRegister.Size = new Size(94, 15);
            lkRegister.TabIndex = 19;
            lkRegister.TabStop = true;
            lkRegister.Text = "Đăng nhập ngay";
            lkRegister.LinkClicked += lkRegister_LinkClicked;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(501, 402);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(116, 15);
            label5.TabIndex = 18;
            label5.Text = "Bạn đã có tài khoản?";
            // 
            // chkDisplayPassword
            // 
            chkDisplayPassword.AutoSize = true;
            chkDisplayPassword.Location = new Point(505, 337);
            chkDisplayPassword.Margin = new Padding(4, 3, 4, 3);
            chkDisplayPassword.Name = "chkDisplayPassword";
            chkDisplayPassword.Size = new Size(121, 19);
            chkDisplayPassword.TabIndex = 17;
            chkDisplayPassword.Text = "Hiển thị mật khẩu";
            chkDisplayPassword.UseVisualStyleBackColor = true;
            chkDisplayPassword.CheckedChanged += chkDisplayPassword_CheckedChanged;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(505, 201);
            txtEmail.Margin = new Padding(4, 3, 4, 3);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(255, 23);
            txtEmail.TabIndex = 15;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(505, 253);
            txtPassword.Margin = new Padding(4, 3, 4, 3);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(255, 23);
            txtPassword.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(533, 233);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(62, 17);
            label4.TabIndex = 14;
            label4.Text = "Mật khẩu";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(505, 47);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(334, 25);
            label1.TabIndex = 13;
            label1.Text = "Chào bạn! Hãy đăng ký một tài khoản";
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
            panel1.Size = new Size(475, 450);
            panel1.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(531, 288);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(31, 17);
            label2.TabIndex = 14;
            label2.Text = "SĐT";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.telephone;
            pictureBox3.Location = new Point(503, 285);
            pictureBox3.Margin = new Padding(4, 3, 4, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(20, 20);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 23;
            pictureBox3.TabStop = false;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(505, 308);
            txtPhone.Margin = new Padding(4, 3, 4, 3);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(255, 23);
            txtPhone.TabIndex = 15;
            // 
            // txtFullname
            // 
            txtFullname.Location = new Point(505, 139);
            txtFullname.Margin = new Padding(4, 3, 4, 3);
            txtFullname.Name = "txtFullname";
            txtFullname.Size = new Size(255, 23);
            txtFullname.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(533, 116);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(64, 17);
            label6.TabIndex = 20;
            label6.Text = "Họ và tên";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.plus;
            pictureBox5.Location = new Point(505, 113);
            pictureBox5.Margin = new Padding(4, 3, 4, 3);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(20, 20);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 24;
            pictureBox5.TabStop = false;
            // 
            // RegisterView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(863, 450);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox1);
            Controls.Add(btnExit);
            Controls.Add(btnRegister);
            Controls.Add(label6);
            Controls.Add(lbUsername);
            Controls.Add(lkRegister);
            Controls.Add(label5);
            Controls.Add(txtFullname);
            Controls.Add(chkDisplayPassword);
            Controls.Add(txtPhone);
            Controls.Add(txtEmail);
            Controls.Add(txtPassword);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "RegisterView";
            Text = "Đăng ký tài khoản";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Button btnExit;
        private Button btnRegister;
        private Label lbUsername;
        private LinkLabel lkRegister;
        private Label label5;
        private CheckBox chkDisplayPassword;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private Label label4;
        private Label label1;
        private Panel panel1;
        private Label label2;
        private PictureBox pictureBox3;
        private TextBox txtPhone;
        private TextBox txtFullname;
        private Label label6;
        private PictureBox pictureBox5;
    }
}