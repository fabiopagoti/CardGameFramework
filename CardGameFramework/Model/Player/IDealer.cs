using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CardGameFramework.Model.Game;
using CardGameFramework.Model.Deck;

namespace CardGameFramework.Model.Player
{
    public interface IDealer
    {
        void DistributeCards(ICardGame cardGame, IDeck deck, ICollection<IPlayer> players);

        void DistributeCardsToSinglePlayer(ICardGame cardGame, IDeck deck, IPlayer player);

    }
}
