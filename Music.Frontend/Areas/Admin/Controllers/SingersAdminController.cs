using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Music.Frontend.Areas.Admin.Controllers
{
    public class SingersAdminController : Controller
    {
        // GET: Admin/SingersAdmin
        public ActionResult Index()
        {
            return View();
        }
    }
}