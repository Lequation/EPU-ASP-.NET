using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EPUWeb.EF;

namespace EPUWeb.Controllers
{
    public class HomeController : Controller
    {
        EPUEntities db = new EPUEntities();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult LoadHomeNews(int CategoryId, int Number)
        {
            var data = db.CategoryNewsMappings.Where(e => e.CategoryId == CategoryId && e.Status == 1).OrderByDescending(e => e.News.CreatedAt).Take(Number);
            return PartialView("_HomeNews", data);
        }

        public ActionResult LoadHomeNotificationCommon(int CategoryId, int Number)
        {
            var data = db.CategoryNewsMappings.Where(e => e.CategoryId == CategoryId && e.Status == 1).OrderByDescending(e => e.News.CreatedAt).Take(Number);
            return PartialView("_HomeNotificationCommon", data);
        }

        public ActionResult LoadHomeNotificationEducate(int CategoryId, int Number)
        {
            var data = db.CategoryNewsMappings.Where(e => e.CategoryId == CategoryId && e.Status == 1).OrderByDescending(e => e.News.CreatedAt).Take(Number);
            return PartialView("_HomeNotificationEducate", data);
        }

        public ActionResult LoadHomeNotificationOther(int CategoryId, int Number)
        {
            var data = db.CategoryNewsMappings.Where(e => e.CategoryId == CategoryId && e.Status == 1).OrderByDescending(e => e.News.CreatedAt).Take(Number);
            return PartialView("_HomeNotificationOther", data);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

    }
}