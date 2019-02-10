using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using TappointmentToGo.Models;

namespace TappointmentToGo.Controllers
{
    public class OrderController : Controller
    {
        private ApplicationDbContext context = new ApplicationDbContext();
        private ApplicationUser user;

        // GET: Order/Checkout
        [HttpGet]
        public ActionResult Checkout()
        {
            if (user.Cart.CartItems.Count < 1)
                return RedirectToAction("Index", "Home");
            return View();
        }

        // POST: Order/Checkout
        [HttpPost]
        public async Task<ActionResult> Checkout(OrderViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            var order = new Order
            {
                Address = model.Address,
                Name = $"{model.LastName}, {model.FirstName}",
                Telephone = model.Telephone,
                Cart = user.Cart,
                User = user
            };
            context.Entry(order).State = EntityState.Added;

            user.NewEmptyCart();
            context.Entry(user.Cart).State = EntityState.Added;

            await context.SaveChangesAsync();

            return RedirectToAction("Finished", new { id = order.Id });
        }

        // GET: Cart/Finished/2
        [HttpGet]
        public ActionResult Finished(int id)
        {
            var order = context.Orders
                .Include(o => o.User)
                .Include(o => o.Address)
                .Include(o => o.Cart.CartItems.Select(ci => ci.MenuItem))
                .First(o => o.Id == id);

            if (order == null || order.User.Id != User.Identity.GetUserId())
                return HttpNotFound();
            return View(order);
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