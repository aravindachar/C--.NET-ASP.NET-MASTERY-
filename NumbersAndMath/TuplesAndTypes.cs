// Chapter 3 : Tuples and Types

// -----------------------------
// Tuple Example
// -----------------------------

var pt = (X: 12, Y: 2);

double slope = (double)pt.Y / pt.X;

Console.WriteLine($"The point {pt} has slope {slope}");


// -----------------------------
// Tuple Example - Person
// -----------------------------

var subscriber = (Name: "Aravinda", Age: 21);

Console.WriteLine(subscriber);

// Create a modified copy
var subscriber2 = (
    Name: subscriber.Name,
    Age: 32
);

Console.WriteLine(subscriber2);


// -----------------------------
// Record Example
// -----------------------------

Person aravind = new Person("Aravinda", 22);

Console.WriteLine(aravind);


// -----------------------------
// Record Declaration
// -----------------------------

public record Person(string Name, int Age);