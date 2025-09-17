using CitiesManager.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace CitiesManager.Web.DatabaseContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public ApplicationDbContext()
        {

        }

        public virtual DbSet<City> Cities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<City>().HasData(new City() { CityID = Guid.Parse("CD0A9526-585E-423C-8865-77903FD9323E"),
                CityName = "New York" });

            modelBuilder.Entity<City>().HasData(new City() { CityID = Guid.Parse("55546F87-EB17-4F74-9A2C-FB2954DF6A54"),
                CityName = "Los Angeles" });
        }

        internal object FindAsync(Guid cityId)
        {
            throw new NotImplementedException();
        }
    }
}
