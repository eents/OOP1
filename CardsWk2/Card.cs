using System;
using System.Collections.Generic;
using static System.Console;
namespace CardsWk2
{
    public class Card
    {
        public int Value;
        public string Name;
        public string Suit;

        public Card(int value, string name, string suit)
        {
            Value = value;
            Name = name;
            Suit = suit;
        }
    }
}
