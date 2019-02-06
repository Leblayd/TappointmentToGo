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
    public class CartApiController : ApiController
    {
        private ApplicationDbContext context = new ApplicationDbContext();
        private ApplicationUser user;

        public CartApiController()
        {
            var userId = User.Identity.GetUserId();
            user = context.Users
                .Where(u => u.Id == userId)
                .Include(u => u.Cart.CartItems.Select(ci => ci.MenuItem))
                .Single();
        }

        // GET: api/CartsApi/ItemsNumber
        [HttpGet]
        public IHttpActionResult ItemsNumber()
        {
            return Ok(user.Cart.CartItems.Sum(ci => ci.Count));
        }

        // POST: Cart/Index/5
        [HttpPost]
        public async Task<IHttpActionResult> Add(int id)
        {
            try
            {
                user.Cart.Add(id);
            }
            catch (CartFullException e)
            {
                return BadRequest(e.Message);
            }

            context.Entry(user).State = EntityState.Modified;
            await context.SaveChangesAsync();

            return StatusCode(HttpStatusCode.NoContent);
        }

        // PUT: Cart/Index/5?count=3
        [HttpPut]
        public void Edit(int id, int count)
        {
            user.Cart.Set(id, count);

            context.Entry(user).State = EntityState.Modified;

            context.SaveChanges();
        }

        // DELETE: Cart/Index/5
        [HttpDelete]
        public void Remove(int id)
        {
            user.Cart.Remove(id);

            context.Entry(user).State = EntityState.Modified;

            context.SaveChanges();
        }
    }
}