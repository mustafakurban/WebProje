using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace init.Models
{
    public class hayvanlar
    {
        [Key]
        public int id { get; set; }
        public string katagori { get; set; }
        public int yas { get; set; }
        public string isim { get; set; }
    }
}
