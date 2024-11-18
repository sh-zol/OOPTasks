using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingServ.Models
{
    public class ShippingService
    {
        public ShippingService()
        {
            Orders = new();
        }
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Type { get; set; }
        public List<Order>? Orders { get; set; }

        public void Service()
        {
            Id = 1;
            Console.WriteLine("enter Service Name:");
            Name = Console.ReadLine();
            Console.WriteLine("enter service type");
            Type = Console.ReadLine();

        }
    }
}
