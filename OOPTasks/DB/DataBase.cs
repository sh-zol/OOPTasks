using Student.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.DB
{
    public static class DataBase
    {
        public static Student.Models.Student? CurrentStudent;
        public static List<Student.Models.Student>? Students = new();
        public static List<Course>? Courses = new();
        public static List<Lecture>? Lectures = new();

        static DataBase()
        {
            Students.Add(new Student.Models.Student()
            {
                Id = 1,
                Email = "studentemail@gmail.com",
                Name = "student1",
                Password = "123456",
                PhoneNumber = "12345678901",
                StudentId = "12345678912345"
            });

            Courses.Add(new Course()
            {
                Id = 1,
                Name = "course1"
            });
            Courses.Add(new Course()
            {
                Id = 2,
                Name = "course2"
            });

            Lectures.Add(new Lecture()
            {
                Id = 1,
                Name = "Lecture1",
                CourseId = 1,
                LectureId = "1234567890"
            });
            Lectures.Add(new Lecture()
            {
                Id = 2,
                Name = "Lecture2",
                LectureId = "1234567891",
                CourseId = 1,
            });
            Lectures.Add(new Lecture()
            {
                Id = 3,
                CourseId = 2,
                LectureId = "1234567892",
                Name = "Lecture3"
            });
            Lectures.Add(new Lecture()
            {
                Id = 4,
                Name = "Lecture4",
                LectureId = "1234567893",
                CourseId = 2,
            });
        }
    }
}
