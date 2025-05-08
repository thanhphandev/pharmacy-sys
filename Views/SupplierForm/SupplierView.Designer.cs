namespace pharmacy_sys.Views.SupplierForm
{
    partial class SupplierView
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
            dgvSuppliers = new DataGridView();
            SupplierId = new DataGridViewTextBoxColumn();
            SupplierName = new DataGridViewTextBoxColumn();
            Phone = new DataGridViewTextBoxColumn();
            Address = new DataGridViewTextBoxColumn();
            dgvEdit = new DataGridViewImageColumn();
            dgvDelete = new DataGridViewImageColumn();
            btnExportData = new Button();
            btnImportData = new Button();
            ((System.ComponentModel.ISupportInitialize)btnAdd).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnRefresh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSuppliers).BeginInit();
            SuspendLayout();
            // 
            // btnSearch
            // 
            btnSearch.Click += btnSearch_Click;
            // 
            // btnAdd
            // 
            btnAdd.Image = Properties.Resources.plus;
            btnAdd.Location = new Point(81, 64);
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Image = Properties.Resources.refresh;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // dgvSuppliers
            // 
            dgvSuppliers.AllowUserToAddRows = false;
            dgvSuppliers.AllowUserToDeleteRows = false;
            dgvSuppliers.BackgroundColor = SystemColors.ButtonHighlight;
            dgvSuppliers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSuppliers.Columns.AddRange(new DataGridViewColumn[] { SupplierId, SupplierName, Phone, Address, dgvEdit, dgvDelete });
            dgvSuppliers.Location = new Point(81, 105);
            dgvSuppliers.Name = "dgvSuppliers";
            dgvSuppliers.ReadOnly = true;
            dgvSuppliers.Size = new Size(713, 270);
            dgvSuppliers.TabIndex = 4;
            dgvSuppliers.CellClick += dgvSuppliers_CellClick;
            // 
            // SupplierId
            // 
            SupplierId.FillWeight = 80F;
            SupplierId.HeaderText = "Mã";
            SupplierId.Name = "SupplierId";
            SupplierId.ReadOnly = true;
            SupplierId.Width = 70;
            // 
            // SupplierName
            // 
            SupplierName.HeaderText = "Tên";
            SupplierName.Name = "SupplierName";
            SupplierName.ReadOnly = true;
            SupplierName.Width = 120;
            // 
            // Phone
            // 
            Phone.HeaderText = "Số điện thoại";
            Phone.Name = "Phone";
            Phone.ReadOnly = true;
            Phone.Width = 120;
            // 
            // Address
            // 
            Address.HeaderText = "Địa chỉ";
            Address.Name = "Address";
            Address.ReadOnly = true;
            Address.Width = 300;
            // 
            // dgvEdit
            // 
            dgvEdit.HeaderText = "";
            dgvEdit.Image = Properties.Resources.edit;
            dgvEdit.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dgvEdit.Name = "dgvEdit";
            dgvEdit.ReadOnly = true;
            dgvEdit.Width = 30;
            // 
            // dgvDelete
            // 
            dgvDelete.HeaderText = "";
            dgvDelete.Image = Properties.Resources.remove;
            dgvDelete.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dgvDelete.Name = "dgvDelete";
            dgvDelete.ReadOnly = true;
            dgvDelete.Width = 30;
            // 
            // btnExportData
            // 
            btnExportData.Location = new Point(673, 63);
            btnExportData.Name = "btnExportData";
            btnExportData.Size = new Size(93, 23);
            btnExportData.TabIndex = 5;
            btnExportData.Text = "Xuất dữ liệu";
            btnExportData.UseVisualStyleBackColor = true;
            btnExportData.Click += btnExportData_Click;
            // 
            // btnImportData
            // 
            btnImportData.Location = new Point(673, 34);
            btnImportData.Name = "btnImportData";
            btnImportData.Size = new Size(93, 23);
            btnImportData.TabIndex = 5;
            btnImportData.Text = "Nhập dữ liệu";
            btnImportData.UseVisualStyleBackColor = true;
            btnImportData.Click += btnImportData_Click;
            // 
            // SupplierView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(895, 439);
            Controls.Add(btnImportData);
            Controls.Add(btnExportData);
            Controls.Add(dgvSuppliers);
            Name = "SupplierView";
            Text = "SupplierView";
            Load += SupplierView_Load;
            Controls.SetChildIndex(btnRefresh, 0);
            Controls.SetChildIndex(dgvSuppliers, 0);
            Controls.SetChildIndex(txtSearch, 0);
            Controls.SetChildIndex(btnSearch, 0);
            Controls.SetChildIndex(btnAdd, 0);
            Controls.SetChildIndex(btnExportData, 0);
            Controls.SetChildIndex(btnImportData, 0);
            ((System.ComponentModel.ISupportInitialize)btnAdd).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnRefresh).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSuppliers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvSuppliers;
        private DataGridViewTextBoxColumn SupplierId;
        private DataGridViewTextBoxColumn SupplierName;
        private DataGridViewTextBoxColumn Phone;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewImageColumn dgvEdit;
        private DataGridViewImageColumn dgvDelete;
        private Button btnExportData;
        private Button btnImportData;
    }
}