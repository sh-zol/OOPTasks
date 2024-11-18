using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingServ.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Price { get; set; }
        public ShippingService? ShippingService { get; set; }
        public int? ShippingServiceId { get; set; }

    }
}
