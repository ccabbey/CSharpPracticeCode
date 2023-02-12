namespace Ch11CardLib;

public partial class Card : ICloneable
{
    public readonly Suit Suit;
    public readonly Rank Rank;
    public Card(Suit newSuit, Rank newRank)
    {
        Suit = newSuit;
        Rank = newRank;
    }
    private Card() { }

    public object Clone()
    {
        return MemberwiseClone();
    }

    public override string ToString() => "The " + Rank + " of " + Suit + "s";

}


public partial class Card
{
    public static bool useTrumps = false;

    public static Suit trumpSuit = Suit.Club;

    public static bool isAceHigh = true;
}