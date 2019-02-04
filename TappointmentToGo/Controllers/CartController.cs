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
        public Cart Index()
        {
            return user.Cart;
        }

        // GET: Cart/ItemsNumber
        public int ItemsNumber()
        {
            return user.Cart?.CartItems.Sum(ci => ci.Count) ?? 0;
        }

        // PUT: Cart/Add/5
        [HttpPut]
        public void Add(int id)
        {
            InitializeCart();
            user.Cart.Add(context.MenuItems.Find(id));

            context.Entry(user).State = EntityState.Modified;

            context.SaveChanges();
        }

        public void InitializeCart()
        {
            if (user.Cart == null)
            {
                user.Cart = new Cart();
                context.Entry(user.Cart).State = EntityState.Added;
            }
            else
            {
                context.Entry(user.Cart).State = EntityState.Modified;
            }
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