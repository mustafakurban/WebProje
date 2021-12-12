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
            optionsBuilder.UseSqlServer("server=DESKTOP-OGVQLH0\\MSSQLSERVER01;database=barinak;integrated security=true;");
        }
        public DbSet<hayvanlar> animals { get; set; }
        public DbSet<Apikeys> Apikeys { get; set; }
    }
}
