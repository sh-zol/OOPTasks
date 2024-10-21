using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.Models
{
    public class Lecture
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public Course? Course { get; set; }
        public int CourseId { get; set; }
        [StringLength(10)]
        public string? LectureId { get; set; }
    }
}
