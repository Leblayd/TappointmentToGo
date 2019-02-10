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

        // GET: Cart/Finished/2
        [HttpGet]
        public ActionResult Finished(int id)
        {
            var order = db.Orders
                .Include(o => o.User)
                .Include(o => o.Address)
                .Include(o => o.Cart.CartItems.Select(ci => ci.MenuItem))
                .First(o => o.Id == id);

            if (order == null || order.User.Id != User.Identity.GetUserId())
                return HttpNotFound();
            return View(order);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}