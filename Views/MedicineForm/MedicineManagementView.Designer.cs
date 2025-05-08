namespace pharmacy_sys.Views.MedicineForm
{
    partial class MedicineManagementView
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
            btnAddUnitType = new Button();
            dgvMedicines = new DataGridView();
            cbCategory = new ComboBox();
            colId = new DataGridViewTextBoxColumn();
            colCode = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colUnitType = new DataGridViewTextBoxColumn();
            colPrice = new DataGridViewTextBoxColumn();
            colCategory = new DataGridViewTextBoxColumn();
            colDetail = new DataGridViewImageColumn();
            colDelete = new DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)btnAdd).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnRefresh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvMedicines).BeginInit();
            SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(338, 63);
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(710, 62);
            btnSearch.Click += btnSearch_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(69, 61);
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(307, 63);
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnAddUnitType
            // 
            btnAddUnitType.Location = new Point(100, 63);
            btnAddUnitType.Name = "btnAddUnitType";
            btnAddUnitType.Size = new Size(113, 23);
            btnAddUnitType.TabIndex = 5;
            btnAddUnitType.Text = "Thêm đơn vị";
            btnAddUnitType.UseVisualStyleBackColor = true;
            btnAddUnitType.Click += btnAddUnitType_Click;
            // 
            // dgvMedicines
            // 
            dgvMedicines.AllowUserToAddRows = false;
            dgvMedicines.AllowUserToDeleteRows = false;
            dgvMedicines.BackgroundColor = SystemColors.ButtonHighlight;
            dgvMedicines.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMedicines.Columns.AddRange(new DataGridViewColumn[] { colId, colCode, colName, colUnitType, colPrice, colCategory, colDetail, colDelete });
            dgvMedicines.Location = new Point(69, 107);
            dgvMedicines.MultiSelect = false;
            dgvMedicines.Name = "dgvMedicines";
            dgvMedicines.ReadOnly = true;
            dgvMedicines.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMedicines.Size = new Size(833, 382);
            dgvMedicines.TabIndex = 6;
            dgvMedicines.CellClick += dgvMedicines_CellClick;
            // 
            // cbCategory
            // 
            cbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(806, 63);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(96, 23);
            cbCategory.TabIndex = 7;
            cbCategory.SelectedIndexChanged += cbCategory_SelectedIndexChanged;
            // 
            // colId
            // 
            colId.HeaderText = "ID";
            colId.Name = "colId";
            colId.ReadOnly = true;
            colId.Visible = false;
            // 
            // colCode
            // 
            colCode.FillWeight = 80F;
            colCode.HeaderText = "Mã thuốc";
            colCode.Name = "colCode";
            colCode.ReadOnly = true;
            colCode.Width = 70;
            // 
            // colName
            // 
            colName.HeaderText = "Tên thuốc";
            colName.Name = "colName";
            colName.ReadOnly = true;
            colName.Width = 200;
            // 
            // colUnitType
            // 
            colUnitType.HeaderText = "Đơn vị";
            colUnitType.Name = "colUnitType";
            colUnitType.ReadOnly = true;
            // 
            // colPrice
            // 
            colPrice.HeaderText = "Giá";
            colPrice.Name = "colPrice";
            colPrice.ReadOnly = true;
            colPrice.Width = 200;
            // 
            // colCategory
            // 
            colCategory.HeaderText = "Nhóm";
            colCategory.Name = "colCategory";
            colCategory.ReadOnly = true;
            colCategory.Width = 120;
            // 
            // colDetail
            // 
            colDetail.HeaderText = "";
            colDetail.Image = Properties.Resources.eye;
            colDetail.ImageLayout = DataGridViewImageCellLayout.Zoom;
            colDetail.Name = "colDetail";
            colDetail.ReadOnly = true;
            colDetail.Width = 50;
            // 
            // colDelete
            // 
            colDelete.HeaderText = "";
            colDelete.Image = Properties.Resources.remove;
            colDelete.ImageLayout = DataGridViewImageCellLayout.Zoom;
            colDelete.Name = "colDelete";
            colDelete.ReadOnly = true;
            colDelete.Width = 50;
            // 
            // MedicineManagementView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(963, 533);
            Controls.Add(cbCategory);
            Controls.Add(dgvMedicines);
            Controls.Add(btnAddUnitType);
            Name = "MedicineManagementView";
            Text = "MedicineManagementView";
            Load += MedicineManagementView_Load;
            Controls.SetChildIndex(txtSearch, 0);
            Controls.SetChildIndex(btnSearch, 0);
            Controls.SetChildIndex(btnAdd, 0);
            Controls.SetChildIndex(btnRefresh, 0);
            Controls.SetChildIndex(btnAddUnitType, 0);
            Controls.SetChildIndex(dgvMedicines, 0);
            Controls.SetChildIndex(cbCategory, 0);
            ((System.ComponentModel.ISupportInitialize)btnAdd).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnRefresh).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvMedicines).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnAddUnitType;
        private DataGridView dgvMedicines;
        private ComboBox cbCategory;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colCode;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colUnitType;
        private DataGridViewTextBoxColumn colPrice;
        private DataGridViewTextBoxColumn colCategory;
        private DataGridViewImageColumn colDetail;
        private DataGridViewImageColumn colDelete;
    }
}