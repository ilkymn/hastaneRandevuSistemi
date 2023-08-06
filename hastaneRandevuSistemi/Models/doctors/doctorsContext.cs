using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hastaneRandevuSistemi.Models.doctors
{





    public class doctorsContext : DbContext

    {
        public DbSet<Doctors> Doktorlar { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;
			Database=hastaneRandvuSistemi;Trusted_Connection=True;");
        }
    }
}



