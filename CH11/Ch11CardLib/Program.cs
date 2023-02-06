using System;
using static System.Console;
namespace Ch11CardLib
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck newDeck = new Deck();
            newDeck.Shuffle();
            Cards randomCards = new Cards();
            randomCards.Add(newDeck.GetRandomCards(5));
            foreach (Card card in randomCards)
            {
                Console.WriteLine(card.ToString());
            }

            Console.ReadKey();

            //deep copy test
            Deck deck1 = new Deck();
            Deck deck2 = (Deck)deck1.Clone();
            WriteLine($"The first card in the original deck is: {deck1.GetCard(0)}");
            WriteLine($"The first card in the cloned deck is: {deck2.GetCard(0)} ");
            deck1.Shuffle();
            WriteLine("Original deck shuffled.");
            WriteLine($"The first card in the o original deck 1s: {deck1.GetCard(0)} ");
            WriteLine($"The first card in the cloned deck is: {deck2.GetCard(0)}");
            ReadKey();


        }
    }
}

