﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityServicesApi.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public SubjectStudent[] Subjects { get; set; }
    }
}
