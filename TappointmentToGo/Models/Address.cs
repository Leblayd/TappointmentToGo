using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TappointmentToGo.Models
{
    public class Address : AbstractItem
    {
        public string City { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }
    }
}