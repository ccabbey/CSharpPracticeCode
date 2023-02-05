using System;
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
        }
    }
}

