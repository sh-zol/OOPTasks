using Student.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.Implementation
{
    public class IntroMenu
    {
        public static void Start()
        {
            Authenthication authenthication = new();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter one of the commands below:");
                Console.WriteLine("1.Login");
                Console.WriteLine("2.Register");
                Console.WriteLine("3.Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                        Console.WriteLine("Enter Email:");
                        string email = Console.ReadLine();
                        Console.WriteLine("Enter your Password:");
                        string password = Console.ReadLine();
                        var user = new LoginVM()
                        {
                            Email = email,
                            Password = password
                        };
                        var userLoggedIn = authenthication.Login(user); 
                        if(userLoggedIn == true)
                        {
                            StudentMenu.Start();
                        }
                        else
                        {
                            Console.WriteLine("Login Failed");
                        }
                        break;
                    case 2:
                        Console.WriteLine("Enter your Email:");
                        email = Console.ReadLine();
                        Console.WriteLine("Enter your Name:");
                        string name = Console.ReadLine();
                        Console.WriteLine("Enter you PhoneNumber:");
                        string number = Console.ReadLine();
                        Console.WriteLine("Enter you Paswword:");
                        password = Console.ReadLine();
                        Console.WriteLine("Enter your Desirable Id:");
                        string CustomId = Console.ReadLine();
                        var newUser = new RegisterVM()
                        {
                            Email = email,
                            Password = password,
                            CustomStudentId = CustomId,
                            FullName = name,
                            PhoneNumber = number
                        };
                        authenthication.Register(newUser);
                        break;
                    case 3:
                        Console.WriteLine("GoodBye");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Enter the right Command!");
                        break;
                }
            }
        }
    }
}
