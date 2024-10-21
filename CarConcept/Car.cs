using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarConcept
{
    public abstract class Car
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? ManufacturedDate { get; set; }
        public string? Color { get; set; }

        public void Start()
        {
            Console.WriteLine("Car Started");
        }
    }
}
