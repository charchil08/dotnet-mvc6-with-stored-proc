﻿using System;
using System.Collections.Generic;

namespace CollegeApp.Entities.DataModels
{
    public partial class Student
    {
        public int StudentId { get; set; }
        public string? Name { get; set; }
        public int? TeacherId { get; set; }
    }
}
