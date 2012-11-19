using System.Collections.Generic;
using CardGameFramework.Model.Deck;
using CardGameFramework.Model.Game;
using CardGameFramework.Model.Player;

namespace TrucoCmd
{
    public class TrucoDealer : IDealer
    {
        #region Implementation of IDealer

        public void DistributeCards(ICardGame cardGame, IDeck deck, ICollection<IPlayer> players)
        {
            throw new System.NotImplementedException();
        }

        public void DistributeCardsToSinglePlayer(ICardGame cardGame, IDeck deck, IPlayer player)
        {
            throw new System.NotImplementedException();
        }



        #endregion
    }
}
