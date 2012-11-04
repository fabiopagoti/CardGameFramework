namespace TrucoCmd
{
    public class TrucoScore
    {
        public int TeamA { get; private set; }
        public int TeamB { get; private set; }

        public TrucoScore(int teamA, int teamB)
        {
            TeamA = teamA;
            TeamB = teamB;
        }

    }
}