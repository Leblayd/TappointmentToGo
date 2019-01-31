using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TappointmentToGo.Models
{
    public class Cart : AbstractItem
    {
        public string UserId { get; set; }
        public List<CartItem> CartItems { get; set; } = new List<CartItem>();

        public void Add(MenuItem menuItem) => Add(menuItem, 1);

        public void Add(MenuItem menuItem, int count)
        {
            var x = CartItems.Find(item => item.MenuItem == menuItem);
            if (x == null)
                CartItems.Add(new CartItem(menuItem, count));
            else
                x.Count += count;
        }
    }

    public class CartItem : AbstractItem
    {
        public MenuItem MenuItem { get; set; }
        public int Count { get; set; }
        public CartItem(MenuItem menuItem, int count)
        {
            MenuItem = menuItem;
            Count = count;
        }
    }
}