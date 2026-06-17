// # Chapter 2 : Integers, Floating Point Numbers, and Decimal Numbers in C#

/*
==========================================================
Chapter 2 : Integers and Floating Point Numbers in C#
==========================================================

Topics Covered:

1. Integer Arithmetic
2. Order of Operations
3. Integer Division
4. Quotient and Remainder
5. Integer Limits (MaxValue / MinValue)
6. Overflow
7. Double Data Type
8. Floating Point Precision
9. Decimal Data Type
10. Area of a Circle Challenge

Key Concepts:

- int     : Whole numbers
- double  : Decimal numbers with large range
- decimal : Decimal numbers with higher precision

==========================================================
*/


// -------------------------------------------------------
// CHAPTER ENTRY POINT
// -------------------------------------------------------

WorkWithIntegers();
OrderPrecedence();
IntegerLimits();
WorkWithDoubles();
WorkWithDecimals();
AreaOfCircleChallenge();


// -------------------------------------------------------
// INTEGER ARITHMETIC
// -------------------------------------------------------

void WorkWithIntegers()
{
    Console.WriteLine("\n===== INTEGER ARITHMETIC =====");

    int a = 18;
    int b = 6;

    int c = a + b;
    Console.WriteLine($"Addition: {c}");

    c = a - b;
    Console.WriteLine($"Subtraction: {c}");

    c = a * b;
    Console.WriteLine($"Multiplication: {c}");

    c = a / b;
    Console.WriteLine($"Division: {c}");
}


/*
Theory:

The int type stores whole numbers.

Operators:

+ Addition
- Subtraction
* Multiplication
/ Division

Examples:

18 + 6 = 24
18 - 6 = 12
18 * 6 = 108
18 / 6 = 3
*/


// -------------------------------------------------------
// ORDER OF OPERATIONS
// -------------------------------------------------------

void OrderPrecedence()
{
    Console.WriteLine("\n===== ORDER OF OPERATIONS =====");

    int a = 5;
    int b = 4;
    int c = 2;

    int d = a + b * c;
    Console.WriteLine($"Without Parentheses: {d}");

    d = (a + b) * c;
    Console.WriteLine($"With Parentheses: {d}");

    d = (a + b) - 6 * c + (12 * 4) / 3 + 12;
    Console.WriteLine($"Complex Expression: {d}");

    int e = 7;
    int f = 4;
    int g = 3;

    int h = (e + f) / g;

    Console.WriteLine($"Integer Division Example: {h}");
}


/*
Theory:

Multiplication and division happen before
addition and subtraction.

Example:

5 + 4 * 2

Step 1:
4 * 2 = 8

Step 2:
5 + 8 = 13

Using parentheses changes execution order:

(5 + 4) * 2

Step 1:
5 + 4 = 9

Step 2:
9 * 2 = 18
*/


// -------------------------------------------------------
// QUOTIENT AND REMAINDER
// -------------------------------------------------------

Console.WriteLine("\n===== QUOTIENT AND REMAINDER =====");

int numberA = 7;
int numberB = 4;
int numberC = 3;

int quotient = (numberA + numberB) / numberC;
int remainder = (numberA + numberB) % numberC;

Console.WriteLine($"Quotient : {quotient}");
Console.WriteLine($"Remainder: {remainder}");


/*
Theory:

% is called the Modulus Operator.

11 / 3

Quotient = 3
Remainder = 2
*/


// -------------------------------------------------------
// INTEGER LIMITS
// -------------------------------------------------------

void IntegerLimits()
{
    Console.WriteLine("\n===== INTEGER LIMITS =====");

    int max = int.MaxValue;
    int min = int.MinValue;

    Console.WriteLine($"Maximum Integer: {max}");
    Console.WriteLine($"Minimum Integer: {min}");

    int overflow = max + 3;

    Console.WriteLine($"Overflow Example: {overflow}");
}


/*
Theory:

Integers have limits.

Maximum:
2,147,483,647

Minimum:
-2,147,483,648

If a calculation exceeds the maximum value,
the number wraps around to the negative range.

This is called Overflow.
*/


// -------------------------------------------------------
// DOUBLE DATA TYPE
// -------------------------------------------------------

void WorkWithDoubles()
{
    Console.WriteLine("\n===== DOUBLE DATA TYPE =====");

    double a = 5;
    double b = 4;
    double c = 2;

    double d = (a + b) / c;

    Console.WriteLine($"(5 + 4) / 2 = {d}");

    double max = double.MaxValue;
    double min = double.MinValue;

    Console.WriteLine($"Double Max: {max}");
    Console.WriteLine($"Double Min: {min}");

    double third = 1.0 / 3.0;

    Console.WriteLine($"1 / 3 = {third}");
}


/*
Theory:

double stores decimal numbers.

Advantages:

- Huge range
- Good performance
- Supports fractions

Example:

5.0 / 2.0

Result:

2.5

Unlike integers,
double does not remove decimal places.
*/


// -------------------------------------------------------
// DECIMAL DATA TYPE
// -------------------------------------------------------

void WorkWithDecimals()
{
    Console.WriteLine("\n===== DECIMAL DATA TYPE =====");

    decimal min = decimal.MinValue;
    decimal max = decimal.MaxValue;

    Console.WriteLine($"Decimal Min: {min}");
    Console.WriteLine($"Decimal Max: {max}");

    double a = 1.0;
    double b = 3.0;

    Console.WriteLine($"Double  1/3 = {a / b}");

    decimal c = 1.0M;
    decimal d = 3.0M;

    Console.WriteLine($"Decimal 1/3 = {c / d}");
}


/*
Theory:

decimal has:

- Smaller range than double
- Much higher precision

Useful for:

- Money
- Banking
- Financial calculations

The M suffix tells C#
to create a decimal value.

Example:

decimal price = 99.99M;
*/


// -------------------------------------------------------
// AREA OF A CIRCLE CHALLENGE
// -------------------------------------------------------

void AreaOfCircleChallenge()
{
    Console.WriteLine("\n===== AREA OF A CIRCLE =====");

    double radius = 2.50;

    double area = Math.PI * radius * radius;

    Console.WriteLine($"Radius: {radius}");
    Console.WriteLine($"Area  : {area}");
}


/*
Formula:

Area = π × r²

π = Math.PI

Radius = 2.5

Expected Result:

Approximately 19.63
*/


// -------------------------------------------------------
// SUMMARY
// -------------------------------------------------------

/*
==========================================================
SUMMARY
==========================================================

1. int
   - Stores whole numbers.

2. Integer Division
   - Removes decimal values.

   Example:
   11 / 3 = 3

3. Modulus (%)
   - Returns remainder.

   Example:
   11 % 3 = 2

4. Order of Operations
   - Multiplication before addition.
   - Parentheses override precedence.

5. Integer Limits
   - int.MaxValue
   - int.MinValue

6. Overflow
   - Values wrap around when limits
     are exceeded.

7. double
   - Supports decimal values.
   - Huge range.
   - Small rounding errors possible.

8. decimal
   - More precise than double.
   - Ideal for financial calculations.

9. Math.PI
   - Built-in value of π.

==========================================================
END OF CHAPTER 2
==========================================================
*/


// -------------------------------------------------------
// PRACTICE CHALLENGES
// -------------------------------------------------------

/*

1. Calculate the area of a rectangle.

2. Calculate the area of a triangle.

3. Calculate the circumference of a circle.

4. Find quotient and remainder of:
   50 / 7

5. Find the average of:
   10, 20, 30, 40

6. Create an overflow example
   using int.MaxValue.

7. Compare precision of:
   double vs decimal
   using 1 / 7.

*/
