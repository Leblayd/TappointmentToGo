using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TappointmentToGo.Models
{
    public class MenuItem : AbstractItem
    {
        public Category Category { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public bool Spicy { get; set; }
        public bool Vegetarian { get; set; }
    }
}