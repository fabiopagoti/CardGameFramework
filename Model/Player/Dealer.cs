using System.Collections.Generic;
using CardGameFramework.Model.Card;
using CardGameFramework.Model.Game;

namespace CardGameFramework.Model.Player
{
    public class Dealer : IDealer
    {

        public void DistributeCards(ICardGame cardGame, ICollection<Player> players)
        {

        }

        public Card.Card showTrumpCard(Deck.Deck deck)
        {
            return new Card.Card(Suit.Clubs, FaceValue.Ace);
        }


    }
}