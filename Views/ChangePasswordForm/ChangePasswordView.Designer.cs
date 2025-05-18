namespace pharmacy_sys.Views.ChangePasswordForm
{
    partial class ChangePasswordView
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
            txtOldPassword = new TextBox();
            label1 = new Label();
            txtNewPassword = new TextBox();
            label2 = new Label();
            txtConfirmPassword = new TextBox();
            label3 = new Label();
            label4 = new Label();
            chkDisplayPassword = new CheckBox();
            btnCancel = new Button();
            btnChangePassword = new Button();
            SuspendLayout();
            // 
            // txtOldPassword
            // 
            txtOldPassword.Location = new Point(141, 76);
            txtOldPassword.Name = "txtOldPassword";
            txtOldPassword.PasswordChar = '●';
            txtOldPassword.Size = new Size(248, 23);
            txtOldPassword.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 79);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 1;
            label1.Text = "Mật khẩu hiện tại";
            // 
            // txtNewPassword
            // 
            txtNewPassword.Location = new Point(141, 118);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.PasswordChar = '●';
            txtNewPassword.Size = new Size(248, 23);
            txtNewPassword.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 121);
            label2.Name = "label2";
            label2.Size = new Size(81, 15);
            label2.TabIndex = 1;
            label2.Text = "Mật khẩu mới";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(141, 158);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '●';
            txtConfirmPassword.Size = new Size(248, 23);
            txtConfirmPassword.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 161);
            label3.Name = "label3";
            label3.Size = new Size(104, 15);
            label3.TabIndex = 1;
            label3.Text = "Nhập lại mật khẩu";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(128, 128, 255);
            label4.Location = new Point(157, 24);
            label4.Name = "label4";
            label4.Size = new Size(113, 21);
            label4.TabIndex = 1;
            label4.Text = "Đổi mật khẩu";
            // 
            // chkDisplayPassword
            // 
            chkDisplayPassword.AutoSize = true;
            chkDisplayPassword.Location = new Point(141, 187);
            chkDisplayPassword.Name = "chkDisplayPassword";
            chkDisplayPassword.Size = new Size(121, 19);
            chkDisplayPassword.TabIndex = 3;
            chkDisplayPassword.Text = "Hiển thị mật khẩu";
            chkDisplayPassword.UseVisualStyleBackColor = true;
            chkDisplayPassword.CheckedChanged += chkDisplayPassword_CheckedChanged;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Red;
            btnCancel.FlatAppearance.BorderColor = SystemColors.ButtonFace;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(182, 213);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(80, 33);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Đóng";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnChangePassword
            // 
            btnChangePassword.BackColor = Color.DarkTurquoise;
            btnChangePassword.FlatAppearance.BorderColor = Color.DarkTurquoise;
            btnChangePassword.FlatStyle = FlatStyle.Flat;
            btnChangePassword.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnChangePassword.ForeColor = Color.White;
            btnChangePassword.Location = new Point(297, 213);
            btnChangePassword.Name = "btnChangePassword";
            btnChangePassword.Size = new Size(80, 33);
            btnChangePassword.TabIndex = 5;
            btnChangePassword.Text = "Lưu";
            btnChangePassword.UseVisualStyleBackColor = false;
            btnChangePassword.Click += btnChangePassword_Click;
            // 
            // ChangePasswordView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(451, 273);
            Controls.Add(btnCancel);
            Controls.Add(btnChangePassword);
            Controls.Add(chkDisplayPassword);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(txtConfirmPassword);
            Controls.Add(txtNewPassword);
            Controls.Add(txtOldPassword);
            Name = "ChangePasswordView";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Đổi mật khẩu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtOldPassword;
        private Label label1;
        private TextBox txtNewPassword;
        private Label label2;
        private TextBox txtConfirmPassword;
        private Label label3;
        private Label label4;
        private CheckBox chkDisplayPassword;
        public Button btnCancel;
        public Button btnChangePassword;
    }
}