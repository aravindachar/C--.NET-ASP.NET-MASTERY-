using System;

namespace LoopsAndBranches
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==================================================");
            Console.WriteLine("🚀 LESSON 1: CONDITIONAL BRANCHING & SWITCHING");
            Console.WriteLine("==================================================");

            Console.Write("Enter your score (0 to 100): ");
            string input = Console.ReadLine() ?? "0";
            
            if (!int.TryParse(input, out int score))
            {
                Console.WriteLine("❌ Invalid input! Please enter a valid number next time.");
                return;
            }

            // 1. TRADITIONAL IF / ELSE IF / ELSE BRANCHING
            Console.WriteLine("\n--- Checking Status (If/Else) ---");
            if (score >= 90)
            {
                Console.WriteLine("Excellent! You get an A.");
            }
            else if (score >= 50)
            {
                Console.WriteLine("Good job! You passed.");
            }
            else
            {
                Console.WriteLine("Keep practicing. You failed this round.");
            }

            // 2. MODERN C# SWITCH EXPRESSION
            // This is a powerful feature in C# to assign variables cleanly based on a value.
            Console.WriteLine("\n--- Reward Tier (Switch Expression) ---");
            string reward = score switch
            {
                100 => "🥇 Gold Medal + 100XP Bonus!",
                >= 90 => "🥈 Silver Medal!",
                >= 75 => "🥉 Bronze Medal!",
                _ => "🎖️ Participation Ribbon" // The underscore '_' acts as the 'default' fallback case
            };

            Console.WriteLine($"Your Reward: {reward}");

            // Pause point before transitioning to advanced loops
            Console.WriteLine("\nPress any key to move to Advanced Loop mechanics...");
            Console.ReadKey();
            Console.Clear();

            // 3. EXECUTING ADVANCED LOOP WORK
            AdvancedLoops.RunLoops();
        }
    }
}