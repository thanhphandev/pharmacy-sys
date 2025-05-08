namespace pharmacy_sys.Views.CategoryForm
{
    partial class CategoryView
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
            txtCategoryName = new TextBox();
            groupBox1 = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            btnDelete = new Button();
            btnUpdate = new Button();
            txtDescription = new TextBox();
            btnAdd = new Button();
            dgvCategories = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colCategoryName = new DataGridViewTextBoxColumn();
            colDescription = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategories).BeginInit();
            SuspendLayout();
            // 
            // txtCategoryName
            // 
            txtCategoryName.Location = new Point(29, 41);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(403, 23);
            txtCategoryName.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnUpdate);
            groupBox1.Controls.Add(txtDescription);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(txtCategoryName);
            groupBox1.Location = new Point(39, 37);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(462, 199);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh mục thuốc";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 67);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 2;
            label3.Text = "Mô tả";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 23);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 2;
            label2.Text = "Tên danh mục";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(258, 155);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(144, 155);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Sửa";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(29, 85);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(403, 55);
            txtDescription.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(29, 155);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // dgvCategories
            // 
            dgvCategories.AllowUserToAddRows = false;
            dgvCategories.AllowUserToDeleteRows = false;
            dgvCategories.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvCategories.BackgroundColor = SystemColors.ButtonHighlight;
            dgvCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategories.Columns.AddRange(new DataGridViewColumn[] { colId, colCategoryName, colDescription });
            dgvCategories.Location = new Point(39, 242);
            dgvCategories.MultiSelect = false;
            dgvCategories.Name = "dgvCategories";
            dgvCategories.ReadOnly = true;
            dgvCategories.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategories.Size = new Size(683, 196);
            dgvCategories.TabIndex = 5;
            // 
            // colId
            // 
            colId.FillWeight = 80F;
            colId.HeaderText = "Mã";
            colId.Name = "colId";
            colId.ReadOnly = true;
            colId.Width = 70;
            // 
            // colCategoryName
            // 
            colCategoryName.HeaderText = "Tên danh mục";
            colCategoryName.Name = "colCategoryName";
            colCategoryName.ReadOnly = true;
            colCategoryName.Width = 200;
            // 
            // colDescription
            // 
            colDescription.HeaderText = "Mô tả";
            colDescription.Name = "colDescription";
            colDescription.ReadOnly = true;
            colDescription.Width = 370;
            // 
            // CategoryView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(836, 450);
            Controls.Add(dgvCategories);
            Controls.Add(groupBox1);
            Name = "CategoryView";
            Text = "CategoryView";
            Load += CategoryView_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategories).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtCategoryName;
        private GroupBox groupBox1;
        private Label label2;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private Label label3;
        private TextBox txtDescription;
        private DataGridView dgvCategories;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colCategoryName;
        private DataGridViewTextBoxColumn colDescription;
    }
}