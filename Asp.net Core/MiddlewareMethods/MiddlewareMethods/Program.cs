
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

//app.Run(async context => await context.Response.WriteAsync("in 1st Run method middleware..."));

//app.Run(async context => await context.Response.WriteAsync("in 2nd Run method middleware..."));

//app.Use(async (context,next) =>
//{
//    Console.WriteLine("Before Next() method call of use method");
//    await next();
//    Console.WriteLine("After Next() method call of use method");
//});

//app.Run(async context => await context.Response.WriteAsync("in Run() method middleware..."));

app.Map("/map",MapHandler);

void MapHandler(IApplicationBuilder builder)
{
    app.Run(async context =>
    {
        Console.WriteLine("In the MapHandler of Map()  method ....");
        await context.Response.WriteAsync("Executing Run() method of MapHandler");
    });
    
}

app.Run();
