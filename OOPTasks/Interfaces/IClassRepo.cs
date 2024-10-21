using Student.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.Interfaces
{
    public interface IClassRepo
    {
        void PickClass(string classId);
        List<Lecture> GetAllClasses();
        Lecture GetLecture(string classId);
        List<Lecture> GetLecturesByCourseId(int courseId);
    }
}
