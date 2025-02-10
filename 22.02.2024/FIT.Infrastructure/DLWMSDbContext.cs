using FIT.Data;
using FIT.Data.IB230005;
using Microsoft.EntityFrameworkCore;

using System.Configuration;

namespace FIT.Infrastructure
{
    public class DLWMSDbContext : DbContext
    {
        private readonly string dbPutanja;

        public DLWMSDbContext()
        {
            dbPutanja = ConfigurationManager.
                ConnectionStrings["DLWMSBaza"].ConnectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(dbPutanja);
        }
    
        public DbSet<Student> Studenti { get; set; }
        public DbSet<SemestriIB230005> Semestri { get; set; }
        public DbSet<PredmetiIB230005> Predmeti { get; set; }
        public DbSet<ProstorijeIB230005> ProstorijeIB230005 { get; set; }
        public DbSet<NastavaIB230005> NastavaIB230005 { get; set; }
        public DbSet<PrisustvoIB230005> PrisustvoIB230005 { get; set; }


    }
}