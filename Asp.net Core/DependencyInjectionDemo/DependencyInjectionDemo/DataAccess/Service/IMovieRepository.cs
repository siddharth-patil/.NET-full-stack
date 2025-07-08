using DependencyInjectionDemo.Models;

namespace DependencyInjectionDemo.DataAccess.Service
{
    public interface IMovieRepository
    {
        List <Movie> GetAll ();

        Movie Get (int id);

        bool AddNew(Movie movie);

        bool Edit (Movie movie);

        bool Delete (Movie movie);  
    }
}
