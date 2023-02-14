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

#region 运算符重载Demo 新增代码
public partial class Card
{

    public static bool useTrumps = false;

    public static Suit trump = Suit.Club;

    public static bool isAceHigh = true;

    public static bool operator ==(Card card1, Card card2)
    => (card1?.Suit == card2?.Suit) && (card1?.Rank == card2?.Rank);
    public static bool operator !=(Card card1, Card card2)
    => !(card1 == card2);

    public override bool Equals(object? card)
    => this == (Card)card!;
    public override int GetHashCode()
    {
        return 13 * (int)Suit + (int)Rank;
    }

    public static bool operator >(Card card1, Card card2)
    {
        if (card1.Suit == card2.Suit)
            if (isAceHigh)
                if (card1.Rank == Rank.Ace)
                    if (card2.Rank == Rank.Ace)
                        return false;
                    else
                        return true;
                else
                    if (card2.Rank == Rank.Ace)
                    return false;
                else
                    return (card1.Rank > card2?.Rank);  //为什么书上这里有NULL条件运算符？
            else
                return (card1.Rank > card2.Rank);  //为什么这里不需要?.运算符？
        else
            if (useTrumps && card2.Suit == Card.trump)
            return false;
        else
            return true;
    }

    public static bool operator >=(Card card1, Card card2)
    {
        if (card1.Suit == card2.Suit)
        {
            if (isAceHigh)
            {
                if (card1.Rank == Rank.Ace)
                {
                    return true;
                }
                else
                {
                    if (card2.Rank == Rank.Ace)
                        return false;
                    else
                        return (card1.Rank >= card2.Rank);
                }
            }
            else
            {
                return (card1.Rank >= card2.Rank);
            }
        }
        else
        {
            if (useTrumps && card2.Suit == Card.trump)
                return false;
            else
                return true;
        }
    }

    public static bool operator <(Card card1, Card card2)
    {
        return !(card1 >= card2);
    }

    public static bool operator <=(Card card1, Card card2)
    {
        return !(card1 > card2);
    }

}




#endregion