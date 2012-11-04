using CardGameFramework.Model.Game;
using TrucoCmd.Mocks;

namespace TrucoCmd
{
    public class TrucoGame : ICardGame
    {
        public TrucoScore Score ;
        public TrucoTeam TeamA;
        public TrucoTeam TeamB;


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
            TeamA = new TrucoTeam(_number_of_players/2);
            TeamB = new TrucoTeam(_number_of_players/2);

            for (int i = 0; i < _number_of_players; i++)
            {
                if (i%2 == 0)
                {
                    TeamA.players.Add(new TrucoPlayer());
                }
                else
                {
                    TeamB.players.Add(new TrucoPlayer());
                }
            }
        }

        public void StartGame()
        {
            Score = FakeTrucoScore.createTrucoScore(0, 0);
        }

    }
}