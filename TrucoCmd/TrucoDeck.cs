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
    }
}