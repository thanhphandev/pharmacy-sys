using DocumentFormat.OpenXml.InkML;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using pharmacy_sys.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacy_sys.Services.DatabaseServices
{
    public class DatabaseService : IDatabaseService
    {
        public void BackupDatabase(string backupPath)
        {
            using var context = new PharmacyDbContext();
            var conn = (SqlConnection)context.Database.GetDbConnection();
            var dbName = conn.Database;
            var sql = $"BACKUP DATABASE [{dbName}] TO DISK = '{backupPath}'";

            using var cmd = new SqlCommand(sql, conn);
            if (conn.State != ConnectionState.Open)
                conn.Open();
            cmd.ExecuteNonQuery();
        }

        public void RestoreDatabase(string backupFilePath)
        {
            using var context = new PharmacyDbContext();
            var conn = (SqlConnection)context.Database.GetDbConnection();
            var dbName = conn.Database;
            var masterConnStr = conn.ConnectionString.Replace(dbName, "master");

            using var masterConn = new SqlConnection(masterConnStr);
            var restoreSql = $@"
            ALTER DATABASE [{dbName}] SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
            RESTORE DATABASE [{dbName}] FROM DISK = '{backupFilePath}' WITH REPLACE;
            ALTER DATABASE [{dbName}] SET MULTI_USER;";

            using var cmd = new SqlCommand(restoreSql, masterConn);
            masterConn.Open();
            cmd.ExecuteNonQuery();
        }
    }
}
