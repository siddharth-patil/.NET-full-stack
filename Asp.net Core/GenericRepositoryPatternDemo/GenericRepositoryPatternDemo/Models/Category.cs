namespace GenericRepositoryPatternDemo.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //Navigation properties

        public List<Products> products { get; set; }
    }
}
