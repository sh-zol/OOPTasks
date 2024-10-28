using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePoly.Models
{
    public class Company
    {
        #region Lists
        public static List<Person>? People;
        public static List<Manager>? Managers;
        public static List<Employee>? Employees;
        #endregion

        #region Ctor
        public Company()
        {
            People?.Add(
                new Person
                {
                    Id = 1,
                    Name = "person1",
                    Email = "personemail1@gmail.com",
                    Address = "tehran",
                    CompanyName = "genericCompanyName",
                    Password = "123456",
                    PhoneNumber = "12345678901"
                }
                );
            Managers?.Add(
                new Manager
                {
                    Id = 1,
                    Name = "manager1",
                    Email = "manageremail1@gmail.com",
                    PhoneNumber = "12345678902",
                    Address = "tehran",
                    Password = "123456",
                    CompanyName = "GenericCompanyName"
                }
                );
            Employees?.Add(
                new Employee
                {
                    Id = 1,
                    Email = "employeeemail1@gmail.com",
                    Name = "employee1",
                    Address = "tehran",
                    CompanyName = "genericcompanyname",
                    Password = "123456",
                    PhoneNumber = "12345678903"
                }
                );
        }
        #endregion

        public static void Start()
        {
            bool flag = true;
            while(flag)
            {
                Console.WriteLine("1.People List");
                Console.WriteLine("2.Managers List");
                Console.WriteLine("3.Employees List");
                Console.WriteLine("4.Make an Employee");
                Console.WriteLine("5.Make an Manager");
                Console.WriteLine("6.Make an Person");
                Console.WriteLine("7.Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                        foreach(var item in People)
                        {
                            Console.WriteLine($"Id:{item.Id}, Name: {item.Name}, Email:{item.Email}, Password: {item.Password}, Address: {item.Address}, PhoneNumber: {item.PhoneNumber}, Company: {item.CompanyName}");
                        }
                        break;
                    case 2:
                        foreach(var item in Managers)
                        {
                            Console.WriteLine($"Id:{item.Id}, Name: {item.Name}, Email:{item.Email}, Password: {item.Password}, Address: {item.Address}, PhoneNumber: {item.PhoneNumber}, Company: {item.CompanyName}");
                        }
                        break;
                    case 3:
                        foreach(var item in Employees)
                        {
                            Console.WriteLine($"Id:{item.Id}, Name: {item.Name}, Email:{item.Email}, Password: {item.Password}, Address: {item.Address}, PhoneNumber: {item.PhoneNumber}, Company: {item.CompanyName}");
                        }
                        break;
                    case 4:
                        Employee emp = new();
                        int count = Employees.Count;
                        emp.Id = count++;
                        Console.WriteLine("Name:");
                        emp.Name = Console.ReadLine();
                        Console.WriteLine("Email:");
                        emp.Email = Console.ReadLine();
                        Console.WriteLine("Password:");
                        emp.Password = Console.ReadLine();
                        Console.WriteLine("Address:");
                        emp.Address = Console.ReadLine();
                        Console.WriteLine("PhoneNumber:");
                        emp.PhoneNumber = Console.ReadLine();
                        Console.WriteLine("CompanyName:");
                        emp.CompanyName = Console.ReadLine();
                        emp.Identity();
                        break;
                    case 5:
                        Manager man = new();
                        count = Managers.Count;
                        man.Id = count++;
                        Console.WriteLine("Name:");
                        man.Name = Console.ReadLine();
                        Console.WriteLine("Email:");
                        man.Email = Console.ReadLine();
                        Console.WriteLine("Password");
                        man.Password = Console.ReadLine();
                        Console.WriteLine("Address:");
                        man.Address = Console.ReadLine();
                        Console.WriteLine("PhoneNumber:");
                        man.PhoneNumber = Console.ReadLine();
                        Console.WriteLine("CompanyName:");
                        man.CompanyName = Console.ReadLine();
                        man.Identity();
                        break;
                    case 6:
                        Person per = new();
                        count = People.Count;
                        per.Id = count++;
                        Console.WriteLine("Name:");
                        per.Name = Console.ReadLine();
                        Console.WriteLine("Email:");
                        per.Email = Console.ReadLine();
                        Console.WriteLine("Password");
                        per.Password = Console.ReadLine();
                        Console.WriteLine("Address:");
                        per.Address = Console.ReadLine();
                        Console.WriteLine("PhoneNumber:");
                        per.PhoneNumber = Console.ReadLine();
                        Console.WriteLine("CompanyName:");
                        per.CompanyName = Console.ReadLine();
                        per.Identity();
                        break;
                    case 7:
                        Console.WriteLine("Goodbye");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Enter the right command!");
                        break;
                }
            }
        }
    }
}
