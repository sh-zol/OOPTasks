﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public List<Lecture> Classes { get; set; } = new();
    }
}
