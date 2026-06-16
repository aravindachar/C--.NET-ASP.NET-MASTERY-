/*
==========================================================
Chapter 1 : Hello World and Working with Strings
==========================================================

Topics Covered:
1. Printing output to the console
2. Variables and string interpolation
3. String properties (Length)
4. Trimming whitespace
5. Replacing text
6. Changing letter case
7. Searching inside strings

Notes:
- A string is a sequence of characters.
- Strings in C# are immutable.
  This means methods like Replace(), Trim(), ToUpper()
  return a NEW string instead of modifying the original.
==========================================================
*/

// -------------------------------------------------------
// HELLO WORLD
// -------------------------------------------------------

/*
Theory:
Console.WriteLine() prints text to the terminal.

This is usually the first program written when learning
a new programming language.
*/

Console.WriteLine("Hello, World!");


// -------------------------------------------------------
// VARIABLES AND STRING INTERPOLATION
// -------------------------------------------------------

/*
Theory:
Variables allow us to store data and reuse it later.

String interpolation ($"...") is the preferred way
to insert variables inside strings.
*/

string friendName = "Bill";

Console.WriteLine(friendName);
Console.WriteLine($"Hello, this is {friendName}");


// Changing the value stored in the variable
friendName = "Maira";

Console.WriteLine($"Hello, this is {friendName}");


// -------------------------------------------------------
// MULTIPLE VARIABLES
// -------------------------------------------------------

/*
Theory:
We can place multiple variables inside a single string.
*/

string firstFriend = "White";
string secondFriend = "Black";

Console.WriteLine(
    $"My friends are {firstFriend} and {secondFriend}"
);


// -------------------------------------------------------
// STRING LENGTH
// -------------------------------------------------------

/*
Theory:
Length is a property of a string.

It returns the number of characters contained
inside the string.
*/

Console.WriteLine(
    $"{firstFriend} contains {firstFriend.Length} characters."
);

Console.WriteLine(
    $"{secondFriend} contains {secondFriend.Length} characters."
);


// -------------------------------------------------------
// TRIMMING WHITESPACE
// -------------------------------------------------------

/*
Theory:
Strings often contain unwanted spaces.

TrimStart() -> removes spaces from the beginning.
TrimEnd()   -> removes spaces from the end.
Trim()      -> removes spaces from both ends.
*/

string greeting = "     Hello World     ";

Console.WriteLine($"Original  : [{greeting}]");

string trimmedStart = greeting.TrimStart();
Console.WriteLine($"TrimStart : [{trimmedStart}]");

string trimmedEnd = greeting.TrimEnd();
Console.WriteLine($"TrimEnd   : [{trimmedEnd}]");

string trimmedBoth = greeting.Trim();
Console.WriteLine($"Trim      : [{trimmedBoth}]");

/*
Notice:
The original string remains unchanged because
strings are immutable in C#.
*/


// -------------------------------------------------------
// REPLACE TEXT
// -------------------------------------------------------

/*
Theory:
Replace() searches for a specific substring and
replaces it with another value.
*/

string message = "Hello, World!!";

Console.WriteLine(message);

message = message.Replace(
    "Hello",
    "Hello, this is the replaced text"
);

Console.WriteLine(message);


// -------------------------------------------------------
// CHANGING LETTER CASE
// -------------------------------------------------------

/*
Theory:
ToUpper() converts all characters to uppercase.
ToLower() converts all characters to lowercase.
*/

string name = "Aravinda";

Console.WriteLine(name.ToUpper());
Console.WriteLine(name.ToLower());


// -------------------------------------------------------
// SEARCHING INSIDE STRINGS
// -------------------------------------------------------

/*
Theory:
Contains()   -> checks if text exists anywhere.
StartsWith() -> checks if text exists at the beginning.
EndsWith()   -> checks if text exists at the end.

All methods return a boolean value:
True  -> match found
False -> no match
*/

string songLyrics =
    "its been a while since i spoke to you!";

Console.WriteLine(songLyrics.Contains("while"));
Console.WriteLine(songLyrics.Contains("spoke"));
Console.WriteLine(songLyrics.Contains("whilee"));

Console.WriteLine(songLyrics.StartsWith("its"));
Console.WriteLine(songLyrics.EndsWith("you!"));


// -------------------------------------------------------
// SUMMARY
// -------------------------------------------------------

/*
==========================================================
SUMMARY
==========================================================

1. Console.WriteLine()
   - Prints text to the console.

2. Variables
   - Store data that can be reused.
   - Example:
       string friendName = "Bill";

3. String Interpolation
   - Inserts variables into strings.
   - Example:
       $"Hello {friendName}"

4. Length Property
   - Returns the number of characters in a string.

5. Trim Methods
   - TrimStart() -> Remove leading spaces.
   - TrimEnd()   -> Remove trailing spaces.
   - Trim()      -> Remove both.

6. Replace()
   - Replaces part of a string with new text.

7. ToUpper() / ToLower()
   - Convert text to uppercase or lowercase.

8. Contains()
   - Searches for text inside a string.

9. StartsWith() / EndsWith()
   - Checks beginning or ending text.

10. Important Concept:
    Strings are IMMUTABLE.
    Methods like Replace(), Trim(), and ToUpper()
    create and return a NEW string rather than
    modifying the existing one.

==========================================================
End of Chapter 1
==========================================================
*/