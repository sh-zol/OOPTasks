using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooConcept.Models
{
    public class Zoo
    {
        public static void Start()
        {
            bool flag = true;
            while(flag)
            {
                Console.WriteLine("1.Dog sound");
                Console.WriteLine("2.Cat sound");
                Console.WriteLine("3.Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                        Dog dg = new();
                        dg.Sound();
                        break;
                    case 2:
                        Cat ct = new();
                        ct.Sound();
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("enter the right command!");
                        break;

                }
            }
        }
    }
}
