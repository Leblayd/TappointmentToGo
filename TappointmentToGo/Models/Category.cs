using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure.Pluralization;
using System.Linq;
using System.Web;
using Humanizer;

namespace TappointmentToGo.Models
{
    public class Category : AbstractItem
    {
        public string Name { get; set; }
        public List<MenuItem> MenuItems { get; set; }
        public string NamePlural { get => Name.Pluralize(); }
        public string ImageName { get => Name.Replace(" ", string.Empty); }
    }
}