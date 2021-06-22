using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AptechProject.Models
{
    public class Courses
    {
        [Key]
        public int ID { get; set; }
        [Required(ErrorMessage = "Enter Correct Information"), MaxLength(20)]
        public String CourseName { get; set; }
        [Required(ErrorMessage ="Enter Correct Information")]
        public string hours { get; set; }
        [Required(ErrorMessage = "Enter Correct Information"), MaxLength(20)]
        public String CourseFor { get; set; }
        [Required(ErrorMessage = "Enter Correct Information"), MaxLength(20)]
        public String TotalMarks { get; set; }

    }
}