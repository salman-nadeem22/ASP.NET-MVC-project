using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AptechProject.Models
{
    public class Competition
    {
        [Key]
        public int Id { get; set; }
        public String StudentName { get; set; }
        public String StudentId { get; set; }
        public int Points { get; set; }

        public List<Student> Com_student_details { get; set; }
    }
}