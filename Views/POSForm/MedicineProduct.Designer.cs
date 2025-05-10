namespace pharmacy_sys.Views.POSForm
{
    partial class MedicineProduct
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbName = new Label();
            lbPrice = new Label();
            btnChoose = new Button();
            pbMedicineImage = new PictureBox();
            lbQuantity = new Label();
            btnView = new Button();
            lbCode = new Label();
            ((System.ComponentModel.ISupportInitialize)pbMedicineImage).BeginInit();
            SuspendLayout();
            // 
            // lbName
            // 
            lbName.AutoEllipsis = true;
            lbName.AutoSize = true;
            lbName.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbName.ForeColor = Color.FromArgb(120, 120, 120);
            lbName.Location = new Point(4, 129);
            lbName.Margin = new Padding(4, 0, 4, 0);
            lbName.Name = "lbName";
            lbName.Size = new Size(78, 20);
            lbName.TabIndex = 1;
            lbName.Text = "Tên thuốc";
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.Location = new Point(5, 149);
            lbPrice.Margin = new Padding(4, 0, 4, 0);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new Size(92, 17);
            lbPrice.TabIndex = 2;
            lbPrice.Text = "50.000 đ /Hộp";
            // 
            // btnChoose
            // 
            btnChoose.BackColor = Color.FromArgb(26, 81, 162);
            btnChoose.FlatAppearance.BorderColor = Color.FromArgb(26, 81, 162);
            btnChoose.FlatStyle = FlatStyle.Flat;
            btnChoose.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnChoose.ForeColor = Color.White;
            btnChoose.Location = new Point(5, 170);
            btnChoose.Margin = new Padding(4);
            btnChoose.Name = "btnChoose";
            btnChoose.Size = new Size(63, 30);
            btnChoose.TabIndex = 3;
            btnChoose.Text = "Chọn";
            btnChoose.UseVisualStyleBackColor = false;
            btnChoose.Click += btnChoose_Click;
            // 
            // pbMedicineImage
            // 
            pbMedicineImage.Location = new Point(4, 22);
            pbMedicineImage.Margin = new Padding(4);
            pbMedicineImage.Name = "pbMedicineImage";
            pbMedicineImage.Size = new Size(139, 102);
            pbMedicineImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pbMedicineImage.TabIndex = 0;
            pbMedicineImage.TabStop = false;
            // 
            // lbQuantity
            // 
            lbQuantity.AutoSize = true;
            lbQuantity.Location = new Point(104, 149);
            lbQuantity.Name = "lbQuantity";
            lbQuantity.Size = new Size(15, 17);
            lbQuantity.TabIndex = 4;
            lbQuantity.Text = "1";
            // 
            // btnView
            // 
            btnView.BackColor = SystemColors.ButtonFace;
            btnView.FlatAppearance.BorderColor = Color.FromArgb(26, 81, 162);
            btnView.FlatStyle = FlatStyle.Flat;
            btnView.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnView.ForeColor = Color.Black;
            btnView.Location = new Point(76, 170);
            btnView.Margin = new Padding(4);
            btnView.Name = "btnView";
            btnView.Size = new Size(63, 30);
            btnView.TabIndex = 3;
            btnView.Text = "Xem";
            btnView.UseVisualStyleBackColor = false;
            // 
            // lbCode
            // 
            lbCode.AutoSize = true;
            lbCode.Font = new Font("Segoe UI", 8F);
            lbCode.Location = new Point(5, 5);
            lbCode.Name = "lbCode";
            lbCode.Size = new Size(61, 13);
            lbCode.TabIndex = 5;
            lbCode.Text = "#MÃCODE";
            // 
            // MedicineProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(lbCode);
            Controls.Add(lbQuantity);
            Controls.Add(btnView);
            Controls.Add(btnChoose);
            Controls.Add(lbPrice);
            Controls.Add(lbName);
            Controls.Add(pbMedicineImage);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "MedicineProduct";
            Size = new Size(147, 212);
            ((System.ComponentModel.ISupportInitialize)pbMedicineImage).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbMedicineImage;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.Label lbQuantity;
        private Button btnView;
        private Label lbCode;
    }
}
