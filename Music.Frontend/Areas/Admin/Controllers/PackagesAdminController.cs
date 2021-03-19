using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Music.Model.DAO;
using Music.Model.EF;
using Music.Frontend.Function;
using Music.Frontend.Models;
using Music.Common;

namespace Music.Frontend.Areas.Admin.Controllers
{
    public class PackagesAdminController : Controller
    {
        MusicProjectDataEntities db = new MusicProjectDataEntities();
        // GET: Admin/PackagesAdmin
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Delete()
        {
            return View(db.Packages.Where(n => n.package_pin == true).ToList());
        }

        [HttpGet]
        public JsonResult Active(int? id)
        {
            var dao = new PackagesDAO();
            if (dao.Active(id))
            {
                List<Package> packages = db.Packages.Where(n => n.package_pin == false).OrderBy(n => n.package_name).ToList();
                List<jPackages> list = packages.Select(n => new jPackages
                {
                    package_active = n.package_active,
                    package_name = n.package_name,
                    package_content = n.package_content,
                    package_datecreate = n.package_datecreate.Value.ToString("dd/MM/yyyy"),
                    package_id = n.package_id,
                    package_money = n.package_money,
                    package_option = n.package_option,
                    package_pin = n.package_pin,
                    pakage_price = n.pakage_price
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
            var dao = new PackagesDAO();
            if (dao.Option(id))
            {
                List<Package> packages = db.Packages.Where(n => n.package_pin == false).OrderBy(n => n.package_name).ToList();
                List<jPackages> list = packages.Select(n => new jPackages
                {
                    package_active = n.package_active,
                    package_name = n.package_name,
                    package_content = n.package_content,
                    package_datecreate = n.package_datecreate.Value.ToString("dd/MM/yyyy"),
                    package_id = n.package_id,
                    package_money = n.package_money,
                    package_option = n.package_option,
                    package_pin = n.package_pin,
                    pakage_price = n.pakage_price
                }).ToList();
                return Json(list, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(null);
            }
        }

        //Hàm thêm
        [HttpPost]
        public ActionResult Add(Package package, HttpPostedFileBase IMG, string del)
        {
            //Cập nhật có thay đổi
            package.package_option = true;
            package.package_pin = false;

            //Kiem tra thay đổi value

            if (package.package_active != true && package.package_active != false)
            {
                package.package_active = false;
            }

            var dao = new PackagesDAO();
            var j = new JsonAdminController();

            if (dao.Add(package))
            {
                return Redirect("/Admin/PackagesAdmin");
            }
            else
            {
                return Redirect(Common.Link.NOT_404);
            }
        }

        //Hàm sửa
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Package package, HttpPostedFileBase IMG)
        {
            Package pack = db.Packages.Find(package.package_id);

            package.package_active = pack.package_active;
            package.package_datecreate = pack.package_datecreate;
            package.package_pin = pack.package_pin;
            package.package_option = pack.package_option;

            


            var dao = new PackagesDAO();
            if (dao.Edit(package))
            {
                return Redirect("/Admin/PackagesAdmin");
            }
            else
            {
                return Redirect(Common.Link.NOT_404);
            }
        }

        //Thùng rác
        [HttpGet]
        public JsonResult Del(int? id)
        {
            var dao = new PackagesDAO();
            if (dao.Del(id))
            {
                List<Package> packages = db.Packages.Where(n => n.package_pin == false).OrderBy(n => n.package_name).ToList();
                List<jPackages> list = packages.Select(n => new jPackages
                {
                    package_active = n.package_active,
                    package_name = n.package_name,
                    package_content = n.package_content,
                    package_datecreate = n.package_datecreate.Value.ToString("dd/MM/yyyy"),
                    package_id = n.package_id,
                    package_money = n.package_money,
                    package_option = n.package_option,
                    package_pin = n.package_pin,
                    pakage_price = n.pakage_price
                }).ToList();
                return Json(list, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(null);
            }
        }

        //Khôi Phục
        [HttpGet]
        public JsonResult Restore(int? id)
        {
            var dao = new PackagesDAO();
            if (dao.Restore(id))
            {
                List<Package> packages = db.Packages.Where(n => n.package_pin == true).OrderBy(n => n.package_name).ToList();
                List<jPackages> list = packages.Select(n => new jPackages
                {
                    package_active = n.package_active,
                    package_name = n.package_name,
                    package_content = n.package_content,
                    package_datecreate = n.package_datecreate.Value.ToString("dd/MM/yyyy"),
                    package_id = n.package_id,
                    package_money = n.package_money,
                    package_option = n.package_option,
                    package_pin = n.package_pin,
                    pakage_price = n.pakage_price
                }).ToList();
                return Json(list, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(null);
            }
        }

        //Hàm xoá
        public JsonResult DeletePackage(int? id)
        {
            var dao = new PackagesDAO();
            var j = new JsonAdminController();
            if (dao.Delete(id))
            {
                List<Package> packages = db.Packages.Where(n => n.package_pin == true).OrderBy(n => n.package_name).ToList();
                List<jPackages> list = packages.Select(n => new jPackages
                {
                    package_active = n.package_active,
                    package_name = n.package_name,
                    package_content = n.package_content,
                    package_datecreate = n.package_datecreate.Value.ToString("dd/MM/yyyy"),
                    package_id = n.package_id,
                    package_money = n.package_money,
                    package_option = n.package_option,
                    package_pin = n.package_pin,
                    pakage_price = n.pakage_price
                }).ToList();
                return Json(list, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(null);
            }
        }
    }
}