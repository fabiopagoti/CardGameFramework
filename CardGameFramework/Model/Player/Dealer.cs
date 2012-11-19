using System.Collections.Generic;
using CardGameFramework.Model.Card;
using CardGameFramework.Model.Deck;
using CardGameFramework.Model.Game;

namespace CardGameFramework.Model.Player
{
    public class Dealer : IDealer
    {

        public Card.Card showTrumpCard(Deck.Deck deck)
        {
            return new Card.Card(Suit.Clubs, FaceValue.Ace);
        }

        public ICollection<Hand> DistributeCards(ICardGame cardGame, IDeck deck, ICollection<IPlayer> players)
        {
            return null;
        }

        public Hand DistributeCardsToSinglePlayer(ICardGame cardGame, IDeck deck, IPlayer players)
        {
            return null;
        }
    }
}