using MiddleWareExample.CustomMiddleware; //its full custion 
using MiddleWareExample.MyCustomMiddelware; //its use Iappication class and inherites 

var builder = WebApplication.CreateBuilder(args);

// Register IMiddleware middleware only
builder.Services.AddTransient<MyCustomeMidelwawre>();

var app = builder.Build();

// ===============================
// Middleware 1
// ===============================
app.Use(async (context, next) =>
{
    await context.Response.WriteAsync("From Middleware 1\n");

    await next();

    await context.Response.WriteAsync("Back to Middleware 1\n");
});

// ===============================
// Custom Middleware (Constructor Injection)
// ===============================
app.UseCustommiddel();

// ===============================
// IMiddleware
// Uncomment if you want to test it
// ===============================

// app.UseMyCustomeMiddleware();

// ===============================
// Terminal Middleware
// ===============================
app.Run(async context =>
{
    await context.Response.WriteAsync("From Middleware 3\n");
});

app.Run();