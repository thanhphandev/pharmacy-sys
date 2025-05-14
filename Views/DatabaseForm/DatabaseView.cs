using pharmacy_sys.Presenters.DatabasePresenter;
using pharmacy_sys.Services.DatabaseServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace pharmacy_sys.Views.DatabaseForm
{
    public partial class DatabaseView : Form, IDatabaseView
    {


        public DatabaseView()
        {
            InitializeComponent();
            var databaseService = new DatabaseService();
            new DatabasePresenter(this, databaseService);
        }


        public string BackupPath
        {
            get => txtBackupPath.Text;
            set => txtBackupPath.Text = value;
        }

        public string RestorePath
        {
            get => txtRestorePath.Text;
            set => txtRestorePath.Text = value;
        }
        public event EventHandler BackupEvent;
        public event EventHandler RestoreEvent;


        private void btnBrowserRestore_Click(object sender, EventArgs e)
        {
            using var dialog = new OpenFileDialog { Filter = "Backup Files (*.bak)|*.bak" };
            if (dialog.ShowDialog() == DialogResult.OK)
                RestorePath = dialog.FileName;
        }

        private void btnBrowseBackup_Click(object sender, EventArgs e)
        {
            using var dialog = new SaveFileDialog { Filter = "Backup Files (*.bak)|*.bak" };
            if (dialog.ShowDialog() == DialogResult.OK)
                BackupPath = dialog.FileName;
        }

        public void StartProgress()
        {
            Invoke(new Action(() =>
            {
                progressBar.Visible = true;
            }));

        }

        public void StopProgress()
        {
            Invoke(new Action(() =>
            {
                progressBar.Visible = false;
            }));
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            BackupEvent?.Invoke(this, EventArgs.Empty);
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            RestoreEvent?.Invoke(this, EventArgs.Empty);
        }
    }
}
