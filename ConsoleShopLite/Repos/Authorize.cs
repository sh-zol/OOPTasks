using ConsoleShopLite.DB;
using ConsoleShopLite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleShopLite.Repos
{
    public class Authorize
    {
        public void Register(RegisterVM registerVM)
        {
            if(registerVM.Role == 1)
            {
                Admin admin = new()
                {
                    Email= registerVM.Email,
                    Name = registerVM.Name,
                    Password = registerVM.Password,
                };
            }
            else if(registerVM.Role == 2)
            {
                Customer customer = new()
                {
                    Email = registerVM.Email,
                    Name = registerVM.Name,
                    Password = registerVM.Password,
                };
            }
            else if(registerVM.Role == 3)
            {
                Supplier supplier = new()
                {
                    Email = registerVM.Email,
                    Name = registerVM.Name,
                    Password = registerVM.Password,
                };
            }
        }

        public int Login(LoginVM loginVM)
        {
            var admin = Database.Admins.FirstOrDefault(x=>x.Email ==  loginVM.Email && x.Password == loginVM.Password);
            var customer = Database.Customers.FirstOrDefault(x=>x.Email == loginVM.Email && x.Password == loginVM.Password);
            var supplier = Database.Suppliers.FirstOrDefault(x => x.Email == loginVM.Email && x.Password == loginVM.Password);
            if(admin != null)
            {
                Database.CurrentAdmin = admin;
                return 1;
            }
            else if (customer != null)
            {
                Database.CurrentCustomer = customer;
                return 2;
            }
            else if(supplier != null)
            {
                Database.CurrentSupplier = supplier;
                return 3;
            }
            else
            {
                Console.WriteLine("no user was found");
                return 0;
            }
        }

        public void Logoff()
        {
            Database.CurrentSupplier = null;
            Database.CurrentCustomer = null;
            Database.CurrentSupplier = null;
        }
    }
}
