using DependencyInjectionDemo.DataAccess.DataContext;
using DependencyInjectionDemo.Models;

namespace DependencyInjectionDemo.DataAccess.Service
{
    public class MovieRepository : IMovieRepository
    {
        MovieDbContext dbContext_ref;

        public MovieRepository(MovieDbContext dbContextref) 
        {
            dbContext_ref = dbContextref;
        }

        public bool AddNew(Movie movie)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Movie movie)
        {
            throw new NotImplementedException();
        }

        public bool Edit(Movie movie)
        {
            throw new NotImplementedException();
        }

        public Movie Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Movie> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
