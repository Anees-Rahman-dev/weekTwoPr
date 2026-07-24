using System.Security.Cryptography.X509Certificates;

namespace WeekTwo_TaskOne.MiddleWare
{
   public class CustomMiddleware
    {

        public RequestDelegate _next;
        public CustomMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            Console.WriteLine("=== request has started ===");
            Console.WriteLine($"Time {DateTime.Now}");
            Console.WriteLine($"Path {context.Request.Path}");
            Console.WriteLine($"Method {context.Request.Method}");

            await _next(context);

            Console.WriteLine("=== request has finished ===");

            Console.WriteLine($"Respone {context.Response.StatusCode}");
        }
    }
}
