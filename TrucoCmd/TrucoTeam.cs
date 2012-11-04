using System.Collections.Generic;

namespace TrucoCmd
{
    public class TrucoTeam
    {
<<<<<<< Updated upstream
        private string Name;
        public ICollection<TrucoPlayer> players;
=======
        public string Name { get; set; }
        public ICollection<TrucoPlayer> Players;
>>>>>>> Stashed changes

        public TrucoTeam(ICollection<TrucoPlayer> _players )
        {
<<<<<<< Updated upstream
            players = _players;
=======
            this.Players = players;
>>>>>>> Stashed changes
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