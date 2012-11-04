

namespace TrucoCmd.Mocks
{
    public class FakeTrucoGame
    {

        public static TrucoGame createTrucoGame4Players()
        {
            var trucoGame = new TrucoGame(4);
            trucoGame.Score = FakeTrucoScore.createTrucoScore(0, 0);
            trucoGame.TeamA = FakeTrucoTeam.createAnimal2Team();
            trucoGame.TeamB = FakeTrucoTeam.createPokemon2Team();
            return trucoGame;
        }

        public static TrucoGame createTrucoGame6Players()
        {
            var trucoGame = new TrucoGame(6);
            trucoGame.Score = FakeTrucoScore.createTrucoScore(0, 0);
            trucoGame.TeamA = FakeTrucoTeam.createAnimal3Team();
            trucoGame.TeamB = FakeTrucoTeam.createPokemon3Team();
            return trucoGame;
        }

    }
}
