using GenericRepositoryPatternDemo.DataAccess.GenercRepository;
using GenericRepositoryPatternDemo.Models;

namespace GenericRepositoryPatternDemo.DataAccess.Repositories.ProductRepository
{
    public class ProductRepository : GenericRepository<Products>,IProductRepositpry
    {
        private readonly ApplicationDBContext _context_ref;

        public ProductRepository(ApplicationDBContext context) : base(context)
        {
            _context_ref = context;
        }

        public List<Products> SortProducts(string criteria)
        {
            List<Products> sortedProducts = new List<Products>();
            try
            {
                switch (criteria)
                {
                    case "Name":
                        sortedProducts = _context_ref.Products.OrderBy(p=>p.Name).ToList();
                        break;
                    case "Description":
                        sortedProducts = _context_ref.Products.OrderBy(p=>p.Description).ToList();
                        break;
                    default:
                        sortedProducts = _context_ref.Products.OrderBy(p => p.Name).ToList();
                        break;
                }
                return sortedProducts;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
