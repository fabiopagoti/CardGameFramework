using System;

namespace TrucoCmd
{
    class Program
    {

        static TrucoGame game = Mocks.FakeTrucoGame.createTrucoGame4Players();

        static void Main(string[] args)
        {
            WriteWelcome();

            while (true)
            {
                WriteMenu();
                ReadOption();
            }
            
        }

        private static void ReadOption()
        {
            ConsoleKeyInfo option = Console.ReadKey();
            if (option.Key != ConsoleKey.Escape)
            {
                game.StartGame();

                while (game.Score.TeamA < 12 && game.Score.TeamB < 12)
                {
                    WriteScore();
                }
            }
        }

  
        private static void WriteWelcome()
        {
            Console.WriteLine("Welcome to Truco");
        }

        private static void WriteMenu()
        {
            Console.WriteLine("Press any key to start a new Game");
        }

        private static void WriteScore()
        {
            Console.WriteLine(game.Score.ToString());
        }

    }
}
