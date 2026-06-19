using System;

namespace LoopsAndBranches
{
    public static class AdvancedLoops
    {
        public static void RunLoops()
        {
            Console.WriteLine("==================================================");
            Console.WriteLine("🚀 LESSON 2: CONDITIONAL LOOPS (WHILE / DO-WHILE)");
            Console.WriteLine("==================================================");

            // ====================================================================
            // DEFINITION: WHILE VS DO-WHILE
            // ====================================================================
            // 'while' checks the condition FIRST. If it's false, the code NEVER runs.
            // 'do-while' runs the code FIRST, then checks the condition. It ALWAYS runs at least once.
            // ====================================================================

            int countdown = 3;

            Console.WriteLine("--- Testing While Loop ---");
            while (countdown > 0)
            {
                Console.WriteLine($"Launching in... {countdown}");
                countdown--; // Crucial step so the loop isn't infinite!
            }

            // 2. THE BREAK AND CONTINUE KEYWORDS
            Console.WriteLine("\n--- Loop Interruption (Break & Continue) ---");
            Console.WriteLine("Printing numbers 1 to 5, skipping 3, stopping at 5:");

            for (int i = 1; i <= 10; i++)
            {
                if (i == 3)
                {
                    // 'continue' skips the rest of the current loop iteration and moves to the next number
                    continue; 
                }

                if (i == 5)
                {
                    Console.WriteLine($"[i = {i}] Target reached! Breaking loop entirely.");
                    break; // 'break' exits the loop completely right now
                }

                Console.WriteLine($"Number: {i}");
            }
        }
    }
}