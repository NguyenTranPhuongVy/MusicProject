using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Music.Model.DAO;
using Music.Model.EF;

namespace Music.Frontend.Areas.Admin.Controllers
{
    public class CategoriesAdminController : Controller
    {
        // GET: Admin/CategoriesAdmin
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Delete()
        {
            return View();
        }

        public ActionResult Active(int ? id)
        {
            var dao = new CategoriesDAO();
            if(dao.Active(id))
            {
                return Redirect("/Admin/CategoriesAdmin/Index");
            }
            else
            {
                return Redirect("/");
            }
        }

        public ActionResult Option(int? id)
        {
            var dao = new CategoriesDAO();
            if (dao.Option(id))
            {
                return Redirect("/Admin/CategoriesAdmin/Index");
            }
            else
            {
                return Redirect("/");
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