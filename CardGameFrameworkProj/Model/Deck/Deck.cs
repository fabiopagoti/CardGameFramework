using System;
using System.Collections.Generic;
using CardGameFramework.Model.Card;

namespace CardGameFramework.Model.Deck
{
    public class Deck : IDeck
    {
        // Creates a list of cards
        protected List<Card.Card> cards = new List<Card.Card>();

        // Returns the card at the given position
        public Card.Card this[int position] { get { return (Card.Card)cards[position]; } }

        /// <summary>
        /// One complete deck with every face value and suit
        /// </summary>
        public Deck()
        {
            foreach (Suit suit in Enum.GetValues(typeof(Suit)))
            {
                foreach (FaceValue faceVal in Enum.GetValues(typeof(FaceValue)))
                {
                    cards.Add(new Card.Card(suit, faceVal));
                }
            }
        }

        /// <summary>
        /// Draws one card and removes it from the deck
        /// </summary>
        /// <returns></returns>
        public Card.Card Draw()
        {
            Card.Card card = cards[0];
            cards.RemoveAt(0);
            return card;
        }

        /// <summary>
        /// Shuffles the cards in the deck
        /// </summary>
        public void Shuffle()
        {
            Random random = new Random();
            for (int i = 0; i < cards.Count; i++)
            {
                int index1 = i;
                int index2 = random.Next(cards.Count);
                SwapCard(index1, index2);
            }
        }

        /// <summary>
        /// Swaps the placement of two cards
        /// </summary>
        /// <param name="index1"></param>
        /// <param name="index2"></param>
        private void SwapCard(int index1, int index2)
        {
            Card.Card card = cards[index1];
            cards[index1] = cards[index2];
            cards[index2] = card;
        }


        public bool isCardVisible(Card.Card trump)
        {
            return false;
        }
    }
}
