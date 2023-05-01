using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace final_project
{
    internal class UserContext: DbContext 

    {
        public DbSet<UserAccount> Users { get; set;  }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=Users;Trusted_Connection=True;MultipleActiveResultSets=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<UserAccount>().HasData(
                 new UserAccount { Id = 1,UserName = "Jacob", Password = "1234", Scores = "", LastScore = 0 }); 
                 
        }

    }
}
