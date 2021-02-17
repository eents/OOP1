using System;
using System.Collections.Generic;
using static System.Console;
namespace CardsWk3
{
    public class Utility
    {
        public Utility()
        {
        }

        public static void Pause()
        {
            WriteLine("\n\nPress any key to continue..");
            ReadKey(true);
        }

        public static void ExitProgramPrompt()
        {
            WriteLine("Thanks for playing!\nSee you next time-\n\nPress any key to exit..");
            ReadKey(true);
            Clear();
            Environment.Exit(1);
        }

        public static void InvalidOption()
        {
            ForegroundColor = ConsoleColor.DarkRed;
            WriteLine("That wasn't a valid option- Try again!\n\n");
            ForegroundColor = ConsoleColor.Black;
        }
    }
}
