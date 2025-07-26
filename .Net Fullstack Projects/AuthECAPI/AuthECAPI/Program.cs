using AuthECAPI.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddIdentityApiEndpoints<AppUser>().AddEntityFrameworkStores<AppDbContext>();
builder.Services.Configure<IdentityOptions>(options =>
{
    options.Password.RequireDigit = false;
    options.Password.RequiredLength = 6;
    options.Password.RequireLowercase = true;
    options.Password.RequireUppercase = true;
    
});

builder.Services.AddDbContext<AppDbContext>(options=>
options.UseSqlServer(builder.Configuration.GetConnectionString("DevDB")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

#region Config. CORS
app.UseCors(options=>
    options.WithOrigins("http://localhost:4200") // Adjust the origin as needed
           .AllowAnyMethod()
           .AllowAnyHeader()
           //.AllowCredentials()
);
#endregion

app.UseAuthorization();

app.MapControllers();

app.MapGroup("/api").MapIdentityApi<AppUser>();

app.MapPost("/api/signup", SignupAsync);

app.Run();

static async Task<IResult> SignupAsync(
    [FromServices] UserManager<AppUser> userManager,
    [FromBody] UserRegistrationModel userRegistrationModel)
{
    var user = new AppUser
    {
        Email = userRegistrationModel.Email,
        UserName = userRegistrationModel.Email, // Required by Identity
        FullName = userRegistrationModel.FullName
    };

    var result = await userManager.CreateAsync(user, userRegistrationModel.Password);

    return result.Succeeded ? Results.Ok(result) : Results.BadRequest(result);
}

