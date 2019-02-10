using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TappointmentToGo.Models;
using System.Data.Entity;
using Microsoft.AspNet.Identity;

namespace TappointmentToGo.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public ActionResult Index()
        {
            return View(db.Categories.ToList());
        }

        // GET: Home/Category/5
        public ActionResult Category(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Category category = db.Categories.Include(cat => cat.MenuItems).First(cat => cat.Id == id);

            if (category == null)
            {
                return HttpNotFound();
            }
            return View(category);
        }

        public ActionResult About()
        {
            return View();
        }
    }
}