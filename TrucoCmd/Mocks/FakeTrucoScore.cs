

namespace TrucoCmd.Mocks
{
    public class FakeTrucoScore
    {

        public static TrucoScore createTrucoScore(int TeamAScore, int TeamBScore)
        {
            return new TrucoScore(TeamAScore,TeamBScore);
        }
    }
}
