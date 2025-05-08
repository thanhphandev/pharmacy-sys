namespace pharmacy_sys.Views.BaseForm
{
    partial class BaseAddForm
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
            panel1 = new Panel();
            lbHeader = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            btnClose = new Button();
            btnSave = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(lbHeader);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(600, 70);
            panel1.TabIndex = 0;
            // 
            // lbHeader
            // 
            lbHeader.AutoSize = true;
            lbHeader.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbHeader.Location = new Point(81, 28);
            lbHeader.Name = "lbHeader";
            lbHeader.Size = new Size(59, 20);
            lbHeader.TabIndex = 1;
            lbHeader.Text = "Header";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(54, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(btnClose);
            panel2.Controls.Add(btnSave);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 341);
            panel2.Name = "panel2";
            panel2.Size = new Size(600, 59);
            panel2.TabIndex = 0;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Red;
            btnClose.FlatAppearance.BorderColor = SystemColors.ButtonFace;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(145, 14);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(80, 33);
            btnClose.TabIndex = 0;
            btnClose.Text = "Đóng";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.DarkTurquoise;
            btnSave.FlatAppearance.BorderColor = Color.DarkTurquoise;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(33, 14);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(80, 33);
            btnSave.TabIndex = 0;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // BaseAddForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(600, 400);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "BaseAddForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thêm {item}";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label lbHeader;
        public System.Windows.Forms.Button btnClose;
        public System.Windows.Forms.Button btnSave;

    }
}