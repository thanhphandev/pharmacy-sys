using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacy_sys.Views.DatabaseForm
{
    public interface IDatabaseView
    {
        string BackupPath { get; set; }
        string RestorePath { get; set; }
        event EventHandler BackupEvent;
        event EventHandler RestoreEvent;
        void StartProgress();
        void StopProgress();

    }
}
