﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Music.Frontend.Areas.Admin.Controllers
{
    public class ViewAdminController : Controller
    {
        // GET: Admin/ViewAdmin
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Validation()
        {
            return View();
        }
    }
}