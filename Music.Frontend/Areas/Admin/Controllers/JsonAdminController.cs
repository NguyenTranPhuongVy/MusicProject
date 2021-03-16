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

        public JsonResult Singers(string del)
        {
            if(del != "del")
            {
                List<Singer> singers = db.Singers.Where(n => n.singer_bin == false).OrderBy(n => n.singer_name).ToList();
                List<jSingers> list = singers.Select(n => new jSingers 
                {
                    singer_active = n.singer_active,
                    singer_bin = n.singer_bin,
                    singer_id = n.singer_id,
                    singer_img = n.singer_img,
                    singer_name = n.singer_name,
                    singer_note = n.singer_note,
                    user_id = n.user_id,
                    singer_datecreate = n.singer_datecreate.Value.ToString("dd/MM/yyyy hh:mm:ss"),
                    singer_dateupdate = n.singer_dateupdate.Value.ToString("dd/MM/yyyy hh:mm:ss"),
                    singer_option = n.singer_option,
                }).ToList();
                return Json(list, JsonRequestBehavior.AllowGet);
            }    
            else
            {
                List<Singer> singers = db.Singers.Where(n => n.singer_bin == true).OrderBy(n => n.singer_name).ToList();
                List<jSingers> list = singers.Select(n => new jSingers
                {
                    singer_active = n.singer_active,
                    singer_bin = n.singer_bin,
                    singer_id = n.singer_id,
                    singer_img = n.singer_img,
                    singer_name = n.singer_name,
                    singer_note = n.singer_note,
                    user_id = n.user_id,
                    singer_datecreate = n.singer_datecreate.Value.ToString("dd/MM/yyyy hh:mm:ss"),
                    singer_dateupdate = n.singer_dateupdate.Value.ToString("dd/MM/yyyy hh:mm:ss"),
                    singer_option = n.singer_option,
                }).ToList();
                return Json(list, JsonRequestBehavior.AllowGet);
            }    
        }

        public JsonResult Authors(string del)
        {
            if(del != "del")
            {
                List<Author> authors = db.Authors.Where(n => n.author_bin == false).OrderBy(n => n.author_name).ToList();
                List<jAuthors> list = authors.Select(n => new jAuthors
                {
                    author_active = n.author_active,
                    author_bin = n.author_bin,
                    author_datecreate = n.author_datecreate.Value.ToString("dd/MM/yyyy hh:mm:ss"),
                    author_dateupdate = n.author_dateupdate.Value.ToString("dd/MM/yyyy hh:mm:ss"),
                    author_id = n.author_id,
                    author_img = n.author_img,
                    author_name = n.author_name,
                    author_note = n.author_note,
                    author_option = n.author_option,
                    user_id = n.user_id
                }).ToList();
                return Json(list, JsonRequestBehavior.AllowGet);
            } 
            else
            {
                List<Author> authors = db.Authors.Where(n => n.author_bin == true).OrderBy(n => n.author_name).ToList();
                List<jAuthors> list = authors.Select(n => new jAuthors
                {
                    author_active = n.author_active,
                    author_bin = n.author_bin,
                    author_datecreate = n.author_datecreate.Value.ToString("dd/MM/yyyy hh:mm:ss"),
                    author_dateupdate = n.author_dateupdate.Value.ToString("dd/MM/yyyy hh:mm:ss"),
                    author_id = n.author_id,
                    author_img = n.author_img,
                    author_name = n.author_name,
                    author_note = n.author_note,
                    author_option = n.author_option,
                    user_id = n.user_id
                }).ToList();
                return Json(list, JsonRequestBehavior.AllowGet);
            }    
        }
    }
}