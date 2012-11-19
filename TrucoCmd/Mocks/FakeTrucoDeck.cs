using System.Linq;
using CardGameFramework.Model.Card;

namespace TrucoCmd.Mocks
{
    public class FakeTrucoDeck
    {
        public static TrucoDeck CreateDeckOfSpadesInOrder()
        {
            var deck = new TrucoDeck();

            var query = from card in deck.cards
                        where card.Suit.CompareTo(Suit.Spades) == 0
                        orderby card.FaceVal
                        select card;

            deck.cards = query.ToList();
            return deck;
        }
    }
}