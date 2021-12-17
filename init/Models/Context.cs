using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace init.Models
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-SFUU6KP\\SQLEXPRESS;Initial Catalog=barinak;Integrated Security=True");
        }
        public DbSet<hayvanlar> animals { get; set; }
        public DbSet<Apikeys> Apikeys { get; set; }
        public DbSet<SiteUser> User { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SiteUser>().HasData(new SiteUser[] {
                new SiteUser{
                    USERID=1, 
                    USERNAME="g181210086@sakarya.edu.tr", 
                    PASSWORD="123", 
                    EMAIL="haci.cingoz@ogr.sakarya.edu.tr",
                    COUNTRY="Turkey",
                    ROLEID=1
                },
            });
        }

    }
}
