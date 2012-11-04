

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

        public override string ToString()
        {
            return string.Format(@"Team A: {0} \r Team B: {1}", TeamA, TeamB);
        }

        public TrucoScore SumPoints(int NumberOFPointsTeamA, int NumberOFPointsTeamB)
        {
            TeamA += NumberOFPointsTeamA;
            TeamB += NumberOFPointsTeamB;
            return this;
        }
    }
}