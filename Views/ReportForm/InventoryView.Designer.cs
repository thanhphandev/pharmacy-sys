namespace pharmacy_sys.Views.ReportForm
{
    partial class InventoryView
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
            dgvExpiringMedicines = new DataGridView();
            colName = new DataGridViewTextBoxColumn();
            colQuantity = new DataGridViewTextBoxColumn();
            colExpiredDate = new DataGridViewTextBoxColumn();
            colCategory = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            dgvLowStock = new DataGridView();
            colName2 = new DataGridViewTextBoxColumn();
            colQuantity2 = new DataGridViewTextBoxColumn();
            colCategory2 = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            txtLowStock = new TextBox();
            txtExpired = new TextBox();
            txtMedicineBatch = new TextBox();
            txtMedicine = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label8 = new Label();
            btnRefresh = new Button();
            btnPrintReport = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvExpiringMedicines).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvLowStock).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvExpiringMedicines
            // 
            dgvExpiringMedicines.AllowUserToAddRows = false;
            dgvExpiringMedicines.AllowUserToDeleteRows = false;
            dgvExpiringMedicines.BackgroundColor = SystemColors.ButtonHighlight;
            dgvExpiringMedicines.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvExpiringMedicines.Columns.AddRange(new DataGridViewColumn[] { colName, colQuantity, colExpiredDate, colCategory });
            dgvExpiringMedicines.Location = new Point(12, 253);
            dgvExpiringMedicines.MultiSelect = false;
            dgvExpiringMedicines.Name = "dgvExpiringMedicines";
            dgvExpiringMedicines.ReadOnly = true;
            dgvExpiringMedicines.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvExpiringMedicines.Size = new Size(603, 328);
            dgvExpiringMedicines.TabIndex = 28;
            // 
            // colName
            // 
            colName.FillWeight = 80F;
            colName.HeaderText = "Tên thuốc";
            colName.Name = "colName";
            colName.ReadOnly = true;
            colName.Width = 150;
            // 
            // colQuantity
            // 
            colQuantity.HeaderText = "SL";
            colQuantity.Name = "colQuantity";
            colQuantity.ReadOnly = true;
            colQuantity.Width = 50;
            // 
            // colExpiredDate
            // 
            colExpiredDate.HeaderText = "Hạn dùng";
            colExpiredDate.Name = "colExpiredDate";
            colExpiredDate.ReadOnly = true;
            colExpiredDate.Width = 180;
            // 
            // colCategory
            // 
            colCategory.HeaderText = "Nhóm thuốc";
            colCategory.Name = "colCategory";
            colCategory.ReadOnly = true;
            colCategory.Width = 180;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 235);
            label1.Name = "label1";
            label1.Size = new Size(104, 15);
            label1.TabIndex = 29;
            label1.Text = "Thuốc sắp hết hạn";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(619, 235);
            label2.Name = "label2";
            label2.Size = new Size(170, 15);
            label2.TabIndex = 31;
            label2.Text = "Thuốc gần hết hàng (số lượng)";
            // 
            // dgvLowStock
            // 
            dgvLowStock.AllowUserToAddRows = false;
            dgvLowStock.AllowUserToDeleteRows = false;
            dgvLowStock.BackgroundColor = SystemColors.ButtonHighlight;
            dgvLowStock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLowStock.Columns.AddRange(new DataGridViewColumn[] { colName2, colQuantity2, colCategory2 });
            dgvLowStock.Location = new Point(619, 255);
            dgvLowStock.MultiSelect = false;
            dgvLowStock.Name = "dgvLowStock";
            dgvLowStock.ReadOnly = true;
            dgvLowStock.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLowStock.Size = new Size(554, 326);
            dgvLowStock.TabIndex = 30;
            // 
            // colName2
            // 
            colName2.FillWeight = 80F;
            colName2.HeaderText = "Tên thuốc";
            colName2.Name = "colName2";
            colName2.ReadOnly = true;
            colName2.Width = 180;
            // 
            // colQuantity2
            // 
            colQuantity2.HeaderText = "SL";
            colQuantity2.Name = "colQuantity2";
            colQuantity2.ReadOnly = true;
            colQuantity2.Width = 150;
            // 
            // colCategory2
            // 
            colCategory2.HeaderText = "Nhóm thuốc";
            colCategory2.Name = "colCategory2";
            colCategory2.ReadOnly = true;
            colCategory2.Width = 180;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtLowStock);
            groupBox1.Controls.Add(txtExpired);
            groupBox1.Controls.Add(txtMedicineBatch);
            groupBox1.Controls.Add(txtMedicine);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(12, 84);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(603, 131);
            groupBox1.TabIndex = 32;
            groupBox1.TabStop = false;
            // 
            // txtLowStock
            // 
            txtLowStock.Location = new Point(481, 75);
            txtLowStock.Name = "txtLowStock";
            txtLowStock.ReadOnly = true;
            txtLowStock.Size = new Size(113, 23);
            txtLowStock.TabIndex = 1;
            // 
            // txtExpired
            // 
            txtExpired.Location = new Point(167, 72);
            txtExpired.Name = "txtExpired";
            txtExpired.ReadOnly = true;
            txtExpired.Size = new Size(113, 23);
            txtExpired.TabIndex = 1;
            // 
            // txtMedicineBatch
            // 
            txtMedicineBatch.Location = new Point(481, 29);
            txtMedicineBatch.Name = "txtMedicineBatch";
            txtMedicineBatch.ReadOnly = true;
            txtMedicineBatch.Size = new Size(113, 23);
            txtMedicineBatch.TabIndex = 1;
            // 
            // txtMedicine
            // 
            txtMedicine.Location = new Point(167, 29);
            txtMedicine.Name = "txtMedicine";
            txtMedicine.ReadOnly = true;
            txtMedicine.Size = new Size(113, 23);
            txtMedicine.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(380, 78);
            label7.Name = "label7";
            label7.Size = new Size(95, 15);
            label7.TabIndex = 0;
            label7.Text = "Só lượng ít (<10)";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(386, 37);
            label6.Name = "label6";
            label6.Size = new Size(89, 15);
            label6.TabIndex = 0;
            label6.Text = "Tổng lượng tồn";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(48, 78);
            label5.Name = "label5";
            label5.Size = new Size(113, 15);
            label5.TabIndex = 0;
            label5.Text = "Số thuốc đã hết hạn";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(56, 32);
            label4.Name = "label4";
            label4.Size = new Size(105, 15);
            label4.TabIndex = 0;
            label4.Text = "Tổng số loại thuốc";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 66);
            label8.Name = "label8";
            label8.Size = new Size(171, 15);
            label8.TabIndex = 33;
            label8.Text = "THÔNG SỐ THUỐC HỆ THỐNG";
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(361, 58);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(75, 23);
            btnRefresh.TabIndex = 26;
            btnRefresh.Text = "Làm mới";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnPrintReport
            // 
            btnPrintReport.Location = new Point(540, 58);
            btnPrintReport.Name = "btnPrintReport";
            btnPrintReport.Size = new Size(75, 23);
            btnPrintReport.TabIndex = 26;
            btnPrintReport.Text = "In báo cáo";
            btnPrintReport.UseVisualStyleBackColor = true;
            btnPrintReport.Click += btnPrintReport_Click;
            // 
            // InventoryView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1234, 611);
            Controls.Add(label8);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(dgvLowStock);
            Controls.Add(label1);
            Controls.Add(dgvExpiringMedicines);
            Controls.Add(btnPrintReport);
            Controls.Add(btnRefresh);
            Name = "InventoryView";
            Text = "InventoryView";
            Load += InventoryView_Load;
            ((System.ComponentModel.ISupportInitialize)dgvExpiringMedicines).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvLowStock).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvExpiringMedicines;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colQuantity;
        private DataGridViewTextBoxColumn colExpiredDate;
        private DataGridViewTextBoxColumn colCategory;
        private Label label1;
        private Label label2;
        private DataGridView dgvLowStock;
        private GroupBox groupBox1;
        private TextBox txtLowStock;
        private TextBox txtExpired;
        private TextBox txtMedicineBatch;
        private TextBox txtMedicine;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label8;
        private DataGridViewTextBoxColumn colName2;
        private DataGridViewTextBoxColumn colQuantity2;
        private DataGridViewTextBoxColumn colCategory2;
        private Button btnRefresh;
        private Button btnPrintReport;
    }
}