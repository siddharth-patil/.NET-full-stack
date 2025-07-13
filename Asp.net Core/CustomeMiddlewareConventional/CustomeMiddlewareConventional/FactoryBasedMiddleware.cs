
namespace CustomeMiddlewareConventional
{
    public class FactoryBasedMiddleware : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            Console.WriteLine("In the Factory based middleware before next() call...");
            await next(context);
            Console.WriteLine("In the Factory based middleware after next() call...");
        }
    }
}
