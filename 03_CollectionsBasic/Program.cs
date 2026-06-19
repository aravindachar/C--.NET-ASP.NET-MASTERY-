using System;

namespace CollectionsBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==================================================");
            Console.WriteLine("🚀 LESSON 1: FIXED-SIZE ARRAYS");
            Console.WriteLine("==================================================");

            // Allocation: Exactly 3 slots in memory for string objects
            string[] names = new string[3];
            Console.WriteLine("Please enter the names of your 3 friends:");

            // Populating the Array (Using index 'i' to assign data to specific slots)
            for (int i = 0; i < names.Length; i++)
            {
                Console.Write($"Friend {i + 1}: ");
                names[i] = Console.ReadLine() ?? "Unknown"; 
            }

            Console.WriteLine("\n--- Displaying Array (Using For Loop with Indexes) ---");
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine($"Jersey number {i} -> Name: {names[i]}");
            }

            Console.WriteLine("\n--- Displaying Array (Using Foreach Loop) ---");
            foreach (string name in names)
            {
                Console.WriteLine($"Team Member: {name}");
            }

            // Pause point before executing the next lesson
            Console.WriteLine("\nPress any key to move to the next lesson...");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("==================================================");
            Console.WriteLine("🚀 LESSON 2: DYNAMIC LISTS (List<T>)");
            Console.WriteLine("==================================================");
            
            // Calling the standalone class method we created in ListsDemo.cs
            ListsDemo.RunExplanation();

            Console.WriteLine("\n--- Collections Practice Complete! ---");
            Console.ReadKey();
        }
    }
}