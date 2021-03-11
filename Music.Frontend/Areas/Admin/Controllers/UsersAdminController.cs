using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Music.Frontend.Areas.Admin.Controllers
{
    public class UsersAdminController : Controller
    {
        // GET: Admin/UsersAdmin
        public ActionResult Index()
        {
            return View();
        }
    }
}