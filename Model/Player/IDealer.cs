using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CardGameFramework.Model.Game;
using CardGameFramework.Model.Deck;

namespace CardGameFramework.Model.Player
{
    interface IDealer
    {
        void DistributeCards(ICardGame cardGame, IDeck deck, ICollection<IPlayer> players);
    }
}
