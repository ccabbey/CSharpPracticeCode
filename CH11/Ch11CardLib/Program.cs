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

            WriteLine("deep copy test finished.");
            ReadKey();

            //operator overloading test
            Card.isAceHigh = true;
            WriteLine("Aces are high.");
            Card.useTrumps = true;
            Card.trump = Suit.Club;
            WriteLine("Clubs are trumps.");
            Card card1, card2, card3, card4, card5;
            card1 = new Card(Suit.Club, Rank.Five);
            card2 = new Card(Suit.Club, Rank.Five);
            card3 = new Card(Suit.Club, Rank.Ace);
            card4 = new Card(Suit.Heart, Rank.Ten);
            card5 = new Card(Suit.Diamond, Rank.Ace);

            WriteLine($"{card1.ToString()} == {card2.ToString()} ? {card1 == card2}");
            WriteLine($"{card1.ToString()} != {card3.ToString()} ? {card1 != card3}");
            WriteLine($"{card1.ToString()}.Equals({card4.ToString()}) ? " +
                 $" {card1.Equals(card4)}");
            WriteLine($"Card.Equals({card3.ToString()}, {card4.ToString()}) ? " +
                 $" {Card.Equals(card3, card4)}");
            WriteLine($"{card1.ToString()} > {card2.ToString()} ? {card1 > card2}");
            WriteLine($"{card1.ToString()} <= {card3.ToString()} ? {card1 <= card3}");
            WriteLine($"{card1.ToString()} > {card4.ToString()} ? {card1 > card4}");
            WriteLine($"{card4.ToString()} > {card1.ToString()} ? {card4 > card1}");
            WriteLine($"{card5.ToString()} > {card4.ToString()} ? {card5 > card4}");
            WriteLine($"{card4.ToString()} > {card5.ToString()} ? {card4 > card5}");

            WriteLine("operator overloading test finished.");
            ReadKey();



        }
    }
}

