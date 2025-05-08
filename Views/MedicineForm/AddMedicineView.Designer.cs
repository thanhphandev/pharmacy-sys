namespace pharmacy_sys.Views.MedicineForm
{
    partial class AddMedicineView
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
            label1 = new Label();
            txtCode = new TextBox();
            label2 = new Label();
            txtName = new TextBox();
            cbUnitType = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            txtDescription = new TextBox();
            label5 = new Label();
            txtComposition = new TextBox();
            label6 = new Label();
            cbMedicineGroup = new ComboBox();
            dtpExpirationDate = new DateTimePicker();
            label7 = new Label();
            pbMedicineImage = new PictureBox();
            label8 = new Label();
            txtPrice = new TextBox();
            btnBrowse = new Button();
            label9 = new Label();
            cbSupplier = new ComboBox();
            label10 = new Label();
            txtQuantity = new TextBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            dtpManufactureDate = new DateTimePicker();
            label11 = new Label();
            ((System.ComponentModel.ISupportInitialize)pbMedicineImage).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // lbHeader
            // 
            lbHeader.Size = new Size(90, 20);
            lbHeader.Text = "Thêm thuốc";
            // 
            // btnClose
            // 
            btnClose.FlatAppearance.BorderColor = SystemColors.ButtonFace;
            btnClose.Location = new Point(223, 14);
            // 
            // btnSave
            // 
            btnSave.FlatAppearance.BorderColor = Color.DarkTurquoise;
            btnSave.Size = new Size(155, 33);
            btnSave.Text = "Lưu thuốc và lô hàng";
            btnSave.Click += btnSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 30);
            label1.Name = "label1";
            label1.Size = new Size(63, 17);
            label1.TabIndex = 1;
            label1.Text = "Mã thuốc";
            // 
            // txtCode
            // 
            txtCode.Location = new Point(21, 50);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(91, 25);
            txtCode.TabIndex = 2;
            txtCode.Leave += txtCode_Leave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(120, 30);
            label2.Name = "label2";
            label2.Size = new Size(64, 17);
            label2.TabIndex = 1;
            label2.Text = "Tên thuốc";
            // 
            // txtName
            // 
            txtName.Location = new Point(120, 50);
            txtName.Name = "txtName";
            txtName.Size = new Size(155, 25);
            txtName.TabIndex = 2;
            // 
            // cbUnitType
            // 
            cbUnitType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbUnitType.FormattingEnabled = true;
            cbUnitType.Location = new Point(284, 50);
            cbUnitType.Name = "cbUnitType";
            cbUnitType.Size = new Size(111, 25);
            cbUnitType.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(284, 30);
            label3.Name = "label3";
            label3.Size = new Size(45, 17);
            label3.TabIndex = 1;
            label3.Text = "Đơn vị";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 335);
            label4.Name = "label4";
            label4.Size = new Size(43, 17);
            label4.TabIndex = 1;
            label4.Text = "Mô tả";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(33, 355);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(576, 80);
            txtDescription.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 223);
            label5.Name = "label5";
            label5.Size = new Size(76, 17);
            label5.TabIndex = 1;
            label5.Text = "Thành phần";
            // 
            // txtComposition
            // 
            txtComposition.Location = new Point(33, 243);
            txtComposition.Multiline = true;
            txtComposition.Name = "txtComposition";
            txtComposition.Size = new Size(387, 80);
            txtComposition.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 89);
            label6.Name = "label6";
            label6.Size = new Size(80, 17);
            label6.TabIndex = 1;
            label6.Text = "Nhóm thuốc";
            // 
            // cbMedicineGroup
            // 
            cbMedicineGroup.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMedicineGroup.FormattingEnabled = true;
            cbMedicineGroup.Location = new Point(21, 109);
            cbMedicineGroup.Name = "cbMedicineGroup";
            cbMedicineGroup.Size = new Size(155, 25);
            cbMedicineGroup.TabIndex = 3;
            // 
            // dtpExpirationDate
            // 
            dtpExpirationDate.Format = DateTimePickerFormat.Short;
            dtpExpirationDate.Location = new Point(106, 72);
            dtpExpirationDate.Name = "dtpExpirationDate";
            dtpExpirationDate.Size = new Size(132, 25);
            dtpExpirationDate.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(9, 80);
            label7.Name = "label7";
            label7.Size = new Size(89, 17);
            label7.TabIndex = 1;
            label7.Text = "Ngày hết hạn:";
            // 
            // pbMedicineImage
            // 
            pbMedicineImage.BackColor = SystemColors.InactiveBorder;
            pbMedicineImage.Location = new Point(424, 50);
            pbMedicineImage.Name = "pbMedicineImage";
            pbMedicineImage.Size = new Size(150, 150);
            pbMedicineImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pbMedicineImage.TabIndex = 5;
            pbMedicineImage.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(186, 89);
            label8.Name = "label8";
            label8.Size = new Size(54, 17);
            label8.TabIndex = 1;
            label8.Text = "Đơn giá";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(186, 109);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(209, 25);
            txtPrice.TabIndex = 2;
            // 
            // btnBrowse
            // 
            btnBrowse.BackColor = SystemColors.GradientInactiveCaption;
            btnBrowse.FlatAppearance.BorderColor = SystemColors.ButtonHighlight;
            btnBrowse.FlatStyle = FlatStyle.Flat;
            btnBrowse.Location = new Point(424, 206);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(150, 30);
            btnBrowse.TabIndex = 6;
            btnBrowse.Text = "Chọn ảnh";
            btnBrowse.UseVisualStyleBackColor = false;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(8, 147);
            label9.Name = "label9";
            label9.Size = new Size(92, 17);
            label9.TabIndex = 1;
            label9.Text = "Nhà cung cấp:";
            // 
            // cbSupplier
            // 
            cbSupplier.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSupplier.FormattingEnabled = true;
            cbSupplier.Location = new Point(106, 144);
            cbSupplier.Name = "cbSupplier";
            cbSupplier.Size = new Size(137, 25);
            cbSupplier.TabIndex = 3;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(31, 42);
            label10.Name = "label10";
            label10.Size = new Size(64, 17);
            label10.TabIndex = 1;
            label10.Text = "Số lượng:";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(106, 39);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(83, 25);
            txtQuantity.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(cbUnitType);
            groupBox1.Controls.Add(btnBrowse);
            groupBox1.Controls.Add(cbMedicineGroup);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(pbMedicineImage);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtCode);
            groupBox1.Controls.Add(txtPrice);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label8);
            groupBox1.Location = new Point(12, 76);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(612, 387);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "THÔNG TIN THUỐC";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cbSupplier);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(dtpManufactureDate);
            groupBox2.Controls.Add(dtpExpirationDate);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(txtQuantity);
            groupBox2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(630, 76);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(269, 247);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "THÔNG TIN LÔ THUỐC";
            // 
            // dtpManufactureDate
            // 
            dtpManufactureDate.Format = DateTimePickerFormat.Short;
            dtpManufactureDate.Location = new Point(106, 106);
            dtpManufactureDate.Name = "dtpManufactureDate";
            dtpManufactureDate.Size = new Size(132, 25);
            dtpManufactureDate.TabIndex = 4;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(6, 112);
            label11.Name = "label11";
            label11.Size = new Size(94, 17);
            label11.TabIndex = 1;
            label11.Text = "Ngày sản xuất:";
            // 
            // AddMedicineView
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(911, 541);
            Controls.Add(txtComposition);
            Controls.Add(txtDescription);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "AddMedicineView";
            Text = "Quản lý thêm thuóc";
            Load += AddMedicineView_Load;
            Controls.SetChildIndex(groupBox2, 0);
            Controls.SetChildIndex(groupBox1, 0);
            Controls.SetChildIndex(label4, 0);
            Controls.SetChildIndex(label5, 0);
            Controls.SetChildIndex(txtDescription, 0);
            Controls.SetChildIndex(txtComposition, 0);
            ((System.ComponentModel.ISupportInitialize)pbMedicineImage).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cbUnitType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtComposition;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbMedicineGroup;
        private System.Windows.Forms.DateTimePicker dtpExpirationDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pbMedicineImage;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbSupplier;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtQuantity;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DateTimePicker dtpManufactureDate;
        private Label label11;
    }
}