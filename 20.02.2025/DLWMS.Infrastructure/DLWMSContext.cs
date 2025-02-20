using DLWMS.Data;
using DLWMS.Data.IB230005;
using Microsoft.EntityFrameworkCore;

using System.Configuration;

namespace DLWMS.Infrastructure
{
    public class DLWMSContext : DbContext
    {
      
        private string konekcijskiString = ConfigurationManager.ConnectionStrings["DLWMSBaza"].ConnectionString;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(konekcijskiString);
        }

        public DbSet<Student> Studenti { get; set; }
        public DbSet<Stipendije> Stipendije { get; set; }
        public DbSet<StipendijeGodine> StipendijeGodine { get; set; }
        public DbSet<StudentiStipendije> StudentiStipendije { get; set; }


    }
}
