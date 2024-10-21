using Student.DB;
using Student.Interfaces;
using Student.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.Implementation
{
    public class Authenthication : IAuthentication
    {
        public bool Login(LoginVM loginVM)
        {
            var user = DataBase.Students?.FirstOrDefault(x=>x.Email == loginVM.Email && x.Password == loginVM.Password);
            if (user != null)
            {
                DataBase.CurrentStudent = user;
                return true;
            }
            else
            {
                Console.WriteLine("user doesn't exist");
                return false;
            }
        }

        public void Logout()
        {
            DataBase.CurrentStudent = null;
        }

        public void Register(RegisterVM registerVM)
        {
            var user = new Student.Models.Student()
            {
                Email = registerVM.Email,
                Password = registerVM.Password,
                Name = registerVM.FullName,
                PhoneNumber = registerVM.PhoneNumber,
                StudentId = registerVM.CustomStudentId
            };
            DataBase.Students?.Add(user);
        }
    }
}
