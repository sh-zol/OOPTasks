using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooConcept.Models
{
    public class Cat : Animal
    {
        public override void Sound()
        {
            Console.WriteLine("meow meow");
        }
    }
}
