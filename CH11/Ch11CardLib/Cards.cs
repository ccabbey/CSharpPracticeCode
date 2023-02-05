using System.Collections.Generic;
// using System.Collections.Generic;
using System.Collections;
using System;
namespace Ch11CardLib
{
    public class Cards : CollectionBase
    {
        public void Add(Card newCard) => List.Add(newCard);

        public void Add(Cards newCards)
        {
            foreach (Card card in newCards)
            {
                List.Add(card);
            }
        }


        public void Remove(Card oldCard) => List.Remove(oldCard);

        public Card this[int cardIndex]
        {
            get { return (Card)List[cardIndex]!; }
            set { List[cardIndex] = value; }
        }

        /// <summary>
        /// Utility method for copying card instances into another Cards
        /// instance-used in Deck.Shuffle(). This implementation assumes that
        /// source and target collections are the same size.
        /// </summary>
        /// <param name="targetCards"></param>
        public void CopyTo(Cards targetCards)
        {
            for (int index = 0; index < this.Count; index++)
            {
                targetCards.Add(this[index]);
            }

        }

        public bool Contains(Card card) => InnerList.Contains(card);
    }
}
