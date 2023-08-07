using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace hastaneRandevuSistemi.Models.city


    {
        public class cityContext : DbContext

        {
        
        public DbSet<cityContext> city { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;
			Database=hastaneRandvuSistemi Table=[dbo].[city];Trusted_Connection=True;");


        }
       
    }
    }

