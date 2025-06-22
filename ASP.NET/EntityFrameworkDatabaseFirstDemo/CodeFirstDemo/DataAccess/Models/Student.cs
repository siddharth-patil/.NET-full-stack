using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;


namespace CodeFirstDemo.DataAccess.Models
{
   
    public class StudentDetails
    {
        [Key]
        public int Roll { get; set; }
        [Required(ErrorMessage ="FirstName is Manadatory!!!")]
        [StringLength(20)]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "LastName is Manadatory!!!")]
        [StringLength(30)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Gender is Manadatory!!!")]
        [StringLength(15)]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Email is Manadatory!!!")]
        [StringLength(200)]
        [EmailAddress(ErrorMessage ="Please provide valid Email!!!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Qualification is Manadatory!!!")]
        [StringLength(70)]
        public string Qualification { get; set; }

        [Required(ErrorMessage = "Date is Manadatory!!!")]
        
        public DateTime DateofBirth { get; set; }

        //[Required]
        //public int Mobile { get; set; }

        //[Required]
        //public string InstituteName { get; set; }

        [Required(ErrorMessage = "Percentage is Manadatory!!!")]
        public double Percentage { get; set; }


    }
}
