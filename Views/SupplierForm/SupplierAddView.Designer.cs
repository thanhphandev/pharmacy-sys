namespace pharmacy_sys.Views.SupplierForm
{
    partial class SupplierAddView
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
            txtSupplierName = new TextBox();
            label1 = new Label();
            txtPhone = new TextBox();
            label2 = new Label();
            txtAddress = new RichTextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // lbHeader
            // 
            lbHeader.ForeColor = Color.FromArgb(128, 128, 255);
            lbHeader.Location = new Point(72, 27);
            lbHeader.Size = new Size(143, 20);
            lbHeader.Text = "Thêm nhà cung cấp";
            // 
            // btnClose
            // 
            btnClose.FlatAppearance.BorderColor = SystemColors.ButtonFace;
            btnClose.Location = new Point(135, 14);
            // 
            // btnSave
            // 
            btnSave.FlatAppearance.BorderColor = Color.DarkTurquoise;
            btnSave.Click += btnSave_Click;
            // 
            // txtSupplierName
            // 
            txtSupplierName.BackColor = Color.White;
            txtSupplierName.ForeColor = SystemColors.ControlText;
            txtSupplierName.Location = new Point(33, 112);
            txtSupplierName.Name = "txtSupplierName";
            txtSupplierName.Size = new Size(195, 25);
            txtSupplierName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 92);
            label1.Name = "label1";
            label1.Size = new Size(110, 17);
            label1.TabIndex = 2;
            label1.Text = "Tên nhà cung cấp";
            // 
            // txtPhone
            // 
            txtPhone.BackColor = Color.White;
            txtPhone.ForeColor = SystemColors.ControlText;
            txtPhone.Location = new Point(244, 112);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(274, 25);
            txtPhone.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(244, 92);
            label2.Name = "label2";
            label2.Size = new Size(85, 17);
            label2.TabIndex = 2;
            label2.Text = "Số điện thoại";
            // 
            // txtAddress
            // 
            txtAddress.ForeColor = SystemColors.ActiveCaptionText;
            txtAddress.Location = new Point(33, 165);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(485, 85);
            txtAddress.TabIndex = 3;
            txtAddress.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 145);
            label3.Name = "label3";
            label3.Size = new Size(47, 17);
            label3.TabIndex = 2;
            label3.Text = "Địa chỉ";
            // 
            // SupplierAddView
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(550, 339);
            Controls.Add(txtAddress);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtPhone);
            Controls.Add(label1);
            Controls.Add(txtSupplierName);
            ForeColor = SystemColors.WindowText;
            Name = "SupplierAddView";
            Text = "SupplierAddView";
            Controls.SetChildIndex(txtSupplierName, 0);
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(txtPhone, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(txtAddress, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSupplierName;
        private Label label1;
        private TextBox txtPhone;
        private Label label2;
        private RichTextBox txtAddress;
        private Label label3;
    }
}