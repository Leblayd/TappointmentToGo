using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TappointmentToGo.Models
{
    public abstract class AbstractItem
    {
        public int Id { get; set; }

        public override bool Equals(object obj)
        {
            var item = obj as AbstractItem;
            return item != null &&
                   Id == item.Id;
        }

        public override int GetHashCode()
        {
            return 2108858624 + Id.GetHashCode();
        }
    }
}