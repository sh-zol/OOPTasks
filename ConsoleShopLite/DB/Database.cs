using ConsoleShopLite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleShopLite.DB
{
    public static class Database
    {
        static Database()
        {
            // for seeding the data fill these class blocks or add more i'm running short on time 
            Customers = new()
            {
                new Customer
                {

                }
            };

            Admins = new()
            {
                new Admin
                {

                }
            };

            Suppliers = new()
            {
                new Supplier
                {

                }
            };

            Carts = new()
            {
                new Cart
                {

                }
            };

            Products = new()
            {
                new Product
                {

                }
            };
        }
        public static List<Customer>? Customers;
        public static List<Supplier>? Suppliers;
        public static List<Product>? Products;
        public static List<Cart>? Carts;
        public static List<Admin>? Admins;
        public static Admin? CurrentAdmin;
        public static Customer? CurrentCustomer;
        public static Supplier? CurrentSupplier;

    }
}
