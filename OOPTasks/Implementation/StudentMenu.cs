using Student.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.Implementation
{
    public class StudentMenu
    {
        public static void Start()
        {
            ClassRepo classRepo = new();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter a Command:");
                Console.WriteLine("1.List of Lectures");
                Console.WriteLine("2.Search Lecture by LectureId");
                Console.WriteLine("3.Choose a lecture");
                Console.WriteLine("4.Picked Classes");
                Console.WriteLine("5.Logout");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        var list = classRepo.GetAllClasses();
                        if (list != null)
                        {
                            foreach (var item in list)
                            {
                                Console.WriteLine($"id:{item.Id}, name:{item.Name},");
                            }
                        }
                        break;
                    case 2:
                        Console.WriteLine("Enter the LectureId");
                        string lecId = Console.ReadLine();
                        var lec = classRepo.GetLecture(lecId);
                        if (lec != null)
                        {
                            Console.WriteLine($"id:{lec.Id}, name:{lec.Name}");
                        }
                        break;
                    case 3:
                        list = classRepo.GetAllClasses();
                        if (list != null)
                        {
                            foreach (var item in list)
                            {
                                Console.WriteLine($"id:{item.Id}, name:{item.Name}, lecId:{item.LectureId}");
                            }
                            Console.WriteLine("pick your lecture");
                            lecId = Console.ReadLine();
                            classRepo.PickClass(lecId);
                        }
                        break;
                    case 4:
                        var user = DataBase.CurrentStudent?.Classes;
                        if(user != null)
                        {
                            foreach(var item in user)
                            {
                                Console.WriteLine($"id:{item.Id}, name:{item.Name}, LectureId:{item.LectureId}");
                            }
                        }
                        else
                        {
                            Console.WriteLine("you haven't picked any classes");
                        }
                        break;
                    case 5:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Enter the right command!");
                        break;
                    
                }
            }
        }
    }
}
