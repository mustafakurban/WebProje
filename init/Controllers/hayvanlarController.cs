using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using init.Models;

namespace init.Controllers
{
    public class hayvanlarController : Controller
    {
        Context c = new Context();
      
        public IActionResult Index()
        {

            var degerler = c.animals.ToList();
            return View(degerler);
        }
        public IActionResult sahiplen()
        {

            return View();
        }
    }
}
