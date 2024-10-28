using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePoly.Models
{
    public class Person
    {
        [Key]
        public int Id { get; set; }
        [StringLength(30)]
        public string? Name { get; set; }
        [StringLength(50)]
        public string? Email { get; set; }
        [StringLength(40)]
        public string? Password { get; set; }
        [StringLength(100)]
        public string? Address { get; set; }
        [StringLength(11)]
        public string? PhoneNumber { get; set; }
        [StringLength(40)]
        public string? CompanyName { get; set; }

        public virtual void Identity()
        {
            Console.WriteLine(@$"
                Hi I'm {Name} my email is: {Email} and this is where i live: {Address}"
                );
        }

        public virtual void ChangeMe()
        {
            Console.WriteLine("Name:");
            Name = Console.ReadLine();
            Console.WriteLine("Email:");
            Email = Console.ReadLine();
            Console.WriteLine("Password:");
            Password = Console.ReadLine();
            Console.WriteLine("Address:");
            Address = Console.ReadLine();
            Console.WriteLine("PhoneNumber:");
            PhoneNumber = Console.ReadLine();
            Console.WriteLine("CompanyName:");
            CompanyName = Console.ReadLine();
        }
    }
}
