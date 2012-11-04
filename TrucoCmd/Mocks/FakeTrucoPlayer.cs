

namespace TrucoCmd.Mocks
{
    public class FakeTrucoPlayer
    {
        public static TrucoPlayer createPlayer(string name)
        {
            return new TrucoPlayer(name);
        }

    }
}
