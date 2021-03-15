using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Music.Frontend.Function;
using Music.Frontend.Models;
using Music.Model.DAO;
using Music.Model.EF;

namespace Music.Frontend.Function
{
    public class ImagesController : Controller
    {
        // GET: Images
        public string AddImages(HttpPostedFileBase IMG, string LinkImages, string code)
        {
            var fileimg = Path.GetFileName(IMG.FileName);
            var pa = Path.Combine(System.Web.HttpContext.Current.Server.MapPath("~/Images/" + LinkImages), code + fileimg);
            IMG.SaveAs(pa);
            return fileimg;
        }
    }
}