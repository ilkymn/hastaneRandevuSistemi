using hastaneRandevuSistemi.Models.hospital;
using Microsoft.EntityFrameworkCore;

namespace hastaneRandevuSistemi.Models.patientsModel
{
    public class PatientsContext : DbContext
    {
        public DbSet<patients> Hastalar { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;
			Database=hastaneRandvuSistemi;Trusted_Connection=True;");
        }
    }
}
