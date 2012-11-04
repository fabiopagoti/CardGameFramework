using System.Collections.Generic;
using CardGameFramework.Model.Game;

namespace TrucoCmd
{
    public class TrucoGame : ICardGame
    {
        private IDictionary<TrucoTeam, int> score;
        private TrucoTeam teamA;
        private TrucoTeam teamB;


        public TrucoGame(int _number_of_players)
        {
            if (_number_of_players != 4 && _number_of_players != 6)
            {
                return;
//                throw InvalidNumberOfPlayersException();
            }
            else
            {
                CreatePlayers(_number_of_players);
            }
        }

        private void CreatePlayers(int _number_of_players)
        {
<<<<<<< Updated upstream
            teamA = new TrucoTeam(_number_of_players/2);
            teamB = new TrucoTeam(_number_of_players/2);

            for (int i = 0; i < _number_of_players; i++)
            {
                if (i%2 == 0)
                {
                    teamA.players.Add(new TrucoPlayer());
                }
                else
                {
                    teamB.players.Add(new TrucoPlayer());
                }
            }
=======
            TeamA = FakeTrucoTeam.createAnimal2Team();
            TeamB = FakeTrucoTeam.createPokemon2Team();

//            for (int i = 0; i < _number_of_players; i++)
//            {
//                if (i%2 == 0)
//                {
//                    TeamA.Players.Add(new TrucoPlayer());
//                }
//                else
//                {
//                    TeamB.Players.Add(new TrucoPlayer());
//                }
//            }
>>>>>>> Stashed changes
        }

        public void StartGame()
        {
            score = new Dictionary<TrucoTeam, int>();
            score.Add(teamA, 0);
            score.Add(teamB, 0);
        }
    }
}