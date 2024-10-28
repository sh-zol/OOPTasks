using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePoly.Models
{
    public class Employee:Person
    {
        public override void Identity()
        {
            Console.WriteLine($@"
                Hi I'm an Employee and my name is {Name} this is my email: {Email} and this is where i live: {Address} and where i work {CompanyName}
                ");
        }

        public override void ChangeMe()
        {
            base.ChangeMe();
        }
    }
}
