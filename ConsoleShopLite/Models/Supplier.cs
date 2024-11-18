using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleShopLite.Models
{
    public class Supplier:Person
    {
        public Supplier()
        {
            Role = Role.Supplier;
        }
        public List<Product>? Products { get; set; } = new();
    }
}
