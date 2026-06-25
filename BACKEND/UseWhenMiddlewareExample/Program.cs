using System.Diagnostics;
using Microsoft.AspNetCore.Components;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.UseWhen(
    context =>
    {
        return context.Request.Query.ContainsKey("username");
    },
    appBuilder =>
        {
        appBuilder.Use(async(context , next )=>
            {
                await context.Response.WriteAsync("the code is doenn");
                await next();
            });

    });
app.Run(async context =>
{
    await context.Response.WriteAsync(""); 
});

   
app.Run();
