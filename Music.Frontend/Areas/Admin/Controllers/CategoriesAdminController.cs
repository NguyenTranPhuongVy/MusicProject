using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Music.Model.DAO;
using Music.Model.EF;
using Music.Frontend.Function;
using Music.Frontend.Models;

namespace Music.Frontend.Areas.Admin.Controllers
{
    public class CategoriesAdminController : Controller
    {
        MusicProjectDataEntities db = new MusicProjectDataEntities();
        // GET: Admin/CategoriesAdmin
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Delete()
        {
            return View();
        }

        [HttpGet]
        public JsonResult Active(int ? id)
        {
            var dao = new CategoriesDAO();
            if(dao.Active(id))
            {
                List<Category> categories = db.Categories.Where(n => n.category_bin == false).ToList();
                List<jCategories> list = categories.Select(n => new jCategories
                {
                    category_active = n.category_active,
                    category_bin = n.category_bin,
                    category_id = n.category_id,
                    category_name = n.category_name,
                    category_note = n.category_note,
                    category_view = n.category_view,
                    user_id = n.user_id,
                    category_datecreate = n.category_datecreate.Value.ToShortDateString().ToString(),
                    category_dateupdate = n.category_dateupdate.Value.ToShortDateString().ToString(),
                    category_img = n.category_img,
                    category_option = n.category_option

                }).ToList();
                return Json(list, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(null);
            }
        }

        public JsonResult Option(int? id)
        {
            var dao = new CategoriesDAO();
            if (dao.Option(id))
            {
                List<Category> categories = db.Categories.Where(n => n.category_bin == false).ToList();
                List<jCategories> list = categories.Select(n => new jCategories
                {
                    category_active = n.category_active,
                    category_bin = n.category_bin,
                    category_id = n.category_id,
                    category_name = n.category_name,
                    category_note = n.category_note,
                    category_view = n.category_view,
                    user_id = n.user_id,
                    category_datecreate = n.category_datecreate.Value.ToShortDateString().ToString(),
                    category_dateupdate = n.category_dateupdate.Value.ToShortDateString().ToString(),
                    category_img = n.category_img,
                    category_option = n.category_option

                }).ToList();
                return Json(list, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(null);
            }
        }

        [HttpPost]
        public ActionResult Add(Category category)
        {
            var dao = new CategoriesDAO();
            if(dao.ADD(category))
            {
                return Redirect("/Admin/CategoriesAdmin/Index");
            } 
            else
            {
                return Redirect("/");
            }    
        }
    }
}