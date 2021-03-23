using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Music.Frontend.Controllers
{
    public class UsersController : Controller
    {
        // GET: Users
        public ActionResult Registration()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Profile()
        {
            return View();
        }
    }
}