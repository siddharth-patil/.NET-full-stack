using GenericRepositoryPatternDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace GenericRepositoryPatternDemo.DataAccess.GenercRepository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly ApplicationDBContext conext_ref;
        private readonly DbSet<T> dbSet;

        public GenericRepository(ApplicationDBContext context) 
        {
            conext_ref = context;
            dbSet = context.Set<T>();
        }
        public bool Add(T entity)
        {
            bool status = false;

            try
            {
                dbSet.Add(entity);
                conext_ref.SaveChanges();
                status = true;
            }
            catch (Exception)
            {

                throw;
            }
            return status;
        }

        public bool Delete(int id)
        {
            bool status = false ;

            try
            {
               T searchedEntity = dbSet.Find(id);
                if (searchedEntity != null)
                {
                    dbSet.Remove(searchedEntity);
                    status = true;
                }

            }
            catch (Exception)
            {

                throw;
            }
            return status;
        }

        public T? Find(int id)
        {
            T entity = dbSet.Find(id);
            return (entity != null) ? entity : null;
        }

        public List<T> GetAll()
        {
            return dbSet.ToList();
        }

        public bool Update(T entity)
        {
            bool status = false ;
            try
            {
                conext_ref.Entry(entity).State = EntityState.Modified;
                conext_ref.SaveChanges();
                status = true;
            }
            catch (Exception)
            {

                throw;
            }
            return status;
        }
    }
}
