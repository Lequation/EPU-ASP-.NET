using EPUWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EPUWeb.Areas.Admin.Models
{
    public class UserModel
    {
        private static EPUDataEntities db = null;

        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public Nullable<int> RoleId { get; set; }
        public Nullable<int> DepartmentId { get; set; }
        public string Sex { get; set; }
        public System.DateTime Birthday { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Avata { get; set; }
        public HttpPostedFileBase FilesAvata { get; set; }

        public static UserModel UserToModel(User user)
        {
            UserModel model = new UserModel();
            model.UserId = user.UserId;
            model.UserName = user.UserName;
            model.Password = user.PasswordHash;
            model.FullName = user.FullName;
            model.Email = user.Email;
            model.RoleId = user.RoleId;
            model.DepartmentId = user.DepartmentId;
            model.Sex = user.Sex;
            model.Birthday = user.Birthday;
            model.Address = user.Address;
            model.PhoneNumber = user.PhoneNumber;
            model.Avata = user.Avata;
            return model;
        }

        public static bool IsUserExist(UserModel user)
        {
            using (db = new EPUDataEntities())
            {
                var us = db.Users.Where(x => x.UserName == user.UserName || x.PhoneNumber == user.PhoneNumber || x.Email == user.Email).SingleOrDefault();
                return us == null ? false : true;
            }
        }

        public static bool IsUserExistEdit(UserModel user)
        {
            using (db = new EPUDataEntities())
            {
                var us = db.Users.Where(x => (x.UserName == user.UserName || x.PhoneNumber == user.PhoneNumber || x.Email == user.Email) && x.UserId != user.UserId ).SingleOrDefault();
                return us == null ? false : true;
            }
        }

        public static string DepartmentName(int DepartmentId)
        {
            using (db = new EPUDataEntities())
            {
                var dep = db.Departments.Where(x => x.DepartmentId == DepartmentId).SingleOrDefault();
                return dep == null ? "Chưa xác định" : dep.DepartmentName;
            }
        }

        public static string RoleName(int RoleId)
        {
            using (db = new EPUDataEntities())
            {
                return db.Roles.Where(x => x.RoleId == RoleId).SingleOrDefault().RoleName;
            }
        }

        public static string BirthdayText(DateTime day)
        {
            return day.ToString("dd/MM/yyyy");
        }
    }
}