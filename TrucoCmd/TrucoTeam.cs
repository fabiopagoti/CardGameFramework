using System.Collections.Generic;

namespace TrucoCmd
{
    public class TrucoTeam
    {
        public string Name { get; set; }
        public ICollection<TrucoPlayer> players;

        public TrucoTeam(ICollection<TrucoPlayer> players)
        {
            this.players = players;
        }
    }
}