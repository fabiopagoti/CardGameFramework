using System.Collections.Generic;

namespace TrucoCmd
{
    public class TrucoTeam
    {

        public string Name { get; set; }
        public ICollection<TrucoPlayer> Players;

        public TrucoTeam(ICollection<TrucoPlayer> players)
        {
            this.Players = players;
        }

        public bool isPlayerFromTeam(TrucoPlayer trucoPlayer)
        {
            return false ;

        }



    }
}