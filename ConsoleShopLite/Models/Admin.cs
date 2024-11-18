using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleShopLite.Models
{
    public class Admin:Person
    {
        public Admin()
        {
            Role = Role.Admin;
        }
    }
}
