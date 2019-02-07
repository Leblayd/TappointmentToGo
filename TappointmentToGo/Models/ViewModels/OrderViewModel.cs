using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TappointmentToGo.Models
{
    public class OrderViewModel
    {
        [Required]
        [Display(Name = "Address")]
        public Address Address { get; set; }
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required]
        [Phone]
        [Display(Name = "Telephone Number")]
        public string Telephone { get; set; }
    }
}