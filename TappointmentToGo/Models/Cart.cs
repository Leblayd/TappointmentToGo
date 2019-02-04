using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TappointmentToGo.Models
{
    public class Cart : AbstractItem
    {
        public List<CartItem> CartItems { get; set; } = new List<CartItem>();

        public void Add(MenuItem menuItem) => Add(menuItem, 1);
        
        public void Add(MenuItem menuItem, int count)
        {
            var x = CartItems.Find(item => item.MenuItem == menuItem);
            if (x == null)
                CartItems.Add(new CartItem() { MenuItem = menuItem, Count = count });
            else
                x.Count += count;
        }
    }

    public class CartItem : AbstractItem
    {
        [Required] public MenuItem MenuItem { get; set; }
        [Required] public int Count { get; set; }
    }
}