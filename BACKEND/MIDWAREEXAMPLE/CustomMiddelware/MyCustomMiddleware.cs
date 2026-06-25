using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace MiddleWareExample.MyCustomMiddelware
{
    public class MyCustomeMidelwawre : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            await context.Response.WriteAsync("The custom middleware starts\n");

            await next(context);

            await context.Response.WriteAsync("The custom middleware ends\n");
        }
    }

    public static class CustomMiddelwareExtention
    {
        public static IApplicationBuilder UseMyCustomeMiddleware(this IApplicationBuilder app)
        {
            return app.UseMiddleware<MyCustomeMidelwawre>();
        }
    }
}