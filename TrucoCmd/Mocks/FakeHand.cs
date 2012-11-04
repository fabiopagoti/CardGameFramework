using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CardGameFramework.Model.Card;
using CardGameFramework.Model.Deck;

namespace CardGameFramework.Mocks
{
    public class FakeHand
    {

        public static Hand createHand(Suit suit)
        {
            Hand hand = new Hand();
            hand.Cards.AddRange(
                new List<Card>()
                    {
                        new Card(suit, FaceValue.Ace),
                        new Card(suit, FaceValue.Two),
                        new Card(suit, FaceValue.Three)
                    });
            return hand;
        }

    }
}
