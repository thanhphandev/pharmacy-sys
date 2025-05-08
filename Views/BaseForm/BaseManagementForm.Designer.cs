namespace pharmacy_sys.Views.BaseForm
{
    partial class BaseManagementForm
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
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnAdd = new PictureBox();
            btnRefresh = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)btnAdd).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnRefresh).BeginInit();
            SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(207, 64);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(366, 23);
            txtSearch.TabIndex = 0;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(579, 63);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(86, 23);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Image = Properties.Resources.plus;
            btnAdd.Location = new Point(67, 63);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(25, 25);
            btnAdd.SizeMode = PictureBoxSizeMode.StretchImage;
            btnAdd.TabIndex = 3;
            btnAdd.TabStop = false;
            // 
            // btnRefresh
            // 
            btnRefresh.Image = Properties.Resources.refresh;
            btnRefresh.Location = new Point(176, 64);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(25, 25);
            btnRefresh.SizeMode = PictureBoxSizeMode.StretchImage;
            btnRefresh.TabIndex = 3;
            btnRefresh.TabStop = false;
            // 
            // BaseManagementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRefresh);
            Controls.Add(btnAdd);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Name = "BaseManagementForm";
            Text = "BaseManagementForm";
            ((System.ComponentModel.ISupportInitialize)btnAdd).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnRefresh).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        protected TextBox txtSearch;
        protected Button btnSearch;
        protected PictureBox btnAdd;
        protected PictureBox btnRefresh;
    }
}