using System.Collections.Generic;

namespace TrucoCmd
{
    public class TrucoTeam
    {
        private string Name;
        public ICollection<TrucoPlayer> players;

        public TrucoTeam(int numberOfPlayers)
        {
            players = new List<TrucoPlayer>(numberOfPlayers);
        }

    }
}