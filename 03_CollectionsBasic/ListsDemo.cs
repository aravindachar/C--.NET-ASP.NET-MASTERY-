using System;
using System.Collections.Generic; // REQUIRED namespace to use Lists!

namespace CollectionsBasic
{
    public static class ListsDemo
    {
        public static void RunExplanation()
        {
            // ====================================================================
            // DEFINITION: WHAT IS A LIST?
            // ====================================================================
            // A List<T> is a generic, dynamic collection. 
            // Unlike arrays, a List automatically resizes its storage capacity 
            // behind the scenes whenever items are added or removed.
            //
            // KEY DIFFERENCES FROM ARRAYS:
            // 1. Dynamic Size: You don't specify an initial limit (e.g., [3]). It grows on demand.
            // 2. Built-in Methods: Rich features to instantly .Add(), .Remove(), and .Sort().
            // 3. Syntax: Uses angle brackets '<T>' to enforce what data type it stores.
            // ====================================================================

            // 1. DECLARATION & INITIALIZATION
            // This initializes an empty list explicitly dedicated to storing string objects.
            List<string> videoGames = new List<string>();

            // 2. ADDING DATA DYNAMICALLY (.Add)
            // Notice we do not have to map these to explicit index bounds!
            videoGames.Add("Elden Ring");
            videoGames.Add("Cyberpunk 2077");
            videoGames.Add("Minecraft");
            videoGames.Add("The Witcher 3");

            Console.WriteLine($"Initial game count: {videoGames.Count}"); // .Count tracks active items

            // 3. REMOVING DATA DYNAMICALLY (.Remove)
            // You can drop items explicitly by value names or index targets
            videoGames.Remove("Minecraft"); // Searches and purges "Minecraft" completely

            Console.WriteLine("\n--- Current Video Game Library ---");

            // 4. ITERATING OVER A LIST
            // Just like arrays, you can loop through a list effortlessly using 'foreach'
            foreach (string game in videoGames)
            {
                Console.WriteLine($"🎮 {game}");
            }

            // 5. HELPFUL LIST UTILITIES
            // Checking if an item exists inside your collection instantly
            bool hasEldenRing = videoGames.Contains("Elden Ring");
            Console.WriteLine($"\nDo I own Elden Ring? {hasEldenRing}");

            // Clearing out all contents completely
            videoGames.Clear();
            Console.WriteLine($"Count after running .Clear(): {videoGames.Count} items.");
        }
    }
}