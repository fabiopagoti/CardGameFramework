using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CardGameFramework.Model.Game;

namespace CardGameFramework.Model.Player
{
    interface IDealer
    {
        void DistributeCards(ICardGame cardGame, ICollection<Player> players);
    }
}
