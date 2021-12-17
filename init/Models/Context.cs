using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace init.Models
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-SFUU6KP\\SQLEXPRESS;Initial Catalog=barinak;Integrated Security=True");
        }
        public DbSet<hayvanlar> animals { get; set; }
        public DbSet<Apikeys> Apikeys { get; set; }
        public DbSet<SiteUser> User { get; set; }
        public DbSet<Aid> Aid { get; set; }


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

                new SiteUser{
                    USERID=2,
                    USERNAME="g191210056@sakarya.edu.tr",
                    PASSWORD="123",
                    EMAIL="mustafa.kurban@ogr.sakarya.edu.tr",
                    COUNTRY="Turkey",
                    ROLEID=1
                },
            });


            modelBuilder.Entity<hayvanlar>().HasData(new hayvanlar[] {
                new hayvanlar{
                    id = 1,
                    yas = 4,
                    katagori = "Köpek",
                    isim = "Tarçın"
                },

                new hayvanlar{
                    id = 2,
                    yas = 2,
                    katagori = "Kedi",
                    isim = "Duman"
                },

                new hayvanlar{
                    id = 3,
                    yas = 1,
                    katagori = "Kaplumbağa",
                    isim = "Benekli"
                },
            });


            modelBuilder.Entity<Apikeys>().HasData(new Apikeys[] {
                new Apikeys
                {
                    Id = 1,
                    ApiKey = 5561
                },
            });


            modelBuilder.Entity<Aid>().HasData(new Aid[] {
                new Aid
                {
                    id = 1,
                    amount = 1
                },
            }); 


        }
    }
}
