using System.Collections.Generic;

namespace TrucoCmd
{
    public class TrucoTeam
    {
        private string Name;
        public ICollection<TrucoPlayer> players;

        public TrucoTeam(ICollection<TrucoPlayer> _players )
        {
            players = _players;
        }

        public TrucoPlayer TrucoPlayer
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

    }
}