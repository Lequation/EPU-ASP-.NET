using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EPUWeb.EF;

namespace EPUWeb.Controllers
{
    public class CategoryController : Controller
    {
        EPUEntities db = new EPUEntities();
        // GET: Category
        public ActionResult Category()
        {
            return View();
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