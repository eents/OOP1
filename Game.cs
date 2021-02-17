using System;
using System.Collections.Generic;
using static System.Console;
namespace CardsWk3
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

        public static void ShowCredits()
        {
            WriteLine("This program was made by Eric E for a C# class assignment.\nThere isn't any real flair elements here, it is very basic!\n\nThis program uses Knuth Shuffle to shuffle the cards.\n\nSpecial thanks to Charlie P from the tutoring center, you rule!\n\nPress any key to return to the main menu..");
            ReadKey(true);
            Clear();
            Intro();
        }

        public static void Intro()
        {
            string playerInput;
            Title = "Cards Program";
            WriteLine("Welcome to the Card Game program!\nChoose from any of the games below to begin-\n\n1) High/Low\n2) War\n3) Credits\n4) Exit Program");
            playerInput = ReadLine().Trim();
            if (playerInput == "1")
            {
                Clear();
                HighLow.HighLowInstructions();
            }
            else if (playerInput == "2")
            {
                Clear();
                War.WarInstructions();
            }
            else if (playerInput == "3")
            {
                Clear();
                ShowCredits();
            }
            else if (playerInput == "4")
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
