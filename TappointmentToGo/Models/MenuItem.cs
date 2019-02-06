using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TappointmentToGo.Models
{
    public class MenuItem : AbstractItem
    {
        public Category Category { get; set; }
        public string Description { get; set; }
        [Required] public string Name { get; set; }
        [Required] public int Price { get; set; }
        public bool? Spicy { get; set; }
        public bool? Vegetarian { get; set; }
    }
}