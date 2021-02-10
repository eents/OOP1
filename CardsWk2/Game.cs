using System;
using System.Collections.Generic;
using static System.Console;
namespace CardsWk2
{
    public class Game
    {
        public Game()
        {
        }

        public static void StartGame()
        {
            Title = "Cards Program";
            BackgroundColor = ConsoleColor.White;
            ForegroundColor = ConsoleColor.Black;
            Clear();
            Intro();
        }

        public static void Intro()
        {
            string playerInput;
            WriteLine("Welcome to the Card Game program!\nChoose from any of the games below to begin-\n\n1) High/Low\n2) Exit Program\n");
            playerInput = ReadLine().Trim();
            if (playerInput == "1")
            {
                Clear();
                HighLow.HighLowInstructions();
            }
            else if (playerInput == "2")
            {
                Clear();
                Utility.ExitProgramPrompt();
            }
            else
            {
                Clear();
                Utility.InvalidOption();
                Intro();
            }
        }
    }
}
