using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using init.Models;
using Microsoft.AspNetCore.Http;


namespace init.Controllers
{
    public class HomeController : Controller
    {
        private readonly dbClass _dbc;

        public HomeController(dbClass dbc) {
            _dbc = dbc;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult aid()
        {
            return View();
        }
        public IActionResult getMessage()
        {
            return View();
        }

        
        public IActionResult Registration()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Registration(RegistrationViewModel model)
        {

            RegistrationViewModel user = new RegistrationViewModel();
            user.USERNAME = model.USERNAME;
            user.PASSWORD = model.PASSWORD;
            user.EMAIL = model.EMAIL;
            user.COUNTRY = model.COUNTRY;
            user.ROLEID = 2;

            _dbc.Add(user);
            _dbc.SaveChanges();


            return View();
        }

        public IActionResult Login()
        {
            return View();
        }


        [HttpPost]
        public JsonResult LoginUser(RegistrationViewModel model)
        {

            RegistrationViewModel user = _dbc.Users.SingleOrDefault(x => x.USERNAME == model.USERNAME && x.PASSWORD == model.PASSWORD);

            string result = "Fail";

            if (user != null)
            {

                HttpContext.Session.SetString("UserId", user.USERID.ToString());
                HttpContext.Session.SetString("UserName", user.USERNAME);




                if(user.ROLEID == 2)
                {
                    result = "GeneralUser";
                }
                else if(user.ROLEID == 1)
                {
                    result = "Admin";
                }
            }


            return Json(result);
        }


        public ActionResult Logout()
        {
            HttpContext.Session.Clear();

            return RedirectToAction("Login");
        }



    }
}
