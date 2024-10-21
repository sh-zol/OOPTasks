using SuperClassModel.DB;
using SuperClassModel.Interfaces;
using SuperClassModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperClassModel.Implementation
{
    public class Authenthication : IAuthentication
    {
        public int Login(LoginVM loginVM)
        {
            var ceo = DataBase.Ceos?.FirstOrDefault(x=>x.Email == loginVM.Email && x.Password == loginVM.Password);
            var chair = DataBase.Chairmen?.FirstOrDefault(x => x.Email == loginVM.Email && x.Password == loginVM.Password);
            var manager = DataBase.Managers?.FirstOrDefault(x => x.Email == loginVM.Email && x.Password == loginVM.Password);
            var officeEmployee = DataBase.OfficeEmployees?.FirstOrDefault(x => x.Email == loginVM.Email && x.Password == loginVM.Password);
            var supervisor = DataBase.Supervisors?.FirstOrDefault(x => x.Email == loginVM.Email && x.Password == loginVM.Password);
            if (ceo != null)
            {
                DataBase.CurrentCeo = ceo;
                return 4;
            }
            else if (chair != null)
            {
                DataBase.CurrentCHairman = chair;
                return 5;
            }
            else if (manager != null)
            {
                DataBase.CurrentManager = manager;
                return 2;
            }
            else if (officeEmployee != null)
            {
                DataBase.CurrentOfficeEmployee = officeEmployee;
                return 1;
            }
            else if (supervisor != null)
            {
                DataBase.CurrentSupervisor = supervisor;
                return 3;
            }
            else
            {
                Console.WriteLine("user doesn't exist");
                return 0;
            }
        }

        public bool Logout()
        {
            DataBase.CurrentCeo = null;
            DataBase.CurrentManager = null;
            DataBase.CurrentSupervisor = null;
            DataBase.CurrentCHairman = null;
            DataBase.CurrentOfficeEmployee = null;
            return true;
        }

        public void Register(RegisterVM registerVM)
        {
            if(registerVM.Role == 5)
            {
                var user = new Chairman
                {
                    Email = registerVM.Email,
                    Address = registerVM.Address,
                    FirstName = registerVM.FirstName,
                    LastName = registerVM.LastName,
                    Password = registerVM.Password,
                };
                DataBase.Chairmen?.Add(user);
            }
            else if(registerVM.Role == 4)
            {
                var ceo = new Ceo
                {
                    Email = registerVM.Email,
                    Address = registerVM.Address,
                    FirstName = registerVM.FirstName,
                    LastName = registerVM.LastName,
                    Password = registerVM.Password,
                };
                DataBase.Ceos?.Add(ceo);
            }
            else if(registerVM.Role == 3)
            {
                var supervisor = new Supervisor
                {
                    Email = registerVM.Email,
                    Address = registerVM.Address,
                    FirstName = registerVM.FirstName,
                    LastName = registerVM.LastName,
                    Password = registerVM.Password,
                };
                DataBase.Supervisors?.Add(supervisor);
            }
            else if(registerVM.Role == 2)
            {
                var manager = new Manager
                {
                    Email = registerVM.Email,
                    Address = registerVM.Address,
                    FirstName = registerVM.FirstName,
                    LastName = registerVM.LastName,
                    Password = registerVM.Password,
                };
                DataBase.Managers?.Add(manager);
            }
            else if(registerVM.Role == 1)
            {
                var employee = new OfficeEmployee
                {
                    Email = registerVM.Email,
                    Address = registerVM.Address,
                    FirstName = registerVM.FirstName,
                    LastName = registerVM.LastName,
                    Password = registerVM.Password,
                };
                DataBase.OfficeEmployees?.Add(employee);
            }

        }
    }
}
