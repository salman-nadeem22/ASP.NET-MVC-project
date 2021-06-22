using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AptechProject.Models
{
    public class Survey
    {
        [Key]
        public int ID { get; set; }
        
        [Required(ErrorMessage = "Enter The Information")]
        [MaxLength(15)]
        public String SurveyName { get; set; }

        [Required(ErrorMessage = "Enter The Information")]
        [MaxLength(50)]
        [Display(Name = "Made By")]
        public String CreatedBy { get; set; }

        [Required(ErrorMessage = "Enter The Information")]
        [MaxLength(15)]
        [Display(Name = "Student ID")]
        public String StudentID { get; set; }

        [Required(ErrorMessage ="Enter The Information")]
        [MaxLength(400)]
        [Display(Name ="Question no 1")]
        public String Survey_1 { get; set; }
        [Required(ErrorMessage = "Enter The Information")]
        [MaxLength(100)]
        [Display(Name = "1 ")]
        public String Survey_1_option_1 { get; set; }
        [Required(ErrorMessage = "Enter The Information")]
        [MaxLength(100)]
        [Display(Name = "2 ")]
        public String Survey_1_option_2 { get; set; }
        [Required(ErrorMessage = "Enter The Information")]
        [MaxLength(100)]
        [Display(Name = "3 ")]
        public String Survey_1_option_3 { get; set; }

        [Required(ErrorMessage = "Enter The Information")]
        [MaxLength(400)]
        [Display(Name = "Question no 2")]
        public String Survey_2 { get; set; }
        [Required(ErrorMessage = "Enter The Information")]
        [MaxLength(100)]
        [Display(Name = "1 ")]
        public String Survey_2_option_1 { get; set; }
        [Required(ErrorMessage = "Enter The Information")]
        [MaxLength(100)]
        [Display(Name = "2 ")]
        public String Survey_2_option_2 { get; set; }
        [Required(ErrorMessage = "Enter The Information")]
        [MaxLength(100)]
        [Display(Name = "3 ")]
        public String Survey_2_option_3 { get; set; }

        [Required(ErrorMessage = "Enter The Information")]
        [MaxLength(400)]
        [Display(Name = "Question no 3")]
        public String Survey_3 { get; set; }
        [Required(ErrorMessage = "Enter The Information")]
        [MaxLength(100)]
        [Display(Name = "1 ")]
        public String Survey_3_option_1 { get; set; }
        [Required(ErrorMessage = "Enter The Information")]
        [MaxLength(100)]
        [Display(Name = "2 ")]
        public String Survey_3_option_2 { get; set; }
        [Required(ErrorMessage = "Enter The Information")]
        [MaxLength(100)]
        [Display(Name = "3 ")]
        public String Survey_3_option_3 { get; set; }

        [Required(ErrorMessage = "Enter The Information")]
        [MaxLength(400)]
        [Display(Name = "Question no 4")]
        public String Survey_4 { get; set; }
        [Required(ErrorMessage = "Enter The Information")]
        [MaxLength(100)]
        [Display(Name = "1 ")]
        public String Survey_4_option_1 { get; set; }
        [Required(ErrorMessage = "Enter The Information")]
        [MaxLength(100)]
        [Display(Name = "2 ")]
        public String Survey_4_option_2 { get; set; }
        [Required(ErrorMessage = "Enter The Information")]
        [MaxLength(100)]
        [Display(Name = "3 ")]
        public String Survey_4_option_3 { get; set; }

        [Required(ErrorMessage = "Enter The Information")]
        [MaxLength(400)]
        [Display(Name = "Question no 5")]
        public String Survey_5 { get; set; }
        [Required(ErrorMessage = "Enter The Information")]
        [MaxLength(100)]
        [Display(Name = "1 ")]
        public String Survey_5_option_1 { get; set; }
        [Required(ErrorMessage = "Enter The Information")]
        [MaxLength(100)]
        [Display(Name = "2 ")]
        public String Survey_5_option_2 { get; set; }
        [Required(ErrorMessage = "Enter The Information")]
        [MaxLength(100)]
        [Display(Name = "3 ")]
        public String Survey_5_option_3 { get; set; }

        [Required(ErrorMessage ="Enter The Information")]
        [Display(Name ="Date")]
        public String dateTime { get; set; }
    }
}