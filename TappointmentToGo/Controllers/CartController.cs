using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using TappointmentToGo.Models;

namespace TappointmentToGo.Controllers
{
    [Authorize]
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
            return user.Cart.CartItems.Sum(ci => ci.Count);
        }

        // GET: Cart/Checkout
        [HttpGet]
        public ActionResult Checkout()
        {
            return View();
        }

        // POST: Cart/Checkout
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
                Cart = user.Cart
            };
            context.Entry(order).State = EntityState.Added;

            user.NewEmptyCart();
            context.Entry(user.Cart).State = EntityState.Added;

            await context.SaveChangesAsync();

            return RedirectToAction("Index", "Home");
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