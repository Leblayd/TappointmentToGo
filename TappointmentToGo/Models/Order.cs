using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TappointmentToGo.Models
{
    public class Order : AbstractItem
    {
        [Required] public Cart Cart { get; set; }
        [Required] public string Name { get; set; }
        [Required] public string Telephone { get; set; }
        [Required] public Address Address { get; set; }
    }
}