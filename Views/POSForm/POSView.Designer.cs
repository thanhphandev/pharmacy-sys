namespace pharmacy_sys.Views.POSForm
{
    partial class POSView
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
            btnRefresh = new Button();
            label5 = new Label();
            label4 = new Label();
            cbFilterPrice = new ComboBox();
            cbCategory = new ComboBox();
            btnDashboard = new PictureBox();
            btnSearch = new PictureBox();
            txtSearch = new TextBox();
            btnLogout = new PictureBox();
            panel3 = new Panel();
            panel2 = new Panel();
            btnCancel = new Button();
            btnPayment = new Button();
            txtTotal = new Label();
            txtChange = new Label();
            txtVAT = new Label();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            CartItemsDataGrid = new DataGridView();
            Index = new DataGridViewTextBoxColumn();
            dgvId = new DataGridViewTextBoxColumn();
            dgvCode = new DataGridViewTextBoxColumn();
            dgvUnitType = new DataGridViewTextBoxColumn();
            dgvName = new DataGridViewTextBoxColumn();
            dgvQuantity = new DataGridViewTextBoxColumn();
            dgvPrice = new DataGridViewTextBoxColumn();
            dgvAmount = new DataGridViewTextBoxColumn();
            dgvDelete = new DataGridViewImageColumn();
            MedicineProductPanel = new FlowLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            dataGridViewImageColumn1 = new DataGridViewImageColumn();
            label6 = new Label();
            txtCustomer = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnDashboard).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnSearch).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnLogout).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CartItemsDataGrid).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(btnRefresh);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(cbFilterPrice);
            panel1.Controls.Add(cbCategory);
            panel1.Controls.Add(btnDashboard);
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(txtSearch);
            panel1.Controls.Add(btnLogout);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1234, 66);
            panel1.TabIndex = 3;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(833, 32);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(75, 23);
            btnRefresh.TabIndex = 11;
            btnRefresh.Text = "Làm mói";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(221, 35);
            label5.Name = "label5";
            label5.Size = new Size(66, 17);
            label5.TabIndex = 10;
            label5.Text = "Danh mục";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 33);
            label4.Name = "label4";
            label4.Size = new Size(75, 17);
            label4.TabIndex = 9;
            label4.Text = "Khoảng giá";
            // 
            // cbFilterPrice
            // 
            cbFilterPrice.FormattingEnabled = true;
            cbFilterPrice.Location = new Point(93, 31);
            cbFilterPrice.Name = "cbFilterPrice";
            cbFilterPrice.Size = new Size(99, 25);
            cbFilterPrice.TabIndex = 8;
            cbFilterPrice.SelectedIndexChanged += cbFilterPrice_SelectedIndexChanged;
            // 
            // cbCategory
            // 
            cbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCategory.FlatStyle = FlatStyle.Flat;
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(293, 30);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(100, 25);
            cbCategory.TabIndex = 7;
            cbCategory.SelectedIndexChanged += cbCategory_SelectedIndexChanged;
            // 
            // btnDashboard
            // 
            btnDashboard.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDashboard.Cursor = Cursors.Hand;
            btnDashboard.Location = new Point(1144, 17);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(30, 30);
            btnDashboard.SizeMode = PictureBoxSizeMode.StretchImage;
            btnDashboard.TabIndex = 6;
            btnDashboard.TabStop = false;
            // 
            // btnSearch
            // 
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.Image = Properties.Resources.search;
            btnSearch.Location = new Point(784, 30);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(26, 26);
            btnSearch.SizeMode = PictureBoxSizeMode.StretchImage;
            btnSearch.TabIndex = 5;
            btnSearch.TabStop = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(411, 31);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(367, 25);
            txtSearch.TabIndex = 4;
            // 
            // btnLogout
            // 
            btnLogout.Anchor = AnchorStyles.Right;
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.Location = new Point(1192, 17);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(30, 30);
            btnLogout.SizeMode = PictureBoxSizeMode.StretchImage;
            btnLogout.TabIndex = 2;
            btnLogout.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlLight;
            panel3.Controls.Add(panel2);
            panel3.Controls.Add(CartItemsDataGrid);
            panel3.Controls.Add(MedicineProductPanel);
            panel3.Controls.Add(flowLayoutPanel1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.MinimumSize = new Size(850, 500);
            panel3.Name = "panel3";
            panel3.Size = new Size(1234, 611);
            panel3.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panel2.Controls.Add(txtCustomer);
            panel2.Controls.Add(btnCancel);
            panel2.Controls.Add(btnPayment);
            panel2.Controls.Add(txtTotal);
            panel2.Controls.Add(txtChange);
            panel2.Controls.Add(txtVAT);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(712, 401);
            panel2.Name = "panel2";
            panel2.Size = new Size(522, 178);
            panel2.TabIndex = 10;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.GhostWhite;
            btnCancel.FlatAppearance.BorderColor = Color.GhostWhite;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.Red;
            btnCancel.Location = new Point(69, 127);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(127, 30);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnPayment
            // 
            btnPayment.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnPayment.BackColor = Color.Blue;
            btnPayment.FlatAppearance.BorderColor = Color.Blue;
            btnPayment.FlatStyle = FlatStyle.Flat;
            btnPayment.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPayment.ForeColor = Color.White;
            btnPayment.Location = new Point(298, 127);
            btnPayment.Name = "btnPayment";
            btnPayment.Size = new Size(127, 30);
            btnPayment.TabIndex = 2;
            btnPayment.Text = "Thanh toán";
            btnPayment.UseVisualStyleBackColor = false;
            btnPayment.Click += btnPayment_Click;
            // 
            // txtTotal
            // 
            txtTotal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtTotal.AutoSize = true;
            txtTotal.Location = new Point(435, 16);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(27, 17);
            txtTotal.TabIndex = 1;
            txtTotal.Text = "0 đ";
            // 
            // txtChange
            // 
            txtChange.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtChange.AutoSize = true;
            txtChange.Location = new Point(435, 62);
            txtChange.Name = "txtChange";
            txtChange.Size = new Size(27, 17);
            txtChange.TabIndex = 1;
            txtChange.Text = "0 đ";
            // 
            // txtVAT
            // 
            txtVAT.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtVAT.AutoSize = true;
            txtVAT.Location = new Point(435, 37);
            txtVAT.Name = "txtVAT";
            txtVAT.Size = new Size(27, 17);
            txtVAT.TabIndex = 1;
            txtVAT.Text = "0 đ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            label3.ForeColor = SystemColors.HotTrack;
            label3.Location = new Point(15, 35);
            label3.Name = "label3";
            label3.Size = new Size(68, 19);
            label3.TabIndex = 0;
            label3.Text = "VAT (8%)";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(15, 61);
            label1.Name = "label1";
            label1.Size = new Size(71, 19);
            label1.TabIndex = 0;
            label1.Text = "Tạm tính:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            label2.ForeColor = SystemColors.HotTrack;
            label2.Location = new Point(15, 14);
            label2.Name = "label2";
            label2.Size = new Size(106, 19);
            label2.TabIndex = 0;
            label2.Text = "Tổng hóa đơn:";
            // 
            // CartItemsDataGrid
            // 
            CartItemsDataGrid.AllowUserToAddRows = false;
            CartItemsDataGrid.AllowUserToDeleteRows = false;
            CartItemsDataGrid.AllowUserToOrderColumns = true;
            CartItemsDataGrid.AllowUserToResizeColumns = false;
            CartItemsDataGrid.AllowUserToResizeRows = false;
            CartItemsDataGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            CartItemsDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            CartItemsDataGrid.BackgroundColor = SystemColors.ButtonHighlight;
            CartItemsDataGrid.BorderStyle = BorderStyle.None;
            CartItemsDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CartItemsDataGrid.Columns.AddRange(new DataGridViewColumn[] { Index, dgvId, dgvCode, dgvUnitType, dgvName, dgvQuantity, dgvPrice, dgvAmount, dgvDelete });
            CartItemsDataGrid.Location = new Point(712, 72);
            CartItemsDataGrid.Name = "CartItemsDataGrid";
            CartItemsDataGrid.RowTemplate.Height = 30;
            CartItemsDataGrid.Size = new Size(522, 323);
            CartItemsDataGrid.TabIndex = 9;
            CartItemsDataGrid.CellClick += CartItemsDataGrid_CellClick;
            CartItemsDataGrid.CellValueChanged += CartItemsDataGrid_CellValueChanged;
            // 
            // Index
            // 
            Index.FillWeight = 38.6231651F;
            Index.HeaderText = "#";
            Index.Name = "Index";
            Index.ReadOnly = true;
            // 
            // dgvId
            // 
            dgvId.HeaderText = "ID";
            dgvId.Name = "dgvId";
            dgvId.Visible = false;
            // 
            // dgvCode
            // 
            dgvCode.FillWeight = 37.716877F;
            dgvCode.HeaderText = "Mã";
            dgvCode.Name = "dgvCode";
            dgvCode.ReadOnly = true;
            // 
            // dgvUnitType
            // 
            dgvUnitType.FillWeight = 39.07942F;
            dgvUnitType.HeaderText = "ĐVT";
            dgvUnitType.Name = "dgvUnitType";
            dgvUnitType.ReadOnly = true;
            // 
            // dgvName
            // 
            dgvName.FillWeight = 109.5929F;
            dgvName.HeaderText = "Tên";
            dgvName.Name = "dgvName";
            dgvName.ReadOnly = true;
            // 
            // dgvQuantity
            // 
            dgvQuantity.FillWeight = 22.6285114F;
            dgvQuantity.HeaderText = "SL";
            dgvQuantity.Name = "dgvQuantity";
            // 
            // dgvPrice
            // 
            dgvPrice.FillWeight = 61.3869972F;
            dgvPrice.HeaderText = "Giá";
            dgvPrice.Name = "dgvPrice";
            dgvPrice.ReadOnly = true;
            // 
            // dgvAmount
            // 
            dgvAmount.FillWeight = 56.21703F;
            dgvAmount.HeaderText = "S.tiền";
            dgvAmount.Name = "dgvAmount";
            dgvAmount.ReadOnly = true;
            // 
            // dgvDelete
            // 
            dgvDelete.FillWeight = 19.6873341F;
            dgvDelete.HeaderText = "";
            dgvDelete.Image = Properties.Resources.remove;
            dgvDelete.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dgvDelete.MinimumWidth = 10;
            dgvDelete.Name = "dgvDelete";
            dgvDelete.ReadOnly = true;
            dgvDelete.Resizable = DataGridViewTriState.True;
            // 
            // MedicineProductPanel
            // 
            MedicineProductPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            MedicineProductPanel.AutoScroll = true;
            MedicineProductPanel.BackColor = Color.GhostWhite;
            MedicineProductPanel.Location = new Point(3, 72);
            MedicineProductPanel.Name = "MedicineProductPanel";
            MedicineProductPanel.Size = new Size(703, 507);
            MedicineProductPanel.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(337, 253);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(8, 8);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // dataGridViewImageColumn1
            // 
            dataGridViewImageColumn1.FillWeight = 16.21949F;
            dataGridViewImageColumn1.HeaderText = "";
            dataGridViewImageColumn1.Image = Properties.Resources.minus;
            dataGridViewImageColumn1.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dataGridViewImageColumn1.MinimumWidth = 10;
            dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            dataGridViewImageColumn1.ReadOnly = true;
            dataGridViewImageColumn1.Width = 26;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            label6.ForeColor = SystemColors.HotTrack;
            label6.Location = new Point(15, 91);
            label6.Name = "label6";
            label6.Size = new Size(112, 19);
            label6.TabIndex = 0;
            label6.Text = "Tên khách hàng";
            // 
            // txtCustomer
            // 
            txtCustomer.Location = new Point(325, 91);
            txtCustomer.Name = "txtCustomer";
            txtCustomer.Size = new Size(137, 25);
            txtCustomer.TabIndex = 3;
            // 
            // POSView
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1234, 611);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "POSView";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hệ thống quản lý thuốc, dược phẩm";
            WindowState = FormWindowState.Maximized;
            Load += POSView_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnDashboard).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnSearch).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnLogout).EndInit();
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CartItemsDataGrid).EndInit();
            ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox btnLogout;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.PictureBox btnSearch;
        private System.Windows.Forms.PictureBox btnDashboard;
        private System.Windows.Forms.FlowLayoutPanel MedicineProductPanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.DataGridView CartItemsDataGrid;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Label txtTotal;
        private System.Windows.Forms.Label txtVAT;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtChange;
        private Label label5;
        private Label label4;
        private ComboBox cbFilterPrice;
        private Button btnRefresh;
        private DataGridViewTextBoxColumn Index;
        private DataGridViewTextBoxColumn dgvId;
        private DataGridViewTextBoxColumn dgvCode;
        private DataGridViewTextBoxColumn dgvUnitType;
        private DataGridViewTextBoxColumn dgvName;
        private DataGridViewTextBoxColumn dgvQuantity;
        private DataGridViewTextBoxColumn dgvPrice;
        private DataGridViewTextBoxColumn dgvAmount;
        private DataGridViewImageColumn dgvDelete;
        private TextBox txtCustomer;
        private Label label6;
    }
}