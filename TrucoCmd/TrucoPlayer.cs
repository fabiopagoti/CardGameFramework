using System.Collections.Generic;
using CardGameFramework.Model.Deck;
using CardGameFramework.Model.Player;

namespace TrucoCmd
{
    public class TrucoPlayer : IPlayer
    {
        protected string name { get; set; }
        private Hand hand;
        private ICollection<TrucoPlayer> partners;

    }
}