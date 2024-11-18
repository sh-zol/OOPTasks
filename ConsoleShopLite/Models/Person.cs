using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleShopLite.Models
{
    public abstract class Person
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public Role Role { get; set; }
    }

    public enum Role
    {
        Admin = 1,
        Customer,
        Supplier
    }
}
