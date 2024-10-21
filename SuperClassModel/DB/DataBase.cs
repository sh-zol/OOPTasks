using SuperClassModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperClassModel.DB
{
    public static class DataBase
    {
        //Current Users Based On Roles/Job Titles
        public static Ceo? CurrentCeo;
        public static Chairman? CurrentCHairman;
        public static Manager? CurrentManager;
        public static Supervisor? CurrentSupervisor;
        public static OfficeEmployee? CurrentOfficeEmployee;

        //DbSets
        public static List<Ceo>? Ceos = new();
        public static List<Chairman>? Chairmen = new();
        public static List<Manager>? Managers = new();
        public static List<Supervisor>? Supervisors = new();
        public static List<OfficeEmployee>? OfficeEmployees = new();

        //Seed Data
        static DataBase()
        {
            Ceos.Add(new Ceo
            {
                Id = 1,
                Email = "ceoemail@gmail.com",
                FirstName = "ceofname",
                LastName = "ceolname",
                Address = "some city",
                Password = "123456"
            });

            Chairmen.Add(new Chairman
            {
                Id = 1,
                Email = "chairmanemail@gmail.com",
                Password = "123456",
                FirstName = "chairmanfname",
                LastName = "chairmanlname"
            });

            Managers.Add(new Manager
            {
                Id = 1,
                Email = "manageremail@gmail.com",
                FirstName = "Managerfname",
                LastName = "managerlname",
                Password = "123456"
            });

            Supervisors.Add(new Supervisor
            {
                Id = 1,
                Email = "supervisoremail@gmail.com",
                FirstName = "supfname",
                LastName = "suplname",
                Password = "123456"
            });

            OfficeEmployees.Add(new OfficeEmployee
            {
                Id = 1,
                Email = "employeeemail@gmail.com",
                Password = "123456",
                FirstName = "empfname",
                LastName = "emplname",
                
            });
        }
    }
}
