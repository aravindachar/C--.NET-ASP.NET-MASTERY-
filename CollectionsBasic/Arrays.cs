using System;

namespace CSharpBasics.Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            // ==========================================
            // DEFINITION: WHAT IS AN ARRAY?
            // ==========================================
            // An Array is a data structure used to store a fixed-size, 
            // sequential collection of elements of the SAME data type.
            // 
            // KEY CHARACTERISTICS:
            // 1. Fixed Size: Once created, you cannot change its size (e.g., change 3 slots to 4).
            // 2. Type Safety: If declared as a 'string', it can ONLY hold strings.
            // 3. Zero-Indexed: The first element starts at index 0, not 1.
            // ==========================================

            // 1. DECLARATION & INITIALIZATION
            // We allocate memory for exactly 3 string items. Currently, they are empty (null).
            string[] names = new string[3];

            Console.WriteLine("Please enter the names of your 3 friends:");

            // 2. POPULATING THE ARRAY USING A 'FOR' LOOP
            // We use a traditional 'for' loop because we need the index 'i' to track 
            // exactly which specific locker slot we are putting the input into.
            for (int i = 0; i < names.Length; i++)
            {
                Console.Write($"Friend {i + 1}: "); // Friendly prompt (1-based for humans)
                names[i] = Console.ReadLine();     // Stores the user's input at index 'i'
            }

            Console.WriteLine("\n--- Team Roster (Using For Loop) ---");

            // 3. READING FROM THE ARRAY USING A 'FOR' LOOP
            // Excellent choice here: using 'i' allows you to use the index value 
            // directly as a dynamic "jersey number".
            for (int i = 0; i < names.Length; i++)
            {
                System.Console.WriteLine($"Jersey number {i} -> Name: {names[i]}");
            }

            Console.WriteLine("\n--- Quick Print (Using Foreach Loop) ---");

            // 4. READING FROM THE ARRAY USING A 'FOREACH' LOOP
            // DEFINITION: The 'foreach' loop automatically steps through a collection 
            // from start to finish. It reads the data but DOES NOT give you the index number.
            // It is cleaner, safer, and faster to read when the index doesn't matter.
            foreach (string name in names)
            {
                System.Console.WriteLine($"Team Member: {name}");
            }
            
            // Keeps the console window open until a key is pressed
            Console.ReadKey();
        }
    }
}