namespace pharmacy_sys.Views.BillForm
{
    partial class BillsView
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
            dgvBills = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colCode = new DataGridViewTextBoxColumn();
            colCreatedAt = new DataGridViewTextBoxColumn();
            colAmount = new DataGridViewTextBoxColumn();
            colNote = new DataGridViewTextBoxColumn();
            colStaff = new DataGridViewTextBoxColumn();
            colView = new DataGridViewImageColumn();
            colDelete = new DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)btnAdd).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnRefresh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvBills).BeginInit();
            SuspendLayout();
            // 
            // btnSearch
            // 
            btnSearch.Click += btnSearch_Click;
            // 
            // btnAdd
            // 
            btnAdd.Visible = false;
            // 
            // btnRefresh
            // 
            btnRefresh.Click += btnRefresh_Click;
            // 
            // dgvBills
            // 
            dgvBills.AllowUserToAddRows = false;
            dgvBills.AllowUserToDeleteRows = false;
            dgvBills.BackgroundColor = SystemColors.ButtonHighlight;
            dgvBills.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBills.Columns.AddRange(new DataGridViewColumn[] { colId, colCode, colCreatedAt, colAmount, colNote, colStaff, colView, colDelete });
            dgvBills.Location = new Point(67, 95);
            dgvBills.MultiSelect = false;
            dgvBills.Name = "dgvBills";
            dgvBills.ReadOnly = true;
            dgvBills.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBills.Size = new Size(810, 328);
            dgvBills.TabIndex = 17;
            dgvBills.CellClick += dgvBills_CellClick;
            // 
            // colId
            // 
            colId.HeaderText = "#";
            colId.Name = "colId";
            colId.ReadOnly = true;
            colId.Visible = false;
            // 
            // colCode
            // 
            colCode.FillWeight = 80F;
            colCode.HeaderText = "Mã đơn";
            colCode.Name = "colCode";
            colCode.ReadOnly = true;
            colCode.Width = 130;
            // 
            // colCreatedAt
            // 
            colCreatedAt.HeaderText = "Ngày tạo";
            colCreatedAt.Name = "colCreatedAt";
            colCreatedAt.ReadOnly = true;
            colCreatedAt.Width = 150;
            // 
            // colAmount
            // 
            colAmount.HeaderText = "Tổng tiền";
            colAmount.Name = "colAmount";
            colAmount.ReadOnly = true;
            colAmount.Width = 150;
            // 
            // colNote
            // 
            colNote.HeaderText = "Ghi chú";
            colNote.Name = "colNote";
            colNote.ReadOnly = true;
            colNote.Width = 180;
            // 
            // colStaff
            // 
            colStaff.HeaderText = "Người lập";
            colStaff.Name = "colStaff";
            colStaff.ReadOnly = true;
            // 
            // colView
            // 
            colView.HeaderText = "";
            colView.Image = Properties.Resources.eye;
            colView.ImageLayout = DataGridViewImageCellLayout.Zoom;
            colView.Name = "colView";
            colView.ReadOnly = true;
            colView.Width = 30;
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
            // BillsView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(889, 450);
            Controls.Add(dgvBills);
            Name = "BillsView";
            Text = "BillsView";
            Load += BillsView_Load;
            Controls.SetChildIndex(txtSearch, 0);
            Controls.SetChildIndex(btnSearch, 0);
            Controls.SetChildIndex(btnAdd, 0);
            Controls.SetChildIndex(btnRefresh, 0);
            Controls.SetChildIndex(dgvBills, 0);
            ((System.ComponentModel.ISupportInitialize)btnAdd).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnRefresh).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvBills).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvBills;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colCode;
        private DataGridViewTextBoxColumn colCreatedAt;
        private DataGridViewTextBoxColumn colAmount;
        private DataGridViewTextBoxColumn colNote;
        private DataGridViewTextBoxColumn colStaff;
        private DataGridViewImageColumn colView;
        private DataGridViewImageColumn colDelete;
    }
}