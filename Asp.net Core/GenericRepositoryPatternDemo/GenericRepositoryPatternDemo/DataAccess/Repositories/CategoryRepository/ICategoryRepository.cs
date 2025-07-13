using GenericRepositoryPatternDemo.DataAccess.GenercRepository;
using GenericRepositoryPatternDemo.Models;

namespace GenericRepositoryPatternDemo.DataAccess.Repositories.CategoryRepository
{
    public interface ICategoryRepository:IGenericRepository<Category>
    {
        List<Category> OrderbyCategories(string name);
    }
}
