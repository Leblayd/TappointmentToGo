using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace TappointmentToGo.Models
{
    public class Cart : AbstractItem
    {
        private readonly ApplicationDbContext context;
        public int MaxAmount { get; set; }
        public int Total { get => CartItems.Sum(ci => ci.Price); }
        public List<CartItem> CartItems { get; set; } = new List<CartItem>();

        public Cart()
        {
            context = new ApplicationDbContext();
        }
        public Cart(int max) : this()
        {
            MaxAmount = max;
        }

        public void Add(MenuItem menuItem)
        {
            var cartItem = CartItems.Find(ci => ci.MenuItem == menuItem);
            if (cartItem == null)
                AddNew(menuItem);
            else
                Set(cartItem, cartItem.Count + 1);
        }

        private void AddNew(MenuItem menuItem)
        {
            if (IsCartFull(menuItem.Price))
                throw new CartFullException(MaxAmount);
            CartItems.Add(new CartItem() { MenuItem = menuItem, Count = 1 });
        }

        public void Set(CartItem cartItem, int count)
        {
            if (IsCartFull(cartItem.MenuItem.Price * count - cartItem.Price))
                throw new CartFullException(MaxAmount);
            cartItem.Count = count;
        }

        public void Remove(CartItem cartItem)
        {
            CartItems.Remove(cartItem);
        }

        public bool IsCartFull(int difference)
        {
            return Total + difference > MaxAmount;
        }
    }

    public class CartItem : AbstractItem
    {
        [Required] public MenuItem MenuItem { get; set; }
        [Required] public int Count { get; set; }
        public int Price { get => MenuItem.Price * Count; }
    }

    public class CartFullException : Exception
    {
        public CartFullException()
        {
        }

        public CartFullException(int amount) : base($"Cart can only hold {amount} worth of items.")
        {
        }

        public CartFullException(string message) : base(message)
        {
        }
    }
}