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
            if (string.IsNullOrWhiteSpace(backupPath))
                throw new ArgumentException("Đường dẫn sao lưu không hợp lệ");

            var directory = Path.GetDirectoryName(backupPath);
            if (!Directory.Exists(directory))
                throw new DirectoryNotFoundException($"Thư mục không tồn tại: {directory}");

            using var context = new PharmacyDbContext();
            var conn = (SqlConnection)context.Database.GetDbConnection();
            var dbName = conn.Database;

            var sql = $"BACKUP DATABASE [{dbName}] TO DISK = @backupPath";

            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@backupPath", backupPath);

            if (conn.State != ConnectionState.Open)
                conn.Open();

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex) when (ex.Message.Contains("Access is denied", StringComparison.OrdinalIgnoreCase))
            {
                throw new UnauthorizedAccessException("SQL Server không có quyền ghi file vào thư mục đã chọn.", ex);
            }
        }


        public void RestoreDatabase(string backupFilePath)
        {
            if (!File.Exists(backupFilePath))
                throw new FileNotFoundException("Tệp sao lưu không tồn tại", backupFilePath);

            using var context = new PharmacyDbContext();
            var conn = (SqlConnection)context.Database.GetDbConnection();
            var dbName = conn.Database;

            var masterConnStr = conn.ConnectionString.Replace(dbName, "master");

            using var masterConn = new SqlConnection(masterConnStr);
            var restoreSql = $@"
        ALTER DATABASE [{dbName}] SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
        RESTORE DATABASE [{dbName}] FROM DISK = @backupPath WITH REPLACE;
        ALTER DATABASE [{dbName}] SET MULTI_USER;";

            using var cmd = new SqlCommand(restoreSql, masterConn);
            cmd.Parameters.AddWithValue("@backupPath", backupFilePath);

            try
            {
                masterConn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex) when (ex.Message.Contains("Access is denied", StringComparison.OrdinalIgnoreCase))
            {
                throw new UnauthorizedAccessException("SQL Server không có quyền đọc tệp sao lưu. Vui lòng kiểm tra quyền truy cập hoặc di chuyển file.", ex);
            }
        }

    }
}
