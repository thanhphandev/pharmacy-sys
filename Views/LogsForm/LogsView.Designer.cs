namespace pharmacy_sys.Views.LogsForm
{
    partial class LogsView
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
            dgvLogs = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colStaff = new DataGridViewTextBoxColumn();
            colAction = new DataGridViewTextBoxColumn();
            colTable = new DataGridViewTextBoxColumn();
            colTargetId = new DataGridViewTextBoxColumn();
            colMessage = new DataGridViewTextBoxColumn();
            colOldValue = new DataGridViewTextBoxColumn();
            colNewValue = new DataGridViewTextBoxColumn();
            colDevice = new DataGridViewTextBoxColumn();
            colSource = new DataGridViewTextBoxColumn();
            colCreatedAt = new DataGridViewTextBoxColumn();
            label1 = new Label();
            cbAction = new ComboBox();
            dtpStartDate = new DateTimePicker();
            dtpEndDate = new DateTimePicker();
            label = new Label();
            label3 = new Label();
            btnExportData = new Button();
            btnFilter = new Button();
            btnRefresh = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvLogs).BeginInit();
            SuspendLayout();
            // 
            // dgvLogs
            // 
            dgvLogs.AllowUserToAddRows = false;
            dgvLogs.AllowUserToDeleteRows = false;
            dgvLogs.AllowUserToOrderColumns = true;
            dgvLogs.BackgroundColor = SystemColors.ButtonHighlight;
            dgvLogs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLogs.Columns.AddRange(new DataGridViewColumn[] { colId, colStaff, colAction, colTable, colTargetId, colMessage, colOldValue, colNewValue, colDevice, colSource, colCreatedAt });
            dgvLogs.Location = new Point(12, 68);
            dgvLogs.MultiSelect = false;
            dgvLogs.Name = "dgvLogs";
            dgvLogs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLogs.Size = new Size(1123, 492);
            dgvLogs.TabIndex = 7;
            // 
            // colId
            // 
            colId.HeaderText = "ID";
            colId.Name = "colId";
            colId.Visible = false;
            // 
            // colStaff
            // 
            colStaff.FillWeight = 80F;
            colStaff.HeaderText = "Tên";
            colStaff.Name = "colStaff";
            colStaff.Width = 120;
            // 
            // colAction
            // 
            colAction.HeaderText = "Hành động";
            colAction.Name = "colAction";
            colAction.Width = 50;
            // 
            // colTable
            // 
            colTable.HeaderText = "Tài nguyên";
            colTable.Name = "colTable";
            colTable.Width = 80;
            // 
            // colTargetId
            // 
            colTargetId.HeaderText = "ID";
            colTargetId.Name = "colTargetId";
            colTargetId.Width = 50;
            // 
            // colMessage
            // 
            colMessage.HeaderText = "Thông điệp";
            colMessage.Name = "colMessage";
            colMessage.Width = 250;
            // 
            // colOldValue
            // 
            colOldValue.HeaderText = "Giá trị cũ";
            colOldValue.Name = "colOldValue";
            colOldValue.Width = 120;
            // 
            // colNewValue
            // 
            colNewValue.HeaderText = "Giá trị mới";
            colNewValue.Name = "colNewValue";
            colNewValue.Width = 120;
            // 
            // colDevice
            // 
            colDevice.HeaderText = "Tên thiết bị";
            colDevice.Name = "colDevice";
            colDevice.Width = 90;
            // 
            // colSource
            // 
            colSource.HeaderText = "Nguồn";
            colSource.Name = "colSource";
            colSource.Width = 80;
            // 
            // colCreatedAt
            // 
            colCreatedAt.HeaderText = "Thời gian";
            colCreatedAt.Name = "colCreatedAt";
            colCreatedAt.Width = 120;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(128, 128, 255);
            label1.Location = new Point(12, 37);
            label1.Name = "label1";
            label1.Size = new Size(166, 25);
            label1.TabIndex = 8;
            label1.Text = "Nhật ký hệ thống";
            // 
            // cbAction
            // 
            cbAction.FormattingEnabled = true;
            cbAction.Location = new Point(197, 38);
            cbAction.Name = "cbAction";
            cbAction.Size = new Size(121, 23);
            cbAction.TabIndex = 9;
            // 
            // dtpStartDate
            // 
            dtpStartDate.Format = DateTimePickerFormat.Short;
            dtpStartDate.Location = new Point(387, 39);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(83, 23);
            dtpStartDate.TabIndex = 11;
            // 
            // dtpEndDate
            // 
            dtpEndDate.Format = DateTimePickerFormat.Short;
            dtpEndDate.Location = new Point(510, 39);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(83, 23);
            dtpEndDate.TabIndex = 11;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(476, 42);
            label.Name = "label";
            label.Size = new Size(28, 15);
            label.TabIndex = 10;
            label.Text = "Đến";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(361, 42);
            label3.Name = "label3";
            label3.Size = new Size(20, 15);
            label3.TabIndex = 12;
            label3.Text = "Từ";
            // 
            // btnExportData
            // 
            btnExportData.Location = new Point(1007, 44);
            btnExportData.Name = "btnExportData";
            btnExportData.Size = new Size(128, 23);
            btnExportData.TabIndex = 13;
            btnExportData.Text = "Xuất thông tin";
            btnExportData.UseVisualStyleBackColor = true;
            btnExportData.Click += btnExportData_Click;
            // 
            // btnFilter
            // 
            btnFilter.Location = new Point(611, 38);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(75, 23);
            btnFilter.TabIndex = 14;
            btnFilter.Text = "Lọc";
            btnFilter.UseVisualStyleBackColor = true;
            btnFilter.Click += btnFilter_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(704, 38);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(75, 23);
            btnRefresh.TabIndex = 14;
            btnRefresh.Text = "Làm mới";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // LogsView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1168, 572);
            Controls.Add(btnRefresh);
            Controls.Add(btnFilter);
            Controls.Add(btnExportData);
            Controls.Add(label3);
            Controls.Add(dtpEndDate);
            Controls.Add(dtpStartDate);
            Controls.Add(label);
            Controls.Add(cbAction);
            Controls.Add(label1);
            Controls.Add(dgvLogs);
            Name = "LogsView";
            Text = "LogsView";
            Load += LogsView_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLogs).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvLogs;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colStaff;
        private DataGridViewTextBoxColumn colAction;
        private DataGridViewTextBoxColumn colTable;
        private DataGridViewTextBoxColumn colTargetId;
        private DataGridViewTextBoxColumn colMessage;
        private DataGridViewTextBoxColumn colOldValue;
        private DataGridViewTextBoxColumn colNewValue;
        private DataGridViewTextBoxColumn colDevice;
        private DataGridViewTextBoxColumn colSource;
        private DataGridViewTextBoxColumn colCreatedAt;
        private Label label1;
        private ComboBox cbAction;
        private DateTimePicker dtpStartDate;
        private DateTimePicker dtpEndDate;
        private Label label;
        private Label label3;
        private Button btnExportData;
        private Button btnFilter;
        private Button btnRefresh;
    }
}