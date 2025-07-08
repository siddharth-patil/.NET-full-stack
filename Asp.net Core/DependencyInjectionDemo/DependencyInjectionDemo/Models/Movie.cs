using System.ComponentModel.DataAnnotations;

namespace DependencyInjectionDemo.Models
{
    public class Movie
    {
        [Key]
        public int MovieId { get; set; }

        [Required]
        [StringLength(100)]
        public string MovieName { get; set; }

        [Required]
        public DateOnly ReleaseDate { get; set; }

        [Required]
        public double Rating { get; set; }
    }
}
