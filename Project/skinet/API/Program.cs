using Core.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
//builder.Services.AddOpenApi();
builder.Services.AddDbContext<StoreContext>(opt =>
{
    opt.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
}); // Add your DbContext here

builder.Services.AddScoped<IProductRepository, ProductRepository>(); // Add your repository here
builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

try
{
    using var scope = app.Services.CreateScope(); // Create a scope to get scoped services like DbContext
    var services = scope.ServiceProvider; // Get the service provider
    var context = services.GetRequiredService<StoreContext>(); // Get your DbContext
    await context.Database.MigrateAsync(); // Apply any pending migrations
    await StoreContextSeed.SeedAsync(context); // Seed the database
}
catch (Exception ex)
{
    Console.WriteLine(ex);
	throw;
}

app.Run();
