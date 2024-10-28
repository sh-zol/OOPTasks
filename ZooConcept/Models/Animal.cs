using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooConcept.Models
{
    public abstract class Animal
    {
        public string? Name { get; set; }
        public string? Age { get; set; }
        public abstract void Sound();
        
    }
}
