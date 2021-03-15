using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Music.Model.EF;
using Music.Frontend.Function;
using Music.Frontend.Models;

namespace Music.Frontend.Areas.Admin.Controllers
{
    public class JsonAdminController : Controller
    {
        MusicProjectDataEntities db = new MusicProjectDataEntities();   
        public JsonResult Categorys(string del)
        {
            if(del != "del")
            {
                List<Category> categories = db.Categories.Where(n => n.category_bin == false).OrderBy(n => n.category_name).ToList();
                List<jCategories> list = categories.Select(n => new jCategories
                {
                    category_active = n.category_active,
                    category_bin = n.category_bin,
                    category_id = n.category_id,
                    category_name = n.category_name,
                    category_note = n.category_note,
                    category_view = n.category_view,
                    user_id = n.user_id,
                    category_datecreate = n.category_datecreate.Value.ToString("dd/MM/yyyy hh:mm:ss"),
                    category_dateupdate = n.category_dateupdate.Value.ToString("dd/MM/yyyy hh:mm:ss"),
                    category_img = n.category_img,
                    category_option = n.category_option

                }).ToList();
                return Json(list, JsonRequestBehavior.AllowGet);
            }   
            else
            {
                List<Category> categories = db.Categories.Where(n => n.category_bin == true).OrderBy(n => n.category_name).ToList();
                List<jCategories> list = categories.Select(n => new jCategories
                {
                    category_active = n.category_active,
                    category_bin = n.category_bin,
                    category_id = n.category_id,
                    category_name = n.category_name,
                    category_note = n.category_note,
                    category_view = n.category_view,
                    user_id = n.user_id,
                    category_datecreate = n.category_datecreate.Value.ToString("dd/MM/yyyy hh:mm:ss"),
                    category_dateupdate = n.category_dateupdate.Value.ToString("dd/MM/yyyy hh:mm:ss"),
                    category_img = n.category_img,
                    category_option = n.category_option

                }).ToList();
                return Json(list, JsonRequestBehavior.AllowGet);
            }    
        }
    }
}