using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperClassModel.Models
{
    public abstract class Employee
    {
        public int Id { get; set; }
        [StringLength(30)]
        public string? FirstName { get; set; }
        [StringLength(30)]
        public string? LastName { get; set; }
        [StringLength(50)]
        public string? Email { get; set; }
        [StringLength(30)]
        public string? Address { get; set; }
        [StringLength(30)]
        public string? Password { get; set; }
        public Title Title { get; set; }
    }
}
