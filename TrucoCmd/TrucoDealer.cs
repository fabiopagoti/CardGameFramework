using System.Collections.Generic;
using CardGameFramework.Model.Deck;
using CardGameFramework.Model.Game;
using CardGameFramework.Model.Player;

namespace TrucoCmd
{
    public class TrucoDealer : IDealer
    {
        
        
        #region Implementation of IDealer
//
//        public ICollection<Hand> DistributeCards(ICardGame cardGame, IDeck deck, ICollection<IPlayer> players)
//        {
//            throw new System.NotImplementedException();
//        }
//
//        public Hand DistributeCardsToSinglePlayer(ICardGame cardGame, IDeck deck, IPlayer player)
//        {
//            
//        }


        #endregion

        public void DistributeCardsToSinglePlayer(TrucoDeck deck, TrucoPlayer player)
        {
            DrawCardsIntoHandOfPlayer(deck, player);
        }

        /// <summary>
        /// Draw cards from deck and overwrite hand from player
        /// </summary>
        /// <param name="deck"></param>
        /// <param name="player"></param>
        /// <returns></returns>
        public Hand DrawCardsIntoHandOfPlayer(TrucoDeck deck, TrucoPlayer player)
        {
            Hand hand = new Hand();
            for (int i = 0; i < 3; i++)
            {
                hand.Cards.Add(deck.Draw());
            }
            player.Hand = hand;
            return player.Hand;
        }
    }
}
