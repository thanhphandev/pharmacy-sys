using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacy_sys.Services.DatabaseServices
{
    public interface IDatabaseService
    {
        void BackupDatabase(string backupPath);
        void RestoreDatabase(string backupFilePath);
    }
}
