using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CardGameFramework.Model.Card;
using CardGameFramework.Model.Deck;

namespace TrucoCmd
{
    public class TrucoDeck : Deck
    {
        
        public TrucoDeck CreateTrucoDeck()
        {

            var query = from card in this.cards
                        where
                            card.FaceVal.CompareTo(FaceValue.Eight) != 0 ||
                            card.FaceVal.CompareTo(FaceValue.Nine) != 0 ||
                            card.FaceVal.CompareTo(FaceValue.Ten) != 0
                        select card;

           this.cards = query.ToList();
           return this;
        }

        /// <summary>
        /// Checks if a card is part of a deck, if a card is not part of a deck it will never be present on it during a game
        /// </summary>
        /// <param name="card"></param>
        /// <returns></returns>
        public bool isCardPartOfDeck(Card card)
        {
            return this.cards.Exists(x => x.Equals(card));
        }

        /// <summary>
        /// Checks if a card is present in a deck. A card might be part of a deck but not present on it at the same time, if it is possession of a user for example.
        /// </summary>
        /// <param name="card"></param>
        /// <returns></returns>
        public bool isCardPresentInDeck(Card card)
        {
            return false;
        }

    }
}