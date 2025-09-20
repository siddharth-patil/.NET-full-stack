using Asp.Versioning;
using Asp.Versioning.ApiExplorer;
using CitiesManager.Web.DatabaseContext;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers(options => { 
    options.Filters.Add(new ProducesAttribute("application/json"));
    options.Filters.Add(new ConsumesAttribute("application/json"));
}).AddXmlSerializerFormatters();

builder.Services.AddApiVersioning(config=> {
    config.ApiVersionReader = new UrlSegmentApiVersionReader(); //reads version from url segment at apiVersion constrainsts

    config.DefaultApiVersion = new ApiVersion(1, 0);
    config.AssumeDefaultVersionWhenUnspecified = true;
    config.ReportApiVersions = true;
    //config.ApiVersionReader = new QueryStringApiVersionReader(); //reads version from query string called api-version
    
    //config.ApiVersionReader = new HeaderApiVersionReader("X-Version"); //reads version from header called X-Version
});

builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

//Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, "api.xml"));

    options.SwaggerDoc("v1",
        new Microsoft.OpenApi.Models.OpenApiInfo()
        {
            Title = "Cities Web API",
            Version = "1.0"
        }
    );
    options.SwaggerDoc("v2",
        new Microsoft.OpenApi.Models.OpenApiInfo()
        {
            Title = "Cities Web API",
            Version = "2.0"
        }
    );
});

builder.Services.AddApiVersioning().AddApiExplorer(options =>
{
    options.GroupNameFormat = "'v'VVV"; //v1, v1.0
    options.SubstituteApiVersionInUrl = true;
});

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policyBuilder =>
    {
        policyBuilder.WithOrigins(builder.Configuration.GetSection("AllowedOrigins").Get<string[]>())
        .WithHeaders("Authorization", "origin", "accept", "content-type")
        .WithMethods("GET", "POST", "PUT", "DELETE");
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseHsts();
app.UseHttpsRedirection();

app.UseSwagger(); // Enable middleware to serve generated Swagger as a JSON endpoint. (creates endpoint for swagger.json)
app.UseSwaggerUI(options=>
{
    options.SwaggerEndpoint("/swagger/v1/swagger.json", "1.0");
    options.SwaggerEndpoint("/swagger/v2/swagger.json", "2.0");
});

app.UseRouting();
app.UseCors();

app.UseAuthorization();

app.MapControllers();

app.Run();
