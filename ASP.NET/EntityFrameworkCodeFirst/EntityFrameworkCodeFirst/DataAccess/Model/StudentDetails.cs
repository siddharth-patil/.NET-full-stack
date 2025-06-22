using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCodeFirst.DataAccess.Model
{
    //[Table("StudentDetails")]
    public class StudentDetails
    {
        [Key]
        public int Roll {  get; set; }

        [Required(ErrorMessage = "First name is mandatory!!")]
        [StringLength(20)]
        public string FirstName { get; set; }


        [Required(ErrorMessage = "Last name is mandatory!!")]
        [StringLength(30)]
        public string LastName { get; set; }

        [Required(ErrorMessage ="ender is mandatory..")]
        [StringLength(10)]
        public string Gender { get; set; }

        [Required(ErrorMessage ="Email is mandatory")]
        [StringLength(200)]
        [EmailAddress(ErrorMessage ="Please provide valid email address...")]
        public string Email { get; set; }

        [Required(ErrorMessage ="Qualification is mandatory")]
        [StringLength (50)]
        public string Qualification { get; set; }

        [Required(ErrorMessage = "DoB is mandatory")]
        public DateTime DateofBirth { get; set; }

        //[Required]
        //public int Mobile {  get; set; }

        //[Required]
        //public string Institute { get; set; }

        [Required(ErrorMessage = "Percentage is mandatory")]
        public double Percentage { get; set; }
    }
}
