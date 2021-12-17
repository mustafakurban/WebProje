using init.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;

namespace init.Controllers
{
    [AllowAnonymous]
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
            bool isAuthenticate = false;
            ClaimsIdentity identity = null;

            if (user != null)
            {

                if (user.ROLEID == 2)
                {
                    result = "GeneralUser";

                    identity = new ClaimsIdentity(new[]
                    {
                        new Claim(ClaimTypes.Name, user.USERNAME),
                        new Claim(ClaimTypes.Role, "User")
                    }, CookieAuthenticationDefaults.AuthenticationScheme);
                    isAuthenticate = true;

                }
                else if (user.ROLEID == 1)
                {
                    result = "Admin";

                    identity = new ClaimsIdentity(new[]
                    {
                        new Claim(ClaimTypes.Name, user.USERNAME),
                        new Claim(ClaimTypes.Role, "Admin")
                    }, CookieAuthenticationDefaults.AuthenticationScheme);
                    isAuthenticate = true;

                }
            }

            if (isAuthenticate)
            {
                var principal = new ClaimsPrincipal(identity);
                var login = HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);
            }


            return Json(result);
        }

        
        public async Task<ActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

            return RedirectToAction("Login");
        }



    }

}
