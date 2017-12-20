using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EPUWeb.Models;

namespace EPUWeb.Areas.Admin.Code
{
    [Serializable]
    public class SessionUser
    {
        private static EPUDataEntities db = null;
        public static void SetSession(string UserName)
        {
            HttpContext.Current.Session["UserName"] = UserName;
        }
        public static string GetSession()
        {
            return HttpContext.Current.Session["UserName"] == null ? "" : HttpContext.Current.Session["UserName"].ToString();
        }
        public static User GetCurrentUser()
        {
            using (db = new EPUDataEntities())
            {
                var UserName = GetSession();
                return db.Users.Where(x => x.UserName == UserName).SingleOrDefault();
            }
        }
    }
}