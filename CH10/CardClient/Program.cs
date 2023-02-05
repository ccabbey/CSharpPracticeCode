using Ch11CardLib;

namespace CardClient;

class Program
{
    static void Main(string[] args)
    {
        Deck myDeck = new();
        myDeck.Shuffle();
        // PrintCardsStubs(myDeck);
        DrawFlushStub(myDeck);
    }


    public static void DrawFlushStub(Deck deck)
    {
        while (true)
        {
            Deck playDeck = new();
            playDeck.Shuffle();

            bool isFlush = false;
            bool flushHasFound = false;

            for (int hand = 0; hand < 10; hand++)
            {
                var cards = playDeck.GetRandomCards(5);

                isFlush = true;

                for (int i = 1; i < 5; i++)
                {


                    if (cards[i].Suit != cards[0].Suit)
                    {
                        isFlush = false;
                        break;
                    }
                }

                if (isFlush)
                {
                    flushHasFound = true;

                    foreach (var card in cards)
                    {
                        Console.WriteLine(card.ToString());
                    }
                    Console.WriteLine("flush!");
                }
            }

            if (!flushHasFound)
                Console.WriteLine("no flush!");

            Console.ReadLine();
        }


    }

    public static void PrintCardsStubs(Deck myDeck)
    {
        for (int i = 0; i < 52; i++)
        {
            Card tempCard = myDeck.GetCard(i);
            Console.Write(tempCard.ToString());
            if (i != 51)
            {
                Console.Write(",");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine();
            }
        }
        // Console.ReadKey();
    }

}


// See https://aka.ms/new-console-template for more information

