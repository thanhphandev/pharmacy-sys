namespace pharmacy_sys.Views.ReportForm
{
    partial class SalesReportView
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            chartSales = new System.Windows.Forms.DataVisualization.Charting.Chart();
            btnRefresh = new Button();
            btnFilter = new Button();
            label3 = new Label();
            dtpEndDate = new DateTimePicker();
            dtpStartDate = new DateTimePicker();
            label = new Label();
            cbGroupBy = new ComboBox();
            dgvSalesReport = new DataGridView();
            colDate = new DataGridViewTextBoxColumn();
            colTotalRevenue = new DataGridViewTextBoxColumn();
            colTotalBills = new DataGridViewTextBoxColumn();
            colQuantitySold = new DataGridViewTextBoxColumn();
            btnPrintReport = new Button();
            ((System.ComponentModel.ISupportInitialize)chartSales).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSalesReport).BeginInit();
            SuspendLayout();
            // 
            // chartSales
            // 
            chartArea2.Name = "ChartArea1";
            chartSales.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chartSales.Legends.Add(legend2);
            chartSales.Location = new Point(25, 80);
            chartSales.Name = "chartSales";
            chartSales.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Revenue";
            series2.YValuesPerPoint = 2;
            chartSales.Series.Add(series2);
            chartSales.Size = new Size(863, 158);
            chartSales.TabIndex = 0;
            chartSales.Text = "chartSales";
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(703, 47);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(75, 23);
            btnRefresh.TabIndex = 19;
            btnRefresh.Text = "Làm mới";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnFilter
            // 
            btnFilter.Location = new Point(622, 47);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(75, 23);
            btnFilter.TabIndex = 20;
            btnFilter.Text = "Lọc";
            btnFilter.UseVisualStyleBackColor = true;
            btnFilter.Click += btnFilter_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(372, 51);
            label3.Name = "label3";
            label3.Size = new Size(20, 15);
            label3.TabIndex = 18;
            label3.Text = "Từ";
            // 
            // dtpEndDate
            // 
            dtpEndDate.Format = DateTimePickerFormat.Short;
            dtpEndDate.Location = new Point(521, 48);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(83, 23);
            dtpEndDate.TabIndex = 16;
            // 
            // dtpStartDate
            // 
            dtpStartDate.Format = DateTimePickerFormat.Short;
            dtpStartDate.Location = new Point(398, 48);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(83, 23);
            dtpStartDate.TabIndex = 17;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(487, 51);
            label.Name = "label";
            label.Size = new Size(28, 15);
            label.TabIndex = 15;
            label.Text = "Đến";
            // 
            // cbGroupBy
            // 
            cbGroupBy.FormattingEnabled = true;
            cbGroupBy.Items.AddRange(new object[] { "Ngày", "Tháng", "Năm" });
            cbGroupBy.Location = new Point(25, 51);
            cbGroupBy.Name = "cbGroupBy";
            cbGroupBy.Size = new Size(135, 23);
            cbGroupBy.TabIndex = 21;
            // 
            // dgvSalesReport
            // 
            dgvSalesReport.AllowUserToAddRows = false;
            dgvSalesReport.AllowUserToDeleteRows = false;
            dgvSalesReport.BackgroundColor = SystemColors.ButtonHighlight;
            dgvSalesReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSalesReport.Columns.AddRange(new DataGridViewColumn[] { colDate, colTotalRevenue, colTotalBills, colQuantitySold });
            dgvSalesReport.Location = new Point(25, 244);
            dgvSalesReport.MultiSelect = false;
            dgvSalesReport.Name = "dgvSalesReport";
            dgvSalesReport.ReadOnly = true;
            dgvSalesReport.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSalesReport.Size = new Size(863, 194);
            dgvSalesReport.TabIndex = 22;
            // 
            // colDate
            // 
            colDate.FillWeight = 80F;
            colDate.HeaderText = "Ngày";
            colDate.Name = "colDate";
            colDate.ReadOnly = true;
            colDate.Width = 120;
            // 
            // colTotalRevenue
            // 
            colTotalRevenue.HeaderText = "Doanh thu";
            colTotalRevenue.Name = "colTotalRevenue";
            colTotalRevenue.ReadOnly = true;
            colTotalRevenue.Width = 280;
            // 
            // colTotalBills
            // 
            colTotalBills.HeaderText = "Số hóa đơn";
            colTotalBills.Name = "colTotalBills";
            colTotalBills.ReadOnly = true;
            colTotalBills.Width = 180;
            // 
            // colQuantitySold
            // 
            colQuantitySold.HeaderText = "Số lượng thuốc";
            colQuantitySold.Name = "colQuantitySold";
            colQuantitySold.ReadOnly = true;
            colQuantitySold.Width = 240;
            // 
            // btnPrintReport
            // 
            btnPrintReport.Location = new Point(813, 47);
            btnPrintReport.Name = "btnPrintReport";
            btnPrintReport.Size = new Size(75, 23);
            btnPrintReport.TabIndex = 19;
            btnPrintReport.Text = "In báo cáo";
            btnPrintReport.UseVisualStyleBackColor = true;
            btnPrintReport.Click += btnPrintReport_Click;
            // 
            // SalesReportView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(981, 450);
            Controls.Add(dgvSalesReport);
            Controls.Add(cbGroupBy);
            Controls.Add(btnPrintReport);
            Controls.Add(btnRefresh);
            Controls.Add(btnFilter);
            Controls.Add(label3);
            Controls.Add(dtpEndDate);
            Controls.Add(dtpStartDate);
            Controls.Add(label);
            Controls.Add(chartSales);
            Name = "SalesReportView";
            Text = "SalesReportView";
            Load += SalesReportView_Load;
            ((System.ComponentModel.ISupportInitialize)chartSales).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSalesReport).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartSales;
        private Button btnRefresh;
        private Button btnFilter;
        private Label label3;
        private DateTimePicker dtpEndDate;
        private DateTimePicker dtpStartDate;
        private Label label;
        private ComboBox cbGroupBy;
        private DataGridView dgvSalesReport;
        private DataGridViewTextBoxColumn colDate;
        private DataGridViewTextBoxColumn colTotalRevenue;
        private DataGridViewTextBoxColumn colTotalBills;
        private DataGridViewTextBoxColumn colQuantitySold;
        private Button btnPrintReport;
    }
}