using System;
using System.Collections.Generic;

namespace CollegeApp.Entities.DataModels
{
    public partial class Course
    {
        public int CourseId { get; set; }
        public string? Name { get; set; }
        public bool? Status { get; set; }
    }
}
