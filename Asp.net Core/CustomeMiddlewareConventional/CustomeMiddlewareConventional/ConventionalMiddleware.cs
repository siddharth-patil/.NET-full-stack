namespace CustomeMiddlewareConventional
{
    public class ConventionalMiddleware
    {
        private RequestDelegate _next;

        public ConventionalMiddleware(RequestDelegate next) { 
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            Console.WriteLine("In the conventional middleware before next() call...");
            await _next(context);
            Console.WriteLine("In the conventional middleware after next() call...");
        }

    }
}
