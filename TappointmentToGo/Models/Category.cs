using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TappointmentToGo.Models
{
    public class Category : AbstractItem
    {
        public string Name { get; set; }
        public List<MenuItem> MenuItems { get; set; }
    }
}