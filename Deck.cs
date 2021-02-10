using System;
using System.Collections.Generic;
using static System.Console;
namespace CardsWk2
{
    public class Deck
    {

        public static List<Card> allCards = new List<Card>();
        public static List<Card> discardCards = new List<Card>();

        public Deck()
        {
        }

        public static void CreateDeck()
        {
            allCards.Add(new Card(1, "Ace", "Spades"));
            allCards.Add(new Card(2, "Two", "Spades"));
            allCards.Add(new Card(3, "Three", "Spades"));
            allCards.Add(new Card(4, "Four", "Spades"));
            allCards.Add(new Card(5, "Five", "Spades"));
            allCards.Add(new Card(6, "Six", "Spades"));
            allCards.Add(new Card(7, "Seven", "Spades"));
            allCards.Add(new Card(8, "Eight", "Spades"));
            allCards.Add(new Card(9, "Nine", "Spades"));
            allCards.Add(new Card(10, "Ten", "Spades"));
            allCards.Add(new Card(11, "Jack", "Spades"));
            allCards.Add(new Card(12, "Queen", "Spades"));
            allCards.Add(new Card(13, "King", "Spades"));

            allCards.Add(new Card(1, "Ace", "Clubs"));
            allCards.Add(new Card(2, "Two", "Clubs"));
            allCards.Add(new Card(3, "Three", "Clubs"));
            allCards.Add(new Card(4, "Four", "Clubs"));
            allCards.Add(new Card(5, "Five", "Clubs"));
            allCards.Add(new Card(6, "Six", "Clubs"));
            allCards.Add(new Card(7, "Seven", "Clubs"));
            allCards.Add(new Card(8, "Eight", "Clubs"));
            allCards.Add(new Card(9, "Nine", "Clubs"));
            allCards.Add(new Card(10, "Ten", "Clubs"));
            allCards.Add(new Card(11, "Jack", "Clubs"));
            allCards.Add(new Card(12, "Queen", "Clubs"));
            allCards.Add(new Card(13, "King", "Clubs"));

            allCards.Add(new Card(1, "Ace", "Diamonds"));
            allCards.Add(new Card(2, "Two", "Diamonds"));
            allCards.Add(new Card(3, "Three", "Diamonds"));
            allCards.Add(new Card(4, "Four", "Diamonds"));
            allCards.Add(new Card(5, "Five", "Diamonds"));
            allCards.Add(new Card(6, "Six", "Diamonds"));
            allCards.Add(new Card(7, "Seven", "Diamonds"));
            allCards.Add(new Card(8, "Eight", "Diamonds"));
            allCards.Add(new Card(9, "Nine", "Diamonds"));
            allCards.Add(new Card(10, "Ten", "Diamonds"));
            allCards.Add(new Card(11, "Jack", "Diamonds"));
            allCards.Add(new Card(12, "Queen", "Diamonds"));
            allCards.Add(new Card(13, "King", "Diamonds"));

            allCards.Add(new Card(1, "Ace", "Hearts"));
            allCards.Add(new Card(2, "Two", "Hearts"));
            allCards.Add(new Card(3, "Three", "Hearts"));
            allCards.Add(new Card(4, "Four", "Hearts"));
            allCards.Add(new Card(5, "Five", "Hearts"));
            allCards.Add(new Card(6, "Six", "Hearts"));
            allCards.Add(new Card(7, "Seven", "Hearts"));
            allCards.Add(new Card(8, "Eight", "Hearts"));
            allCards.Add(new Card(9, "Nine", "Hearts"));
            allCards.Add(new Card(10, "Ten", "Hearts"));
            allCards.Add(new Card(11, "Jack", "Hearts"));
            allCards.Add(new Card(12, "Queen", "Hearts"));
            allCards.Add(new Card(13, "King", "Hearts"));
        }

        public static void ShuffleDeck()
        {
            // uses Knuth Shuffle (rosettacode.org/wiki/Knuth_shuffle)

            var random = new Random();
            for (int i = 0; i < allCards.Count; i++)
            {
                int r = random.Next(i, allCards.Count);
                var temp = allCards[i];
                allCards[i] = allCards[r];
                allCards[r] = temp;
            }
        }
    }
}
