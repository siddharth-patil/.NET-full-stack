using GenericRepositoryPatternDemo.Models;

namespace GenericRepositoryPatternDemo.DataAccess.Repositories.CategoryRepository
{
    public class CategoryRepository : GenercRepository.GenericRepository<Category>, ICategoryRepository
    {
        private readonly ApplicationDBContext _context;

        public CategoryRepository(ApplicationDBContext context) : base(context)
        {
            _context = context;
        }

        public List<Category> OrderbyCategories(string name)
        {
            return _context.Categories.OrderBy(cat => cat.Name).ToList();
        }
    }
}
