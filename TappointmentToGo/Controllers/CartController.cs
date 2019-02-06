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