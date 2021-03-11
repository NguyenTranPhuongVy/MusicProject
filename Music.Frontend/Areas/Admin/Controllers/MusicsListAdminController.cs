using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Music.Frontend.Areas.Admin.Controllers
{
    public class MusicsListAdminController : Controller
    {
        // GET: Admin/MusicsListAdmin
        public ActionResult Index()
        {
            return View();
        }
    }
}