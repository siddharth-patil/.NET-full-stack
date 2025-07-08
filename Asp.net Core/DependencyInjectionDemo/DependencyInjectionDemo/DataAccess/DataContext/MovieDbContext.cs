﻿using DependencyInjectionDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace DependencyInjectionDemo.DataAccess.DataContext
{
    public class MovieDbContext:DbContext
    {
        public MovieDbContext(DbContextOptions<MovieDbContext> options):base(options)
        {
            
        }

        public DbSet<Movie> Movies { get; set; }
    }
}
