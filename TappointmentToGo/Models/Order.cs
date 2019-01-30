using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TappointmentToGo.Models
{
    public class Order : AbstractItem
    {
        // TODO order details
        public Cart Cart { get; set; }
    }
}