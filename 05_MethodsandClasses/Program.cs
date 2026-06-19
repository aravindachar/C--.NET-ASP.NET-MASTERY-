```csharp
/*
============================================================
Chapter 5 : Methods in C#
============================================================

Definition:
A method is a reusable block of code that performs
a specific task. It can accept input (parameters),
process data, and optionally return a value.

Java Definition:
A method is a block of code inside a class that
performs a particular task.

C# Definition:
Exactly the same. Every C# program is built using methods.

Syntax:

access_modifier return_type MethodName(parameters)
{
    // code
}

Example:

public static int Add(int a, int b)
{
    return a + b;
}

============================================================
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("========== METHODS IN C# ==========\n");

        // Method without parameters
        SayHello();

        // Method with one parameter
        Greet("Aravinda");

        // Method with multiple parameters
        Add(10, 20);

        // Method returning value
        int square = Square(5);
        Console.WriteLine($"Square = {square}");

        // Method returning string
        Console.WriteLine(GetCountry());

        // Method with default parameter
        Welcome();
        Welcome("John");

        // Named Arguments
        Student(age: 22, name: "Aravinda");

        // Optional Parameters
        Employee("Google");
        Employee("Microsoft", 30);

        // Method Overloading
        Print();
        Print("Hello");
        Print("Hello", 5);

        // Pass by Value
        int number = 10;
        PassByValue(number);
        Console.WriteLine($"Original Number = {number}");

        // Pass by Reference
        PassByReference(ref number);
        Console.WriteLine($"After Ref = {number}");

        // Out Parameter
        Divide(10, 2, out int result);
        Console.WriteLine($"Division Result = {result}");

        // Expression Bodied Method
        Console.WriteLine($"Cube = {Cube(3)}");

        // Local Method
        LocalMethodDemo();

        // Recursive Method
        Console.WriteLine($"Factorial of 5 = {Factorial(5)}");
    }

    // =====================================================
    // METHOD WITHOUT PARAMETERS
    // =====================================================

    /*
    Definition:
    A method that takes no input.

    Java:
    void hello(){}

    C#:
    void Hello(){}
    */

    static void SayHello()
    {
        Console.WriteLine("Hello World!");
    }

    // =====================================================
    // METHOD WITH PARAMETERS
    // =====================================================

    /*
    Definition:
    A parameter is a variable declared in the method definition.

    Argument:
    The actual value passed to the method.

    Parameter -> name

    Argument -> "Aravinda"
    */

    static void Greet(string name)
    {
        Console.WriteLine($"Hello {name}");
    }

    // =====================================================
    // MULTIPLE PARAMETERS
    // =====================================================

    static void Add(int a, int b)
    {
        Console.WriteLine($"{a} + {b} = {a + b}");
    }

    // =====================================================
    // METHOD RETURNING VALUE
    // =====================================================

    /*
    Definition:
    A return statement sends a value back
    to the caller.
    */

    static int Square(int number)
    {
        return number * number;
    }

    // =====================================================
    // RETURN STRING
    // =====================================================

    static string GetCountry()
    {
        return "India";
    }

    // =====================================================
    // DEFAULT PARAMETERS
    // =====================================================

    /*
    If no value is supplied,
    the default value is used.
    */

    static void Welcome(string name = "Sir")
    {
        Console.WriteLine($"Welcome {name}");
    }

    // =====================================================
    // NAMED ARGUMENTS
    // =====================================================

    static void Student(string name, int age)
    {
        Console.WriteLine($"{name} is {age} years old.");
    }

    // =====================================================
    // OPTIONAL PARAMETERS
    // =====================================================

    static void Employee(string company, int experience = 0)
    {
        Console.WriteLine($"{company} Experience : {experience}");
    }

    // =====================================================
    // METHOD OVERLOADING
    // =====================================================

    /*
    Definition:
    Multiple methods with the same name
    but different parameter lists.
    */

    static void Print()
    {
        Console.WriteLine("No Parameter");
    }

    static void Print(string text)
    {
        Console.WriteLine(text);
    }

    static void Print(string text, int times)
    {
        for (int i = 0; i < times; i++)
        {
            Console.WriteLine(text);
        }
    }

    // =====================================================
    // PASS BY VALUE
    // =====================================================

    /*
    Copy of the variable is passed.
    Original remains unchanged.
    */

    static void PassByValue(int x)
    {
        x = 100;
    }

    // =====================================================
    // PASS BY REFERENCE
    // =====================================================

    /*
    Original variable is modified.
    */

    static void PassByReference(ref int x)
    {
        x = 100;
    }

    // =====================================================
    // OUT PARAMETER
    // =====================================================

    /*
    Used to return multiple values.
    */

    static void Divide(int a, int b, out int result)
    {
        result = a / b;
    }

    // =====================================================
    // EXPRESSION BODIED METHOD
    // =====================================================

    static int Cube(int x) => x * x * x;

    // =====================================================
    // LOCAL METHOD
    // =====================================================

    static void LocalMethodDemo()
    {
        void PrintMessage()
        {
            Console.WriteLine("Inside Local Method");
        }

        PrintMessage();
    }

    // =====================================================
    // RECURSION
    // =====================================================

    /*
    Definition:
    A method calling itself.

    Used in:
    Trees
    DFS
    Backtracking
    Divide & Conquer
    */

    static int Factorial(int n)
    {
        if (n == 1)
            return 1;

        return n * Factorial(n - 1);
    }
}

/*
============================================================
INTERVIEW SUMMARY
============================================================

Method
------
Reusable block of code.

Parameter
---------
Variable declared in method definition.

Argument
--------
Actual value passed to a method.

Return Type
-----------
Specifies what value a method returns.

void
----
Method returns nothing.

Method Overloading
------------------
Same method name,
different parameter list.

Default Parameter
-----------------
Used when caller supplies no value.

Named Argument
--------------
Arguments passed using parameter names.

ref
---
Passes original variable.

out
---
Returns extra values.

Expression-bodied Method
------------------------
Short syntax using =>

Recursion
----------
Method calling itself.

============================================================

JAVA vs C#

Java

void hello(){}

C#

void Hello(){}

Almost identical.

Only naming conventions differ.

============================================================
END OF CHAPTER 5
============================================================
```
cd 