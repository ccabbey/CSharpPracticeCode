namespace Ch11CardLib;

public class Card : ICloneable
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