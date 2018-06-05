using Cell.DAL.Models;
using Cell.Models.Entities;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Cell.DAL
{
    public class CellDbContext : DbContext
    {
        public DbSet<ClientDb> Clients { get; set; }
        public DbSet<CallDb> Calls { get; set; }
        public DbSet<ClientTypeDb> ClientTypes { get; set; }
        public DbSet<LineDb> Lines { get; set; }
        public DbSet<PackageDb> Packages { get; set; }
        public DbSet<PackageIncludeDb> PackageIncludes { get; set; }
        public DbSet<PaymentDb> Payments { get; set; }
        public DbSet<SelectedNumbersDb> SelectedNumbers { get; set; }
        public DbSet<SMSDb> SMSs { get; set; }
        public DbSet<UserDb> Users { get; set; }
        //public DbSet<Invoice> Invoices { get; set; }

        public CellDbContext() : base("name=DefaultConnection") { }
        //Configures tables without the plural 
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}