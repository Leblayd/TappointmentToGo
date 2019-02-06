using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TappointmentToGo.Models;

namespace TappointmentToGo.Controllers
{
    [Authorize] // BUG currently the "api" routes return with 200(OK) even if the user isn't logged in
    public class CartController : Controller
    {
        private ApplicationDbContext context;
        private ApplicationUser user;

        public CartController()
        {
            context = new ApplicationDbContext();
        }

        // GET: Cart
        [HttpGet]
        public ActionResult Index()
        {
            return View(user.Cart);
        }

        // GET: Cart/ItemsNumber
        [HttpGet]
        public int ItemsNumber()
        {
            return user.Cart?.CartItems.Sum(ci => ci.Count) ?? 0;
        }

        // POST: Cart/Index/5
        [HttpPost]
        [ActionName("Index")]
        public void Add(int id)
        {
            user.Cart.Add(id);

            context.Entry(user).State = EntityState.Modified;

            context.SaveChanges();
        }

        // PUT: Cart/Index/5?count=3
        [HttpPut]
        [ActionName("Index")]
        public void Edit(int id, int count)
        {
            user.Cart.Set(id, count);

            context.Entry(user).State = EntityState.Modified;

            context.SaveChanges();
        }

        // DELETE: Cart/Index/5
        [HttpDelete]
        [ActionName("Index")]
        public void Remove(int id)
        {
            user.Cart.Remove(id);

            context.Entry(user).State = EntityState.Modified;

            context.SaveChanges();
        }

        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            base.OnActionExecuting(filterContext);
            var userId = User.Identity.GetUserId();
            user = context.Users
                .Where(u => u.Id == userId)
                .Include(u => u.Cart.CartItems.Select(ci => ci.MenuItem))
                .Single();
        }
    }
}