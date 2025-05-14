using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace pharmacy_sys.Models
{
    public class PharmacyDbContext : DbContext
    {
        private string connectionString = @"Data Source=DESKTOP-JPDKROQ\SQLEXPRESS;Initial Catalog=PharmacySystem;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
        public DbSet<Supplier> Suppliers { get; set; } = null!;
        public DbSet<UnitType> UnitTypes { get; set; } = null!;
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<MedicineGroup> MedicineGroups { get; set; } = null!;

        public DbSet<Medicine> Medicines { get; set; } = null!;
        public DbSet<MedicineBatch> MedicineBatches { get; set; } = null!;
        public DbSet<Bill> Bills { get; set; } = null!;
        public DbSet<BillDetail> BillDetails { get; set; } = null!;
        public DbSet<Log> Logs { get; set; } = null!;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
