using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AptechProject.Models
{
    public class Ranking
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Enter The Information")]
        public String StudentName { get; set; }
        [Required(ErrorMessage = "Enter The Information")]
        public String SurveyName { get; set; }
        [Required(ErrorMessage = "Enter The Information")]
        public int SurveyId { get; set; }
        [Required(ErrorMessage = "Enter The Information")]
        public int StudentRollNo { get; set; }
        [Required(ErrorMessage = "Enter The Information")]
        public String Rank { get; set; }
        [Required(ErrorMessage = "Enter The Information")]
        public String Prize { get; set; }
    }
}
