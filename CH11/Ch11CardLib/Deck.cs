
using System;
namespace Ch11CardLib
{
    public class Deck
    {
        private Cards cards = new Cards();
        public Deck()
        {
            for (int suitVal = 0; suitVal < 4; suitVal++)
            {
                for (int rankVal = 1; rankVal < 14; rankVal++)
                {
                    cards.Add(new Card((Suit)suitVal, (Rank)rankVal));
                }
            }
        }

        public Cards GetRandomCards(int num)
        {
            this.Shuffle();
            Cards cards = new Cards();
            for (int i = 0; i < num; i++)
            {
                cards.Add(GetCard(i));
            }
            return cards;
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
            Cards newDeck = new Cards();
            cards.CopyTo(newDeck);

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

            cards = newDeck;

        }


        /// <summary>
        /// 简单洗牌
        /// </summary>
        public void SimpleShuffle()
        {
            Cards newDeck = new Cards();
            bool[] assigned = new bool[52];
            Random sourceGen = new Random();

            // 洗牌的方法：
            // 源牌堆一共52张牌，所以主循环52次。每次循环时生成随机数index，
            // 这个随机index对应的是新牌堆的空位，然后检查这个空位是否已经有牌了，
            // 如果有牌，就重新随机找新的空位，如果没牌，就把源牌堆的当前牌放在新位置里。
            // 这样循环52次后，可以确保所有的牌都已经随机打乱了。（虽然效率很低）
            for (int i = 0; i < 52; i++)
            {
                int sourceCard = 0;
                bool foundCard = false;

                while (foundCard == false)
                {
                    sourceCard = sourceGen.Next(52);
                    if (assigned[sourceCard] == false)
                        foundCard = true;
                }
                assigned[sourceCard] = true;
                newDeck.Add(cards[sourceCard]);

            }

            newDeck.CopyTo(cards);

        }

    }
}

