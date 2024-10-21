using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.Models
{
    public class Student
    {
        public int Id { get; set; }
        [StringLength(30)]
        public string? Name { get; set; }
        [StringLength(30)]
        public string? Email { get; set; }
        [StringLength(30)]
        public string? Password { get; set; }
        [StringLength(11)]
        public string? PhoneNumber { get; set; }
        public List<Lecture> Classes { get; set; } = new();
        [StringLength(14)]
        public string? StudentId { get; set; }
    }
}
