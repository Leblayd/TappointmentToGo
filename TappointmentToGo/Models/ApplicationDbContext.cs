using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TappointmentToGo.Models
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<MenuItem> MenuItems { get; set; }
        public DbSet<Category> Categories { get; set; }
        //public DbSet<Order> Orders { get; set; }
        //public DbSet<Cart> Carts { get; set; }

        public ApplicationDbContext() : base("ApplicationContext")
        {
        }
    }
}