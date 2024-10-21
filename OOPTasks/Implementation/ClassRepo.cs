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
    public class ClassRepo : IClassRepo
    {
        public List<Lecture> GetAllClasses()
        {
            var list = DataBase.Lectures?.ToList();
            if(list != null)
            {
                return list;
            }
            else
            {
                return new List<Lecture>();
            }
        }

        public Lecture GetLecture(string classId)
        {
            var lecture = DataBase.Lectures?.Where(x=>x.LectureId == classId).FirstOrDefault();
            if(lecture != null)
            {
                return lecture;
            }
            else
            {
                throw new Exception();
            }
        }

        public List<Lecture> GetLecturesByCourseId(int courseId)
        {
            var list = DataBase.Lectures?.Where(x=>x.CourseId == courseId).ToList();
            if( list != null )
            {
                return list;
            }
            else
            {
                return new List<Lecture>();
            }
        }

        public void PickClass(string classId)
        {
            var lecture = DataBase.Lectures?.FirstOrDefault(x=>x.LectureId == classId);
            if(lecture != null )
            {
                DataBase.CurrentStudent?.Classes.Add(lecture);
                Console.WriteLine("Class picked");
            }
        }
    }
}
