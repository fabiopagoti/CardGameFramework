using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CardGameFramework.Model.Card;
using CardGameFramework.Model.Deck;


namespace TrucoCmd
{
    public class TrucoTurn
    {
        public IDictionary<TrucoTeam, int> score;
        private IList<TrucoRound> rounds;

        TrucoTurn(TrucoPlayer _first_player)
        {
            rounds = new List<TrucoRound>(3);
        }


    }
}
