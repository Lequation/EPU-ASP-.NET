using EPUWeb.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EPUWeb.Models;
using EPUWeb.Areas.Admin.Code;
using System.IO;

namespace EPUWeb.Areas.Admin.Controllers
{
    public class UserController : Controller
    {
        private EPUDataEntities db = null;
        // GET: Admin/User
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult LoadDepartment()
        {
            if (Request.IsAjaxRequest())
            {
                using (db = new EPUDataEntities())
                {
                    var lstDp = db.Departments.Select(x=> new { id = x.DepartmentId, text = x.DepartmentName }).ToList();
                    return Json(new { lstDpjson = lstDp }, JsonRequestBehavior.AllowGet);
                }
            }
            else
            {
                return Json(new { lstDpjson = "" }, JsonRequestBehavior.AllowGet);
            }
        }

        public JsonResult LoadRole()
        {
            if (Request.IsAjaxRequest())
            {
                using (db = new EPUDataEntities())
                {
                    var lstrole = db.Roles.Select(x => new { id = x.RoleId, text = x.RoleName }).ToList();
                    return Json(new { lstRolejson = lstrole }, JsonRequestBehavior.AllowGet);
                }
            }
            else
            {
                return Json(new { lstRolejson = "" }, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginModel model)
        {
            using (db = new EPUDataEntities())
            {
                var PasswordHash = model.MD5Hash(model.Password);
                var result = db.Users.Where(x => x.UserName == model.UserName && x.PasswordHash == PasswordHash).SingleOrDefault() == null ? false : true;
                if (result && ModelState.IsValid)
                {
                    Session["UserName"] = model.UserName;
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Đăng nhập thất bại");
                }
                return View(model);
            }
        }

        public ActionResult UserProfile()
        {
            ViewBag.PageTitle = "Người dùng";
            return View(SessionUser.GetCurrentUser());
        }

        public ActionResult Edit(int id)
        {
            using (db = new EPUDataEntities())
            {
                ViewBag.PageTitle = "Cập nhật thông tin";
                var User = db.Users.Where(x => x.UserId == id).SingleOrDefault();
                var model = UserModel.UserToModel(User);
                model.Password = "";
                return View(model);
            }
        }

        [HttpPost]
        public ActionResult EditUser(UserModel model)
        {
            if (!UserModel.IsUserExistEdit(model))
            {
                using (db = new EPUDataEntities())
                {
                    ViewBag.PageTitle = "Cập nhật thông tin";
                    User editUser = db.Users.Where(x=>x.UserId == model.UserId).SingleOrDefault();
                    if (editUser != null)
                    {
                        var now = DateTime.Now;
                        editUser.UserName = model.UserName;
                        editUser.FullName = model.FullName;
                        editUser.Email = model.Email;
                        editUser.EmailConfirmaed = true;
                        //editUser.RoleId = model.RoleId;
                        editUser.UserName = model.UserName;
                        editUser.DepartmentId = model.DepartmentId;
                        editUser.Sex = model.Sex;
                        editUser.Birthday = model.Birthday;
                        editUser.Address = model.Address;
                        editUser.PhoneNumber = model.PhoneNumber;
                        editUser.PhoneNumberConfirmed = true;
                        editUser.CreatedAt = now;
                        editUser.Status = 1;
                        editUser.Address = model.Address;

                        if (model.FilesAvata != null)
                        {
                            if (System.IO.File.Exists(editUser.Avata))
                            {
                                System.IO.File.Delete(editUser.Avata);
                            }
                            var file = model.FilesAvata;
                            var fileName = ((DateTimeOffset)now).ToUnixTimeSeconds();
                            var path = Path.Combine(Server.MapPath("~/images/avata"), fileName + Path.GetExtension(model.FilesAvata.FileName));
                            file.SaveAs(path);
                            editUser.Avata = "/images/avata" + fileName + Path.GetExtension(model.FilesAvata.FileName);
                        }


                        db.SaveChanges();
                        return RedirectToAction("Index", "User");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Không tìm thấy người dùng này!");
                        return View("Edit", model);
                    }
                }
            }
            else
            {
                ModelState.AddModelError("", "Người dùng đã tồn tại!");
                return View("Edit", model);
            }
        }
    }
}