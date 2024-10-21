using SuperClassModel.DB;
using SuperClassModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperClassModel.Implementation
{
    public class StartMenu
    {
        public static void Start()
        {
            bool flag = true;
            Authenthication authenthication = new();
            while(flag)
            {
                Console.WriteLine("1.Login");
                Console.WriteLine("2.Register");
                Console.WriteLine("3.Exit");
                Console.WriteLine("4.check stat");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                        LoginVM loginVM = new();
                        Console.WriteLine("Email:");
                        loginVM.Email = Console.ReadLine();
                        Console.WriteLine("Password:");
                        loginVM.Password = Console.ReadLine();
                        var value = authenthication.Login(loginVM);
                        if(value == 1)
                        {
                            Console.WriteLine($"you are logged in as office employee");
                        }
                        else if(value == 2)
                        {
                            Console.WriteLine("you are logged in as manager");
                        }
                        else if(value == 3)
                        {
                            Console.WriteLine("you are logged in as supervisor");
                        }
                        else if(value == 4)
                        {
                            Console.WriteLine("you are logged in as ceo");
                        }
                        else if(value == 5)
                        {
                            Console.WriteLine("you are logged in as chairman");
                        }
                        break;
                    case 2:
                        RegisterVM registerVM = new();
                        Console.WriteLine("Email:");
                        registerVM.Email = Console.ReadLine();
                        Console.WriteLine("Password:");
                        registerVM.Password = Console.ReadLine();
                        Console.WriteLine("First Name:");
                        registerVM.FirstName = Console.ReadLine();
                        Console.WriteLine("Last Name:");
                        registerVM.LastName = Console.ReadLine();
                        Console.WriteLine("Address:");
                        registerVM.Address = Console.ReadLine();
                        authenthication.Register(registerVM);
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                    case 4:
                        if (DataBase.CurrentManager != null)
                        {
                            Console.WriteLine("you are logged in as manager");
                        }
                        else if (DataBase.CurrentCeo != null) 
                        {
                            Console.WriteLine("you are logged in as ceo");
                        }
                        else if(DataBase.CurrentSupervisor != null)
                        {
                            Console.WriteLine("you are logged in as supervisor");
                        }
                        else if(DataBase.CurrentCHairman != null)
                        {
                            Console.WriteLine("you are logged in as chairman");
                        }
                        else if(DataBase.CurrentOfficeEmployee != null)
                        {
                            Console.WriteLine("you are logged in as office employee");
                        }
                        break;
                    default:
                        Console.WriteLine("enter the right command!");
                        break;
                }
            }
        }
    }
}
