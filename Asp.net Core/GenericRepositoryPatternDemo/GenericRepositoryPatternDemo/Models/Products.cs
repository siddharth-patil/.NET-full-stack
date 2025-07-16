using System.ComponentModel.DataAnnotations;

namespace GenericRepositoryPatternDemo.Models
{
    public class Products
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(500)]
        public string Description { get; set; }

        [Required]
        public double Price { get; set; }

        public int CategoryId { get; set; }

        //Navigation properties

        public Category Category { get; set; }
    }
}
