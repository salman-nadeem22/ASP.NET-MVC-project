using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AptechProject.Models
{
    public class Effective_Participation
    {
        public int Id { get; set; }
        [Required]
        public String Discription { get; set; }
        public Survey survey { get; set; }
        public int surveyId { get; set; }
        public int EnrollmentNo { get; set; }
        public String UserName { get; set; }
    }
}