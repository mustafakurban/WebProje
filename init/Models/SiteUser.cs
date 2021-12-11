using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace init.Models
{
    public class SiteUser
    {

        [Key]
        public int USERID { get; set; }

        public string USERNAME { get; set; }

        public string PASSWORD { get; set; }

        public string EMAIL { get; set; }

        public string COUNTRY { get; set; }

        public int ROLEID { get; set; }


    }
}
