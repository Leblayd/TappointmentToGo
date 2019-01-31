using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TappointmentToGo.Models
{
    public class Cart : AbstractItem
    {
        public string UserId { get; set; }
        public Dictionary<MenuItem, int> ItemsDictionary { get; set; }
    }
}