using System;
using System.Collections.Generic;
using static System.Console;
namespace CardsWk3
{
    public class War : Game
    {

        public static List<Card> PlayerPile = new List<Card>();
        public static List<Card> COMPile = new List<Card>();
        public static int TurnCount = 0;

        public War()
        {
        }

        public static void StartWar()
        {
            Title = "War";
            Deck.CreateDeck();
            Deck.ShuffleDeck();
            for (int i = 0; i < Deck.allCards.Count; i += 2)
            {
                PlayerPile.Add(Deck.allCards[i]);
                COMPile.Add(Deck.allCards[i + 1]);
            }
            Clear();
            PlayRound();
        }

        public static void PlayRound()
        {
            if (COMPile.Count == 0)
            {
                Clear();
                PlayerWin();
            }

            else if (PlayerPile.Count == 0)
            {
                Clear();
                COMWin();
            }

            else
            {
                Clear();
                DisplayHUD();
                COMDraw();
                Utility.Pause();
                PlayerDraw();
                if (PlayerPile[0].Value == COMPile[0].Value)
                {
                    ForegroundColor = ConsoleColor.DarkYellow;
                    WriteLine("\nIt's a war! Both player flips the next card facedown.\nThe third card decides who takes it all! Ready?");
                    ForegroundColor = ConsoleColor.Black;
                    Utility.Pause();
                    TurnCount++;
                    Clear();
                    if (PlayerPile.Count <= 2)
                    {
                        Clear();
                        COMWin();
                    }
                    else if (COMPile.Count <= 2)
                    {
                        Clear();
                        PlayerWin();
                    }
                    else
                    {
                        WarRound();
                        if (PlayerPile[0 + 2].Value == COMPile[0 + 2].Value)
                        {
                            ForegroundColor = ConsoleColor.DarkYellow;
                            WriteLine("\nAn evenly matched war!!\nAll cards are returned to the bottom of their piles.");
                            ForegroundColor = ConsoleColor.Black;
                            Utility.Pause();
                            PlayerPile.Add(PlayerPile[0]);
                            PlayerPile.Remove(PlayerPile[0]);
                            PlayerPile.Add(PlayerPile[1]);
                            PlayerPile.Remove(PlayerPile[1]);
                            PlayerPile.Add(PlayerPile[2]);
                            PlayerPile.Remove(PlayerPile[2]);
                            COMPile.Add(COMPile[0]);
                            COMPile.Remove(COMPile[0]);
                            COMPile.Add(COMPile[1]);
                            COMPile.Remove(COMPile[1]);
                            COMPile.Add(COMPile[2]);
                            COMPile.Remove(COMPile[2]);
                            TurnCount++;
                            Clear();
                            PlayRound();
                        }
                        else if (PlayerPile[0 + 2].Value > COMPile[0 + 2].Value)
                        {
                            ForegroundColor = ConsoleColor.DarkGreen;
                            WriteLine("\nYou win the war!!\nYou take all the cards in play.");
                            ForegroundColor = ConsoleColor.Black;
                            Utility.Pause();
                            PlayerPile.Add(PlayerPile[0]);
                            PlayerPile.Remove(PlayerPile[0]);
                            PlayerPile.Add(PlayerPile[1]);
                            PlayerPile.Remove(PlayerPile[1]);
                            PlayerPile.Add(PlayerPile[2]);
                            PlayerPile.Remove(PlayerPile[2]);
                            PlayerPile.Add(COMPile[0]);
                            COMPile.Remove(COMPile[0]);
                            PlayerPile.Add(COMPile[1]);
                            COMPile.Remove(COMPile[1]);
                            PlayerPile.Add(COMPile[2]);
                            COMPile.Remove(COMPile[2]);
                            TurnCount++;
                            Clear();
                            PlayRound();
                        }
                        else
                        {
                            ForegroundColor = ConsoleColor.DarkGreen;
                            WriteLine("\nYou win the war!!\nYou take all the cards in play.");
                            ForegroundColor = ConsoleColor.Black;
                            Utility.Pause();
                            COMPile.Add(COMPile[0]);
                            COMPile.Remove(COMPile[0]);
                            COMPile.Add(COMPile[1]);
                            COMPile.Remove(COMPile[1]);
                            COMPile.Add(COMPile[2]);
                            COMPile.Remove(COMPile[2]);
                            COMPile.Add(PlayerPile[0]);
                            PlayerPile.Remove(PlayerPile[0]);
                            COMPile.Add(PlayerPile[1]);
                            PlayerPile.Remove(PlayerPile[1]);
                            COMPile.Add(PlayerPile[2]);
                            PlayerPile.Remove(PlayerPile[2]);
                            TurnCount++;
                            Clear();
                            PlayRound();
                        }
                    }  
                }
                else if (PlayerPile[0].Value > COMPile[0].Value)
                {
                    ForegroundColor = ConsoleColor.DarkGreen;
                    WriteLine("\nPlayer wins! You take both cards.");
                    ForegroundColor = ConsoleColor.Black;
                    Utility.Pause();
                    PlayerPile.Add(PlayerPile[0]);
                    PlayerPile.Remove(PlayerPile[0]);
                    PlayerPile.Add(COMPile[0]);
                    COMPile.Remove(COMPile[0]);
                    TurnCount++;
                    Clear();
                    PlayRound();
                }
                else
                {
                    ForegroundColor = ConsoleColor.DarkRed;
                    WriteLine("\nCOM wins! COM takes both cards.");
                    ForegroundColor = ConsoleColor.Black;
                    Utility.Pause();
                    COMPile.Add(COMPile[0]);
                    COMPile.Remove(COMPile[0]);
                    COMPile.Add(PlayerPile[0]);
                    PlayerPile.Remove(PlayerPile[0]);
                    TurnCount++;
                    Clear();
                    PlayRound();
                }
            }
        }

        public static void WarRound()
        {
            DisplayHUD();
            WriteLine($"The COM draws the {COMPile[0 + 2].Name} of {COMPile[0 + 2].Suit}.");
            Utility.Pause();
            WriteLine($"\nYou draw the {PlayerPile[0 + 2].Name} of {PlayerPile[0 + 2].Suit}.");
        }

        public static void PlayerDraw()
        {
            WriteLine($"\nYou draw the {PlayerPile[0].Name} of {PlayerPile[0].Suit}.");
        }

        public static void COMDraw()
        {
            WriteLine($"The COM draws the {COMPile[0].Name} of {COMPile[0].Suit}.");
        }

        public static void DisplayHUD()
        {
            WriteLine($"===== Player Cards Left:{PlayerPile.Count}\tCOM Cards Left:{COMPile.Count} =====\n======================================================\n\n");
        }

        public static void PlayerWin()
        {
            ForegroundColor = ConsoleColor.DarkGreen;
            WriteLine("You Win!");
            ForegroundColor = ConsoleColor.Black;
            WriteLine($"\nAwesome job!!\n\nThis game lasted {TurnCount} turns.\n\nPress any key to return to the main menu..");
            ReadKey(true);
            TurnCount = 0;
            Deck.allCards.Clear();
            PlayerPile.Clear();
            COMPile.Clear();
            Game.StartGame();
        }

        public static void COMWin()
        {
            ForegroundColor = ConsoleColor.DarkRed;
            WriteLine("The COM Wins!");
            ForegroundColor = ConsoleColor.Black;
            WriteLine($"\nBetter luck next time!\n\nThis game lasted {TurnCount} turns.\n\nPress any key to return to the main menu..");
            ReadKey(true);
            TurnCount = 0;
            Deck.allCards.Clear();
            PlayerPile.Clear();
            COMPile.Clear();
            Game.StartGame();
        }

        public static void WarInstructions()
        {
            string playerChoice;
            WriteLine("War is an easy card game.\nFirst, the deck will be split into two piles of 26 cards.\nYou get one pile, and the COM gets the other.\nEach turn you will both draw the top card of your pile and face-off.\nThe side with the highest value takes both cards and puts them\nat the bottom of their pile. If both cards are the\nsame value then initiate a war! Each player flips\ntheir next card face-down, then the third card determines\nWho takes it all! Evenly matched wars result in a draw, and\ngoing to war with 2 or less cards is an auto-lose.\nThe game ends when one player doesn't have any cards left!\n\nReady to begin?\n\n1) Start War\n2) Return to Main Menu");
            playerChoice = ReadLine().Trim();
            if (playerChoice == "1")
            {
                Clear();
                StartWar();
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
                WarInstructions();
            }

        }
    }
}
