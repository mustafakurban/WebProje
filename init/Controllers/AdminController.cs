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
    


    public class AdminController : Controller
    {
        Context db = new Context();

        public IActionResult AdminIndex()
        {

            dbCounter dbc = new dbCounter()
            {
                usersCount = db.User.Count(),
                friendsCount = db.animals.Count()
            };


            return View(dbc);
        }

        public IActionResult AdminUsers()
        {
            var users = db.User.ToList();
            return View(users);
        }

        [HttpGet]
        public IActionResult YeniKullanici()
        {
            return View();
        }

        [HttpPost]
        public IActionResult YeniKullanici(SiteUser user)
        {
            db.User.Add(user);
            db.SaveChanges();
            return RedirectToAction("AdminUsers");
        }


        
        public IActionResult KullaniciSil(int id)
        {
            var user = db.User.Find(id);
            db.User.Remove(user);
            db.SaveChanges();
            return RedirectToAction("AdminUsers");
        }

        public IActionResult KullaniciGetir(int id)
        {
            var user = db.User.Find(id);
            return View("KullaniciGetir", user);
        }

        public IActionResult KullaniciGuncelle(SiteUser user)
        {

            var us = db.User.Find(user.USERID);
            us.USERID = user.USERID;
            us.USERNAME = user.USERNAME;
            us.EMAIL = user.EMAIL;
            us.PASSWORD = user.PASSWORD;
            us.COUNTRY = user.COUNTRY;
            us.ROLEID = user.ROLEID;

            db.SaveChanges();

            return RedirectToAction("AdminUsers");

        }




        public IActionResult AdminFriends()
        {
            var friends = db.animals.ToList();
            return View(friends);
        }

        [HttpGet]
        public IActionResult YeniHayvan()
        {
            return View();
        }

        [HttpPost]
        public IActionResult YeniHayvan(hayvanlar hayvan)
        {
            db.animals.Add(hayvan);
            db.SaveChanges();
            return RedirectToAction("AdminFriends");
        }


        public IActionResult HayvanSil(int id)
        {
            var hayvan = db.animals.Find(id);
            db.animals.Remove(hayvan);
            db.SaveChanges();
            return RedirectToAction("AdminFriends");
        }

        public IActionResult HayvanGetir(int id)
        {
            var hayvan = db.animals.Find(id);
            return View("HayvanGetir", hayvan);
        }

        public IActionResult HayvanGuncelle(hayvanlar hayvan)
        {

            var h = db.animals.Find(hayvan.id);
            h.id = hayvan.id;
            h.yas = hayvan.yas;
            h.isim = hayvan.isim;
            h.katagori = hayvan.katagori;

            db.SaveChanges();

            return RedirectToAction("AdminFriends");

        }


    }
}
