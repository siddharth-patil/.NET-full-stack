using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCodeFirstLibrary.Model
{
    public class EmployeeMVC
    {
        [Key]
        public int EmpId { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(30)]
        public string FirstName { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(30)]
        public string LastName { get; set; }

        [Required]
        [StringLength(9)]
        public string Gender { get; set; }

        [Required]
        [StringLength(20)]
        public string Designation { get; set; }

        [Required]
        [StringLength(100)]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Range(18, 58)]
        public int Age { get; set; }

        [Required]
        public double Salary { get; set; }

    }
}
