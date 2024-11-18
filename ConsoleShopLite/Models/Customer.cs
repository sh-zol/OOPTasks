using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleShopLite.Models
{
    public class Customer:Person
    {
        public Customer()
        {
            Role = Role.Customer;
        }
        public Cart? Cart { get; set; }
        public int CartId { get; set; }
    }
}
