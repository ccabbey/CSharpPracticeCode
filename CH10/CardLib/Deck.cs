
using System;
namespace Ch11CardLib;

public class Deck
{
    private Card[] cards;
    public Deck()
    {
        cards = new Card[52];
        for (int suitVal = 0; suitVal < 4; suitVal++)
        {
            for (int rankVal = 1; rankVal < 14; rankVal++)
            {
                cards[suitVal * 13 + rankVal - 1] = new Card((Suit)suitVal,
                                                            (Rank)rankVal);
            }
        }
    }

    public Card[] GetRandomCards(int num)
    {
        this.Shuffle();
        return cards[0..num];
    }

    public Card GetCard(int cardNum)
    {
        if (cardNum >= 0 && cardNum <= 51)
        {
            return cards[cardNum];
        }
        else
        {
            throw new ArgumentOutOfRangeException("cardNum", cardNum, "value must be between 0 and 51.");

        }
    }

    /// <summary>
    /// Knuth shuffle 算法
    /// </summary>
    public void Shuffle()
    {
        Card[] newDeck = cards;
        Random rand = new();
        int j;
        Card tempCard;
        for (int i = 0; i < 50; i++)
        {
            j = rand.Next(52);
            tempCard = newDeck[i];
            newDeck[i] = newDeck[j];
            newDeck[j] = tempCard;
        }

        newDeck.CopyTo(cards, 0);

    }


    /// <summary>
    /// 简单洗牌
    /// </summary>
    public void SimpleShuffle()
    {
        Card[] newDeck = new Card[52];
        bool[] assigned = new bool[52];
        Random sourceGen = new Random();

        // 洗牌的方法：
        // 源牌堆一共52张牌，所以主循环52次。每次循环时生成随机数index，
        // 这个随机index对应的是新牌堆的空位，然后检查这个空位是否已经有牌了，
        // 如果有牌，就重新随机找新的空位，如果没牌，就把源牌堆的当前牌放在新位置里。
        // 这样循环52次后，可以确保所有的牌都已经随机打乱了。（虽然效率很低）
        for (int i = 0; i < 52; i++)
        {
            int destCard = 0;
            bool foundCard = false;

            while (foundCard == false)
            {
                destCard = sourceGen.Next(52);
                if (assigned[destCard] == false)
                    foundCard = true;
            }
            assigned[destCard] = true;
            newDeck[destCard] = cards[i];

        }

        newDeck.CopyTo(cards, 0);

    }

}