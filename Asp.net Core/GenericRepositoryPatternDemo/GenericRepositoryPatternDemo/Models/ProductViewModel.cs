using System.ComponentModel.DataAnnotations;

namespace GenericRepositoryPatternDemo.Models
{
    public class ProductViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public double Price { get; set; }

        //Navigation properties

        public string CatagoryName{ get; set; }
    }
}
