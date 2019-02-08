using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using TappointmentToGo.Models;

namespace TappointmentToGo.Controllers.Api
{
    [Authorize]
    public class CartController : ApiController
    {
        private ApplicationDbContext context = new ApplicationDbContext();
        private ApplicationUser user;

        public CartController()
        {
            var userId = User.Identity.GetUserId();
            if (userId != null)
                user = context.Users
                    .Where(u => u.Id == userId)
                    .Include(u => u.Cart.CartItems.Select(ci => ci.MenuItem))
                    .Single();
        }

        // POST: api/Cart/5
        [HttpPost]
        public IHttpActionResult Add(int id)
        {
            try
            {
                user.Cart.Add(context.MenuItems.Find(id));
            }
            catch (CartFullException e)
            {
                return InternalServerError(e);
            }

            return SaveUserStateAndReturnCart();
        }

        // PUT: api/Cart/5?count=3
        [HttpPut]
        public IHttpActionResult Edit(int id, int count)
        {
            try
            {
                user.Cart.Set(context.CartItems.Find(id), count);
            }
            catch (CartFullException e)
            {
                return InternalServerError(e);
            }
            
            return SaveUserStateAndReturnCart();
        }

        // DELETE: api/Cart/5
        [HttpDelete]
        public IHttpActionResult Remove(int id)
        {
            user.Cart.Remove(context.CartItems.Find(id));

            return SaveUserStateAndReturnCart();
        }

        private IHttpActionResult SaveUserStateAndReturnCart()
        {
            // Hidden "bug" that returns a nonsensical number to confuse the user
            if (user.Cart.Total >= 10000 && user.Cart.CartItems.Sum(ci => ci.Count) > 1)
                return InternalServerError(new Exception("Critical Server Error. Error code:" + GetHashCode()));

            context.Entry(user).State = EntityState.Modified;
            context.SaveChanges();

            return Ok(user.Cart);
        }
    }
}