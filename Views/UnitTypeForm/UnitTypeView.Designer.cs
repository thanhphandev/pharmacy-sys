namespace pharmacy_sys.Views.UnitTypeForm
{
    partial class UnitTypeView
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
            lstUnitType = new ListBox();
            label1 = new Label();
            btnAdd = new Button();
            txtUnitType = new TextBox();
            btnUpdate = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // lstUnitType
            // 
            lstUnitType.FormattingEnabled = true;
            lstUnitType.ItemHeight = 17;
            lstUnitType.Location = new Point(12, 79);
            lstUnitType.MultiColumn = true;
            lstUnitType.Name = "lstUnitType";
            lstUnitType.Size = new Size(234, 140);
            lstUnitType.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.RoyalBlue;
            label1.Location = new Point(8, 9);
            label1.Name = "label1";
            label1.Size = new Size(98, 20);
            label1.TabIndex = 1;
            label1.Text = "Đơn vị thuốc";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.LightSeaGreen;
            btnAdd.FlatAppearance.BorderColor = Color.LightSeaGreen;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAdd.ForeColor = SystemColors.ControlLightLight;
            btnAdd.Location = new Point(252, 48);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 25);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtUnitType
            // 
            txtUnitType.Location = new Point(12, 48);
            txtUnitType.Name = "txtUnitType";
            txtUnitType.Size = new Size(234, 25);
            txtUnitType.TabIndex = 3;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.RoyalBlue;
            btnUpdate.FlatAppearance.BorderColor = Color.LightSeaGreen;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnUpdate.ForeColor = SystemColors.ControlLightLight;
            btnUpdate.Location = new Point(252, 79);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 25);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Sửa";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // button3
            // 
            button3.Location = new Point(252, 110);
            button3.Name = "button3";
            button3.Size = new Size(75, 25);
            button3.TabIndex = 2;
            button3.Text = "Xóa";
            button3.UseVisualStyleBackColor = true;
            button3.Click += btnDelete_Click;
            // 
            // UnitTypeView
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(364, 241);
            Controls.Add(txtUnitType);
            Controls.Add(button3);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(label1);
            Controls.Add(lstUnitType);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MaximumSize = new Size(380, 280);
            MinimumSize = new Size(300, 280);
            Name = "UnitTypeView";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Quản lý đơn vị thuốc";
            Load += UnitTypeView_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstUnitType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtUnitType;
        private Button btnUpdate;
        private Button button3;
    }
}