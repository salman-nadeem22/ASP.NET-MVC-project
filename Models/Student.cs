using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AptechProject.Models
{
    public class Student
    {
        [Key]
        public int ID { get; set; }
        [Required(ErrorMessage = "Enter Correct Information"), MaxLength(20)]
        public String FirstName { get; set; }
        [Required(ErrorMessage = "Enter Correct Information"), MaxLength(20)]
        public String LastName { get; set; }
        [Required(ErrorMessage = "Enter Correct Information")]
        public String RollNo { get; set; }
        [Required(ErrorMessage = "Enter Correct Information"), MaxLength(20)]
        public String City { get; set; }
        [Required(ErrorMessage = "Enter Correct Information"), MaxLength(20)]
        public String Country { get; set; }
        [Required(ErrorMessage = "Enter Correct Information"), MaxLength(20)]
        public String Contact { get; set; }
        [Required(ErrorMessage = "Enter Correct Information"), MaxLength(20)]
        public String Telephone { get; set; }
        [Required(ErrorMessage = "Enter Correct Information"), MaxLength(20)]
        public String DateOFBirth { get; set; }

        public Competition competition { get; set; }
    }
}