using System;
using System.Collections.Generic;
using static System.Console;
namespace CardsWk2
{
    public class HighLow : Game
    {
        public HighLow()
        {
        }

        public static string highLowPrompt = "\n\nWill the next card be higher (H), or lower (L)?";
        public static int currentCard = 0;
        public static int playerScore = 0;
        public static int startingCards = 51;

        public static void StartHighLow()
        {
            Title = "High/Low";
            Deck.CreateDeck();
            Deck.ShuffleDeck();
            Clear();
            PlayRound();
        }

        public static void PlayRound()
        {
            DisplayHUD();
            DrawNextCard();
            WriteLine(highLowPrompt);
            string playerInput = ReadLine().ToLower().Trim();
            if (playerInput == "h")
            {
                if (Deck.allCards[currentCard].Value <= Deck.allCards[currentCard + 1].Value)
                {
                    Clear();
                    CorrectGuess();
                    playerScore++;
                    startingCards--;
                    currentCard++;
                    CheckIsPlaying();
                }
                else
                {
                    Clear();
                    IncorrectGuess();
                    startingCards--;
                    currentCard++;
                    CheckIsPlaying();
                }
            }
            else if (playerInput == "l")
            {
                if (Deck.allCards[currentCard].Value >= Deck.allCards[currentCard + 1].Value)
                {
                    Clear();
                    CorrectGuess();
                    playerScore++;
                    startingCards--;
                    currentCard++;
                    CheckIsPlaying();
                }
                else
                {
                    Clear();
                    IncorrectGuess();
                    startingCards--;
                    currentCard++;
                    CheckIsPlaying();
                }
            }
            else
            {
                Clear();
                Utility.InvalidOption();
                PlayRound();
            }
        }

        public static void DrawNextCard()
        {
            WriteLine($"You drew the {Deck.allCards[currentCard].Name} of {Deck.allCards[currentCard].Suit}");
        }

        public static void HighLowInstructions()
        {
            string playerChoice;
            WriteLine("High/Low is an easy card game\nFirst, you will be shown a card from the deck.\nYou need to guess whether the next card drawn will have a higher (H),\nor lower (L) value than that card. An equal value will\nStill earn you a point.\n\nReady to begin?\n\n1) Start High/Low\n2) Return to Main Menu");
            playerChoice = ReadLine().Trim();
            if (playerChoice == "1")
            {
                Clear();
                StartHighLow();
            }
            else if (playerChoice == "2")
            {
                Clear();
                Game.Intro();
            }
            else
            {
                Clear();
                Utility.InvalidOption();
                HighLowInstructions();
            }
        }

        public static void DisplayHUD()
        {
            WriteLine($"===== Cards Left:{startingCards}\tScore:{playerScore} =====\n====================================");
        }

        public static void CorrectGuess()
        {
            ForegroundColor = ConsoleColor.DarkGreen;
            WriteLine("Awesome!\n");
            ForegroundColor = ConsoleColor.Black;
        }

        public static void IncorrectGuess()
        {
            ForegroundColor = ConsoleColor.DarkRed;
            WriteLine("Not Quite!\n");
            ForegroundColor = ConsoleColor.Black;
        }

        public static void CheckIsPlaying()
        {
            if (startingCards >= 1)
            {
                PlayRound();
            }
            else
            {
                Clear();
                DrawNextCard();
                HighLowFinal();
            }
        }

        public static void HighLowFinal()
        {
            WriteLine($"\nThat's it for this game!\n\nYour final score was {playerScore}.\n\nPress any key to return to the main menu..");
            ReadKey(true);
            currentCard = 0;
            playerScore = 0;
            startingCards = 51;
            Game.StartGame();
        }
    }
}
