using System.ComponentModel.DataAnnotations;

namespace GenericRepositoryPatternDemo.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        //Navigation properties
        public List<Products> products { get; set; }
    }
}
