using System;
using System.Collections.Generic;

namespace CollegeApp.Entities.DataModels
{
    public partial class Enrollment
    {
        public int? StudentId { get; set; }
        public int? CourseId { get; set; }

        public virtual Course? Course { get; set; }
        public virtual Student? Student { get; set; }
    }
}
