using GenericRepositoryPatternDemo.DataAccess.GenercRepository;
using GenericRepositoryPatternDemo.Models;

namespace GenericRepositoryPatternDemo.DataAccess.Repositories.ProductRepository
{
    public interface IProductRepositpry:IGenericRepository<Products>
    {
        List<Products> SortProducts(string criteria); 
    }
}
