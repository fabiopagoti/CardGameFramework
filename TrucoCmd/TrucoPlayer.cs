using System.Collections.Generic;
using CardGameFramework.Model.Deck;
using CardGameFramework.Model.Player;

namespace TrucoCmd
{
    public class TrucoPlayer : IPlayer
    {
        public string Name { get; set; }
        public Hand Hand { get; set; }
        public ICollection<TrucoPlayer> Partners { get; set; }
<<<<<<< HEAD
<<<<<<< Updated upstream
  
=======
=======
>>>>>>> TrucoMocks

        public TrucoPlayer(string name)
        {
            Name = name;
        }
<<<<<<< HEAD
        
>>>>>>> Stashed changes
=======
>>>>>>> TrucoMocks
    }
}