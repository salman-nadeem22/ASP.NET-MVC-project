using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AptechProject.Models
{
    public class Winners
    {
        public int Id { get; set; }
        [Display(Name ="Comment Who Will Win The Competition.")]
        [Required(ErrorMessage ="Enter The Name")]
        public String NameOfWinner { get; set; }
        [Display(Name = "Enter The Student Roll No")]
        [Required(ErrorMessage = "Enter The Roll No")]
        public String StudentRollNo { get; set; }
        [Display(Name ="Enter The Name Of Survey")]
        [Required(ErrorMessage ="Enter The Survey Name")]
        public String SurveyName { get; set; }
    }
}