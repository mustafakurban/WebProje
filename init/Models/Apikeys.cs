using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace init.Models
{
    public class Apikeys
    {
        [Key]
        public int Id { get; set; }
        public int ApiKey { get; set; }

    }
}
