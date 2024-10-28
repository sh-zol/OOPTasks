using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePoly.Models
{
    public class Manager:Employee
    {
        public override void Identity()
        {
            Console.WriteLine($@"
                Hi I'm a manager and i work in {CompanyName} and my name is {Name} my email is {Email} 
            ");
        }

        public override void ChangeMe()
        {
            base.ChangeMe();
        }
    }
}
