using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Music.Frontend.Areas.Admin.Controllers
{
    public class AlbumsAdminController : Controller
    {
        // GET: Admin/AlbumsAdmin
        public ActionResult Index()
        {
            return View();
        }
    }
}