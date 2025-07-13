namespace GenericRepositoryPatternDemo.DataAccess.GenercRepository
{
    public interface IGenericRepository <T> where T : class
    {
        List<T> GetAll();
        T? Find(int id);
        bool Add(T entity);
        bool Update(T entity);
        bool Delete(int id);
    }
}
