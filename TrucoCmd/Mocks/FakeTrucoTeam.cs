using System.Collections.Generic;

namespace TrucoCmd.Mocks
{
    public class FakeTrucoTeam
    {

        public static TrucoTeam createTeamSize2(string Player1Name, string Player2Name)
        {

            return new TrucoTeam(
                new List<TrucoPlayer>()
                    {
                        FakeTrucoPlayer.createPlayer(Player1Name),
                        FakeTrucoPlayer.createPlayer(Player2Name),
                    });
        }

        public static TrucoTeam createTeamSize3(string Player1Name, string Player2Name, string Player3Name)
        {

            return new TrucoTeam(
                new List<TrucoPlayer>()
                    {
                        FakeTrucoPlayer.createPlayer(Player1Name),
                        FakeTrucoPlayer.createPlayer(Player2Name),
                        FakeTrucoPlayer.createPlayer(Player3Name)
                    });
        }

        public static TrucoTeam createAnimal2Team()
        {
            return createTeamSize2("Alligator", "Bird");
        }

        public static TrucoTeam createAnimal3Team()
        {
            return createTeamSize3("Alligator", "Bird","Cat");
        }

        public static TrucoTeam createPokemon2Team()
        {
            return createTeamSize2("Anon", "Bulbasaur");
        }

        public static TrucoTeam createPokemon3Team()
        {
            return createTeamSize3("Anon", "Bulbasaur", "Charmander");
        }

    }
}
