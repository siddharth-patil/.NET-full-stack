using GenericRepositoryPatternDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace GenericRepositoryPatternDemo.DataAccess
{
    public class ApplicationDBContext:DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options):base(options)
        {
            
        }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Products> Products { get; set; }
    }
}
