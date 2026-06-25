using Microsoft.AspNetCore.Builder;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

/*
===========================================================
CHAPTER : ASP.NET CORE ROUTING
===========================================================

Definition:
Routing is the process of matching an incoming HTTP request
(URL + HTTP Method) to the correct endpoint.

Java Comparison:
Spring Boot
------------
@GetMapping("/home")
public String Home()
{
    return "Hello";
}

ASP.NET Core
------------
app.MapGet("/home", () => "Hello");

Interview Question:
Q) What is Routing?
A) Routing matches an incoming request URL with an endpoint
and executes the corresponding handler.
===========================================================
*/


// =========================================================
// 1. MAPGET()
// =========================================================

/*
MapGet()

Creates an endpoint that responds ONLY to HTTP GET requests.

Interview:
Q) Difference between Map() and MapGet()?

Map()
- Matches a URL path.
- Creates a branch pipeline.

MapGet()
- Matches URL + HTTP GET method.
- Used to create API endpoints.
*/

app.MapGet("/", () =>
{
    return "Welcome to ASP.NET Core Routing!";
});



// =========================================================
// 2. MAP()
// =========================================================

/*
Map()

Creates a branch in the middleware pipeline.

Java Analogy:

switch(path)
{
    case "/map1":
        ...
}

ASP.NET creates a separate middleware pipeline for each branch.
*/

// URL:
// /map1
app.Map("map1", async context =>
{
    await context.Response.WriteAsync("Welcome to Map 1");
});

// URL:
// /map2
app.Map("map2", async context =>
{
    await context.Response.WriteAsync("Welcome to Map 2");
});

// URL:
// /map3
app.Map("map3", async context =>
{
    await context.Response.WriteAsync("Welcome to Map 3");
});



// =========================================================
// 3. REQUIRED ROUTE PARAMETERS
// =========================================================

/*
Syntax

{parameter}

Meaning

The parameter MUST exist.

Example URL

/file/report.pdf

filename = report
extension = pdf

Interview

Q) Where are route parameters stored?

A)

context.Request.RouteValues

RouteValues is a dictionary that stores values extracted
from the URL.
*/

app.Map("file/{filename}.{extension}", async context =>
{
    string? fileName =
        Convert.ToString(context.Request.RouteValues["filename"]);

    string? extension =
        Convert.ToString(context.Request.RouteValues["extension"]);

    await context.Response.WriteAsync(
$"""
File Details

File Name : {fileName}
Extension : {extension}
""");
});




// =========================================================
// 4. REQUIRED STRING PARAMETER
// =========================================================

/*
Example URL

/employee/profile/Aravinda

employeeName = Aravinda
*/

app.Map("employee/profile/{employeeName}", async context =>
{
    string? employeeName =
        Convert.ToString(context.Request.RouteValues["employeeName"]);

    await context.Response.WriteAsync(
$"""
Employee Profile

Employee Name : {employeeName}
""");
});



// =========================================================
// 5. OPTIONAL ROUTE PARAMETER
// =========================================================

/*
Syntax

{id?}

Meaning

The route works BOTH with and without id.

Valid URLs

/employee/profile

/employee/profile/21

Interview

Q) Difference between

{id}

and

{id?}

{id}
Required

{id?}
Optional
*/

app.Map("employeee/profile/{id?}", async context =>      
{
    if (context.Request.RouteValues.ContainsKey("id"))
    {
        int id = Convert.ToInt32(
            context.Request.RouteValues["id"]);

        await context.Response.WriteAsync(
$"""
Employee Profile

Employee ID : {id}
""");
    }
    else
    {
        await context.Response.WriteAsync(
            "Employee ID was not provided.");
    }
});



// =========================================================
// 6. DEFAULT VALUE
// =========================================================

/*
Syntax

{name=Guest}

If the value isn't supplied,
ASP.NET automatically uses Guest.

Example

/employee/details

Output
Guest

/employee/details/Aravinda

Output
Aravinda
*/

app.Map("employee/details/{name=Guest}", async context =>
{
    string? name =
        Convert.ToString(context.Request.RouteValues["name"]);

    await context.Response.WriteAsync(
        $"Employee Name : {name}");
});



// =========================================================
// 7. ROUTE CONSTRAINTS
// =========================================================

/*
Route Constraints validate route parameters BEFORE the
endpoint executes.

Benefits

✔ Cleaner code
✔ Better security
✔ Prevent invalid URLs

Common Constraints

:int
:alpha
:bool
:guid
:datetime
:length
:min
:max
:range

Interview

Q) What is Route Constraint?

A)

It restricts what values a route parameter can accept.
*/


// Only integers

app.Map("product/{id:int}", async context =>
{
    int id = Convert.ToInt32(context.Request.RouteValues["id"]);

    await context.Response.WriteAsync($"Product ID : {id}");
});


// Alphabetic only

app.Map("customer/{name:alpha}", async context =>
{
    string? name =
        Convert.ToString(context.Request.RouteValues["name"]);

    await context.Response.WriteAsync($"Customer : {name}");
});


// Integer between 1 and 100

app.Map("order/{id:int:range(1,100)}", async context =>
{
    int id = Convert.ToInt32(context.Request.RouteValues["id"]);

    await context.Response.WriteAsync($"Order ID : {id}");
});



// =========================================================
// 8. MAP FALLBACK
// =========================================================

/*
Executed ONLY if no endpoint matches.

Similar to

default:

inside Java switch statement.
*/

app.MapFallback(async context =>
{
    await context.Response.WriteAsync(
$"""
404 - Endpoint Not Found

Requested URL

{context.Request.Path}
""");
});

app.Run();


/*
===========================================================

INTERVIEW SUMMARY

Routing
-------
Matches URL to an endpoint.

Endpoint
--------
Code executed after routing.

Map()
-----
Creates middleware branch.

MapGet()
---------
Handles GET requests.

Route Parameter
---------------
Dynamic value extracted from URL.

RouteValues
-----------
Dictionary containing all route parameters.

{id}
-----
Required parameter.

{id?}
------
Optional parameter.

{name=Guest}
-------------
Default value.

Route Constraint
----------------
Restricts acceptable parameter values.

MapFallback()
-------------
Executed when no route matches.

===========================================================

JAVA vs ASP.NET Core

Spring Boot

@GetMapping("/users/{id}")

ASP.NET Core

app.MapGet("/users/{id}", ...)

Concept is identical.

===========================================================
*/