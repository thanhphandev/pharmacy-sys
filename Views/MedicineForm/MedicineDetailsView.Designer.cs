namespace pharmacy_sys.Views.MedicineForm
{
    partial class MedicineDetailsView
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
            txtComposition = new TextBox();
            txtDescription = new TextBox();
            label5 = new Label();
            label4 = new Label();
            groupBox1 = new GroupBox();
            label2 = new Label();
            cbUnitType = new ComboBox();
            btnBrowse = new Button();
            cbMedicineGroup = new ComboBox();
            label1 = new Label();
            pbMedicineImage = new PictureBox();
            txtName = new TextBox();
            label3 = new Label();
            txtCode = new TextBox();
            txtPrice = new TextBox();
            label6 = new Label();
            label8 = new Label();
            btnExport = new Button();
            btnUpdate = new Button();
            label7 = new Label();
            dgvMedicineBatches = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colQuantity = new DataGridViewTextBoxColumn();
            colManufactureDate = new DataGridViewTextBoxColumn();
            colExpirationDate = new DataGridViewTextBoxColumn();
            colSupplier = new DataGridViewTextBoxColumn();
            colEdit = new DataGridViewImageColumn();
            colDelete = new DataGridViewImageColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbMedicineImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvMedicineBatches).BeginInit();
            SuspendLayout();
            // 
            // txtComposition
            // 
            txtComposition.Location = new Point(197, 109);
            txtComposition.Multiline = true;
            txtComposition.Name = "txtComposition";
            txtComposition.Size = new Size(400, 80);
            txtComposition.TabIndex = 10;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(21, 196);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(576, 80);
            txtDescription.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(197, 89);
            label5.Name = "label5";
            label5.Size = new Size(70, 15);
            label5.TabIndex = 8;
            label5.Text = "Thành phần";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 174);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 9;
            label4.Text = "Mô tả";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(cbUnitType);
            groupBox1.Controls.Add(btnBrowse);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtDescription);
            groupBox1.Controls.Add(txtComposition);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(cbMedicineGroup);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(pbMedicineImage);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtCode);
            groupBox1.Controls.Add(txtPrice);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label8);
            groupBox1.Location = new Point(12, 32);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(800, 294);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "THÔNG TIN THUỐC";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(120, 30);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 1;
            label2.Text = "Tên thuốc";
            // 
            // cbUnitType
            // 
            cbUnitType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbUnitType.FormattingEnabled = true;
            cbUnitType.Location = new Point(284, 50);
            cbUnitType.Name = "cbUnitType";
            cbUnitType.Size = new Size(111, 23);
            cbUnitType.TabIndex = 3;
            // 
            // btnBrowse
            // 
            btnBrowse.BackColor = SystemColors.GradientInactiveCaption;
            btnBrowse.FlatAppearance.BorderColor = SystemColors.ButtonHighlight;
            btnBrowse.FlatStyle = FlatStyle.Flat;
            btnBrowse.Location = new Point(626, 206);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(150, 30);
            btnBrowse.TabIndex = 6;
            btnBrowse.Text = "Chọn ảnh";
            btnBrowse.UseVisualStyleBackColor = false;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // cbMedicineGroup
            // 
            cbMedicineGroup.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMedicineGroup.FormattingEnabled = true;
            cbMedicineGroup.Location = new Point(21, 109);
            cbMedicineGroup.Name = "cbMedicineGroup";
            cbMedicineGroup.Size = new Size(155, 23);
            cbMedicineGroup.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 30);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 1;
            label1.Text = "Mã thuốc";
            // 
            // pbMedicineImage
            // 
            pbMedicineImage.BackColor = SystemColors.InactiveBorder;
            pbMedicineImage.Location = new Point(626, 50);
            pbMedicineImage.Name = "pbMedicineImage";
            pbMedicineImage.Size = new Size(150, 150);
            pbMedicineImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pbMedicineImage.TabIndex = 5;
            pbMedicineImage.TabStop = false;
            // 
            // txtName
            // 
            txtName.Location = new Point(120, 50);
            txtName.Name = "txtName";
            txtName.Size = new Size(155, 23);
            txtName.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(284, 30);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 1;
            label3.Text = "Đơn vị";
            // 
            // txtCode
            // 
            txtCode.Location = new Point(21, 50);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(91, 23);
            txtCode.TabIndex = 2;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(411, 50);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(186, 23);
            txtPrice.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 89);
            label6.Name = "label6";
            label6.Size = new Size(75, 15);
            label6.TabIndex = 1;
            label6.Text = "Nhóm thuốc";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(411, 32);
            label8.Name = "label8";
            label8.Size = new Size(48, 15);
            label8.TabIndex = 1;
            label8.Text = "Đơn giá";
            // 
            // btnExport
            // 
            btnExport.Location = new Point(832, 54);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(96, 23);
            btnExport.TabIndex = 13;
            btnExport.Text = "Xuất thông tin";
            btnExport.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(832, 83);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 14;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(12, 341);
            label7.Name = "label7";
            label7.Size = new Size(170, 17);
            label7.TabIndex = 15;
            label7.Text = "CÁC LÔ HÀNG LIÊN QUAN";
            // 
            // dgvMedicineBatches
            // 
            dgvMedicineBatches.AllowUserToAddRows = false;
            dgvMedicineBatches.AllowUserToDeleteRows = false;
            dgvMedicineBatches.BackgroundColor = SystemColors.ButtonHighlight;
            dgvMedicineBatches.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMedicineBatches.Columns.AddRange(new DataGridViewColumn[] { colId, colQuantity, colManufactureDate, colExpirationDate, colSupplier, colEdit, colDelete });
            dgvMedicineBatches.Location = new Point(12, 361);
            dgvMedicineBatches.MultiSelect = false;
            dgvMedicineBatches.Name = "dgvMedicineBatches";
            dgvMedicineBatches.ReadOnly = true;
            dgvMedicineBatches.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMedicineBatches.Size = new Size(800, 228);
            dgvMedicineBatches.TabIndex = 16;
            dgvMedicineBatches.CellClick += dgvMedicineBatches_CellClick;
            // 
            // colId
            // 
            colId.HeaderText = "Column1";
            colId.Name = "colId";
            colId.ReadOnly = true;
            colId.Visible = false;
            // 
            // colQuantity
            // 
            colQuantity.FillWeight = 80F;
            colQuantity.HeaderText = "Số lượng";
            colQuantity.Name = "colQuantity";
            colQuantity.ReadOnly = true;
            colQuantity.Width = 130;
            // 
            // colManufactureDate
            // 
            colManufactureDate.HeaderText = "Ngày sản xuất";
            colManufactureDate.Name = "colManufactureDate";
            colManufactureDate.ReadOnly = true;
            colManufactureDate.Width = 150;
            // 
            // colExpirationDate
            // 
            colExpirationDate.HeaderText = "Ngày hết hạn";
            colExpirationDate.Name = "colExpirationDate";
            colExpirationDate.ReadOnly = true;
            colExpirationDate.Width = 150;
            // 
            // colSupplier
            // 
            colSupplier.HeaderText = "Đơn vị cung cấp";
            colSupplier.Name = "colSupplier";
            colSupplier.ReadOnly = true;
            colSupplier.Width = 265;
            // 
            // colEdit
            // 
            colEdit.HeaderText = "";
            colEdit.Image = Properties.Resources.edit;
            colEdit.ImageLayout = DataGridViewImageCellLayout.Zoom;
            colEdit.Name = "colEdit";
            colEdit.ReadOnly = true;
            colEdit.Width = 30;
            // 
            // colDelete
            // 
            colDelete.HeaderText = "";
            colDelete.Image = Properties.Resources.remove;
            colDelete.ImageLayout = DataGridViewImageCellLayout.Zoom;
            colDelete.Name = "colDelete";
            colDelete.ReadOnly = true;
            colDelete.Width = 30;
            // 
            // MedicineDetailsView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1084, 611);
            Controls.Add(dgvMedicineBatches);
            Controls.Add(label7);
            Controls.Add(btnUpdate);
            Controls.Add(btnExport);
            Controls.Add(groupBox1);
            Name = "MedicineDetailsView";
            Text = "Chi tiết thuốc";
            Load += MedicineDetailsView_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbMedicineImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvMedicineBatches).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtComposition;
        private TextBox txtDescription;
        private Label label5;
        private Label label4;
        private GroupBox groupBox1;
        private Label label2;
        private ComboBox cbUnitType;
        private Button btnBrowse;
        private ComboBox cbMedicineGroup;
        private Label label1;
        private PictureBox pbMedicineImage;
        private TextBox txtName;
        private Label label3;
        private TextBox txtCode;
        private TextBox txtPrice;
        private Label label6;
        private Label label8;
        private Button btnExport;
        private Button btnUpdate;
        private Label label7;
        private DataGridView dgvMedicineBatches;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colQuantity;
        private DataGridViewTextBoxColumn colManufactureDate;
        private DataGridViewTextBoxColumn colExpirationDate;
        private DataGridViewTextBoxColumn colSupplier;
        private DataGridViewImageColumn colEdit;
        private DataGridViewImageColumn colDelete;
    }
}