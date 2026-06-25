using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace MiddleWareExample.CustomMiddleware
{
    public class CustomMiddelware
    {
        private readonly RequestDelegate _next;
        private string fullname = "";

        // Constructor
        public CustomMiddelware(RequestDelegate next)
        {
            _next = next;
        }

        // This method is called for every incoming HTTP request.
        public async Task InvokeAsync(HttpContext context)
        {
            if (context.Request.Query.ContainsKey("firstname") &&
                context.Request.Query.ContainsKey("lastname"))
            {
                fullname = context.Request.Query["firstname"] + " " +
                           context.Request.Query["lastname"];
            }

            await context.Response.WriteAsync($"Full Name: {fullname}\n");

            // Pass the request to the next middleware
            await _next(context);
        }
    }

    public static class CustommiddlewareExtention
    {
        public static IApplicationBuilder UseCustommiddel(this IApplicationBuilder app)
        {
            return app.UseMiddleware<CustomMiddelware>();
        }
    }
}