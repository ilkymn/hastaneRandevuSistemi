using hastaneRandevuSistemi.Models.city;
using Microsoft.EntityFrameworkCore;

namespace hastaneRandevuSistemi.Models.policlinic

{
    public class PoliclinicContext : DbContext
    {
        public DbSet<policlinic> Poliklinikler { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;
			Database=hastaneRandvuSistemi;Trusted_Connection=True;");
        }




    }
}

