using System.Security.Cryptography.X509Certificates;

namespace WeekTwo_TaskOne.MiddleWare
{
    public class CustomMiddleWare
    {
        private readonly RequestDelegate _name;
        public CustomMiddleWare(RequestDelegate name )
        {
            _name = name;

        }

        public async Task Invoke(HttpContext context )
        {
            Console.WriteLine("==== Request has started ====");
            Console.WriteLine($"Date {DateTime.Now}");
            Console.WriteLine($"path {context.Request.Path}");
            Console.WriteLine($"Method {context.Request.Method}");

            await _name(context);

            Console.WriteLine($"status : {context.Response.StatusCode}");
            Console.WriteLine("Request has Ended");
        }
    }
}
