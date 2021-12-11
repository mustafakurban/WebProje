using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace init.Models
{
    public class dbClass:DbContext
    {

        public dbClass(DbContextOptions<dbClass> options) : base(options) { 
            
        }

        public DbSet<RegistrationViewModel> Users { get; set; }

    }
}
