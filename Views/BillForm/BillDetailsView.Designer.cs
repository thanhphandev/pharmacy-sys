namespace pharmacy_sys.Views.BillForm
{
    partial class BillDetailsView
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
            label2 = new Label();
            btnExport = new Button();
            label1 = new Label();
            groupBox1 = new GroupBox();
            dgvBillDetails = new DataGridView();
            lbGrandAmount = new Label();
            lbVAT = new Label();
            lbAmount = new Label();
            btnUpdate = new Button();
            dtpCreatedAt = new DateTimePicker();
            label7 = new Label();
            label5 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtNote = new TextBox();
            label6 = new Label();
            txtStaffName = new TextBox();
            txtCode = new TextBox();
            colId = new DataGridViewTextBoxColumn();
            colCode = new DataGridViewTextBoxColumn();
            colMedicineName = new DataGridViewTextBoxColumn();
            colQuantity = new DataGridViewTextBoxColumn();
            colUnitType = new DataGridViewTextBoxColumn();
            colPrice = new DataGridViewTextBoxColumn();
            colAmount = new DataGridViewTextBoxColumn();
            colDelete = new DataGridViewImageColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBillDetails).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(163, 28);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 1;
            label2.Text = "Ngày tạo";
            // 
            // btnExport
            // 
            btnExport.Location = new Point(693, 22);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(96, 23);
            btnExport.TabIndex = 18;
            btnExport.Text = "In hóa đơn";
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 26);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 1;
            label1.Text = "Mã đơn";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvBillDetails);
            groupBox1.Controls.Add(lbGrandAmount);
            groupBox1.Controls.Add(lbVAT);
            groupBox1.Controls.Add(lbAmount);
            groupBox1.Controls.Add(btnUpdate);
            groupBox1.Controls.Add(btnExport);
            groupBox1.Controls.Add(dtpCreatedAt);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtNote);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtStaffName);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtCode);
            groupBox1.Location = new Point(12, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(842, 435);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "THÔNG TIN ĐƠN HÀNG";
            // 
            // dgvBillDetails
            // 
            dgvBillDetails.AllowUserToAddRows = false;
            dgvBillDetails.AllowUserToDeleteRows = false;
            dgvBillDetails.AllowUserToOrderColumns = true;
            dgvBillDetails.AllowUserToResizeColumns = false;
            dgvBillDetails.AllowUserToResizeRows = false;
            dgvBillDetails.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            dgvBillDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBillDetails.BackgroundColor = SystemColors.ButtonHighlight;
            dgvBillDetails.BorderStyle = BorderStyle.None;
            dgvBillDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBillDetails.Columns.AddRange(new DataGridViewColumn[] { colId, colCode, colMedicineName, colQuantity, colUnitType, colPrice, colAmount, colDelete });
            dgvBillDetails.Location = new Point(21, 82);
            dgvBillDetails.Name = "dgvBillDetails";
            dgvBillDetails.RowTemplate.Height = 30;
            dgvBillDetails.Size = new Size(768, 238);
            dgvBillDetails.TabIndex = 23;
            dgvBillDetails.CellClick += dgvBillDetails_CellClick;
            dgvBillDetails.CellValueChanged += dgvBillDetails_CellValueChanged;
            // 
            // lbGrandAmount
            // 
            lbGrandAmount.AutoSize = true;
            lbGrandAmount.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbGrandAmount.Location = new Point(731, 381);
            lbGrandAmount.Name = "lbGrandAmount";
            lbGrandAmount.Size = new Size(43, 17);
            lbGrandAmount.TabIndex = 22;
            lbGrandAmount.Text = "label4";
            // 
            // lbVAT
            // 
            lbVAT.AutoSize = true;
            lbVAT.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbVAT.Location = new Point(731, 356);
            lbVAT.Name = "lbVAT";
            lbVAT.Size = new Size(43, 17);
            lbVAT.TabIndex = 22;
            lbVAT.Text = "label4";
            // 
            // lbAmount
            // 
            lbAmount.AutoSize = true;
            lbAmount.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbAmount.Location = new Point(731, 331);
            lbAmount.Name = "lbAmount";
            lbAmount.Size = new Size(43, 17);
            lbAmount.TabIndex = 22;
            lbAmount.Text = "label4";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(714, 53);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 19;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // dtpCreatedAt
            // 
            dtpCreatedAt.Format = DateTimePickerFormat.Short;
            dtpCreatedAt.Location = new Point(163, 46);
            dtpCreatedAt.Name = "dtpCreatedAt";
            dtpCreatedAt.Size = new Size(113, 23);
            dtpCreatedAt.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(128, 128, 255);
            label7.Location = new Point(582, 375);
            label7.Name = "label7";
            label7.Size = new Size(109, 25);
            label7.TabIndex = 1;
            label7.Text = "Tổng cộng";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(128, 128, 255);
            label5.Location = new Point(608, 327);
            label5.Name = "label5";
            label5.Size = new Size(83, 21);
            label5.TabIndex = 1;
            label5.Text = "Tổng tiền";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(128, 128, 255);
            label3.Location = new Point(644, 350);
            label3.Name = "label3";
            label3.Size = new Size(47, 25);
            label3.TabIndex = 1;
            label3.Text = "VAT";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(282, 28);
            label4.Name = "label4";
            label4.Size = new Size(48, 15);
            label4.TabIndex = 1;
            label4.Text = "Ghi chú";
            // 
            // txtNote
            // 
            txtNote.Location = new Point(282, 46);
            txtNote.Name = "txtNote";
            txtNote.Size = new Size(191, 23);
            txtNote.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(479, 30);
            label6.Name = "label6";
            label6.Size = new Size(59, 15);
            label6.TabIndex = 1;
            label6.Text = "Người lập";
            // 
            // txtStaffName
            // 
            txtStaffName.Location = new Point(479, 46);
            txtStaffName.Name = "txtStaffName";
            txtStaffName.ReadOnly = true;
            txtStaffName.Size = new Size(180, 23);
            txtStaffName.TabIndex = 2;
            // 
            // txtCode
            // 
            txtCode.Location = new Point(21, 46);
            txtCode.Name = "txtCode";
            txtCode.ReadOnly = true;
            txtCode.Size = new Size(136, 23);
            txtCode.TabIndex = 2;
            // 
            // colId
            // 
            colId.HeaderText = "ID";
            colId.Name = "colId";
            colId.Visible = false;
            // 
            // colCode
            // 
            colCode.FillWeight = 42.3801231F;
            colCode.HeaderText = "Mã";
            colCode.Name = "colCode";
            colCode.ReadOnly = true;
            // 
            // colMedicineName
            // 
            colMedicineName.FillWeight = 123.142769F;
            colMedicineName.HeaderText = "Tên";
            colMedicineName.Name = "colMedicineName";
            colMedicineName.ReadOnly = true;
            // 
            // colQuantity
            // 
            colQuantity.FillWeight = 25.4262581F;
            colQuantity.HeaderText = "SL";
            colQuantity.Name = "colQuantity";
            // 
            // colUnitType
            // 
            colUnitType.FillWeight = 62.01467F;
            colUnitType.HeaderText = "Đơn vị";
            colUnitType.Name = "colUnitType";
            colUnitType.ReadOnly = true;
            // 
            // colPrice
            // 
            colPrice.FillWeight = 68.97677F;
            colPrice.HeaderText = "Giá";
            colPrice.Name = "colPrice";
            colPrice.ReadOnly = true;
            // 
            // colAmount
            // 
            colAmount.FillWeight = 63.1676025F;
            colAmount.HeaderText = "S.tiền";
            colAmount.Name = "colAmount";
            colAmount.ReadOnly = true;
            // 
            // colDelete
            // 
            colDelete.FillWeight = 22.121439F;
            colDelete.HeaderText = "";
            colDelete.Image = Properties.Resources.remove;
            colDelete.ImageLayout = DataGridViewImageCellLayout.Zoom;
            colDelete.MinimumWidth = 10;
            colDelete.Name = "colDelete";
            colDelete.ReadOnly = true;
            colDelete.Resizable = DataGridViewTriState.True;
            // 
            // BillDetailsView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(866, 450);
            Controls.Add(groupBox1);
            Name = "BillDetailsView";
            Text = "BillDetailsView";
            Load += BillDetailsView_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBillDetails).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label2;
        private Button btnExport;
        private Label label1;
        private GroupBox groupBox1;
        private TextBox txtCode;
        private Label lbAmount;
        private DateTimePicker dtpCreatedAt;
        private Label label5;
        private Label label3;
        private Label label7;
        private Label label4;
        private TextBox txtNote;
        private Button btnUpdate;
        private Label label6;
        private TextBox txtStaffName;
        private DataGridView dgvBillDetails;
        private Label lbGrandAmount;
        private Label lbVAT;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colCode;
        private DataGridViewTextBoxColumn colMedicineName;
        private DataGridViewTextBoxColumn colQuantity;
        private DataGridViewTextBoxColumn colUnitType;
        private DataGridViewTextBoxColumn colPrice;
        private DataGridViewTextBoxColumn colAmount;
        private DataGridViewImageColumn colDelete;
    }
}