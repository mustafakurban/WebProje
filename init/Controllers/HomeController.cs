using init.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace init.Controllers
{
    public class HomeController : Controller
    {
        Context db = new Context();

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
        public IActionResult Api_doc()
        {
            return View();
        }

        public IActionResult Registration()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Registration(SiteUser model)
        {

            SiteUser user = new SiteUser();
            user.USERNAME = model.USERNAME;
            user.PASSWORD = model.PASSWORD;
            user.EMAIL = model.EMAIL;
            user.COUNTRY = model.COUNTRY;
            user.ROLEID = 2;

            db.Add(user);
            db.SaveChanges();


            return View();
        }

        public IActionResult Login()
        {
            return View();
        }


        [HttpPost]
        public JsonResult LoginUser(SiteUser model)
        {

            SiteUser user = db.User.SingleOrDefault(x => x.USERNAME == model.USERNAME && x.PASSWORD == model.PASSWORD);

            string result = "Fail";

            if (user != null)
            {

                HttpContext.Session.SetString("UserId", user.USERID.ToString());
                HttpContext.Session.SetString("UserName", user.USERNAME);




                if (user.ROLEID == 2)
                {
                    result = "GeneralUser";
                }
                else if (user.ROLEID == 1)
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
