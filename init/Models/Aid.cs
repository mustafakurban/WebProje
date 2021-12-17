using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace init.Models
{
    public class Aid
    {
        [Key]
        public int id { get; set; }
        public int? amount { get; set; }
    }
}
