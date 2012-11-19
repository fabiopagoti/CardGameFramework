using System;
using CardGameFramework.Mocks;
using CardGameFramework.Model.Card;


namespace TrucoCmd
{
    internal class Program
    {
        
        private static TrucoGame game = Mocks.FakeTrucoGame.createTrucoGame4Players();
        
        // settings
        private static string PlayerName = string.Empty;
        private static int NumberOfPlayers;

        // end of settings
        private static void Main(string[] args)

        {
            WriteWelcome();
            WriteMenu();

            ConsoleKeyInfo opt = Console.ReadKey();
            while (!opt.Equals(ConsoleKey.Q))
            {
                SelectOption(opt);
                WriteMenu();
                opt = ReadOption();
            }
            return;
        }

        private static ConsoleKeyInfo ReadOption()
        {
            ConsoleKeyInfo option = Console.ReadKey();
            return option;
        }

        private static void SelectOption(ConsoleKeyInfo option)
        {
            switch (option.Key)
            {
                case ConsoleKey.D1:
                    PlayGame();
                    break;
                case ConsoleKey.D2:
                    PlayerName = ConfigurePlayerName();
                    break;
                case ConsoleKey.D3:
                    NumberOfPlayers = ConfigureNumberOfPlayers();
                    break;
                case ConsoleKey.Q:
                    
                    break;
            }
        }

        private static void PlayGame()
        {
            game.StartGame();

            while (game.Score.TeamA < 12 && game.Score.TeamB < 12)
            {
                WriteScore();

                int suitCount = 0;
                foreach (var trucoPlayer in game.TeamA.Players)
                {
                    suitCount++;
                    if (suitCount == 1)
                    {
                        trucoPlayer.Hand = FakeHand.createHand(Suit.Clubs);
                    }
                    if (suitCount == 2)
                    {
                        trucoPlayer.Hand = FakeHand.createHand(Suit.Diamonds);
                    }
                }

                foreach (TrucoPlayer trucoPlayer in game.TeamB.Players)
                {
                    suitCount++;
                    if (suitCount == 3)
                    {
                        trucoPlayer.Hand = FakeHand.createHand(Suit.Hearts);
                    }
                    if (suitCount == 4)
                    {
                        trucoPlayer.Hand = FakeHand.createHand(Suit.Spades);
                    }
                }

                WritePlayersHands();

                game.Score.SumPoints(1, 0);
            }
        }



        private static void WriteWelcome()
        {
            Console.WriteLine("Welcome to Truco");
        }

        private static void WriteMenu()
        {
            Console.WriteLine("1) Start a new Game\n" +
                              "2) Player Name\n" +
                              "3) Number of Players\n" +
                              "Esq) Quit\n");
        }


        private static void WriteScore()
        {
            Console.WriteLine(game.Score.ToString());
        }


        private static void WritePlayersHands()
        {
            foreach (TrucoPlayer trucoPlayer in game.TeamA.Players)
            {
                Console.WriteLine(string.Concat(trucoPlayer.Name, trucoPlayer.Hand.ToString()));
            }

            foreach (TrucoPlayer trucoPlayer in game.TeamA.Players)
            {
                Console.WriteLine(string.Concat(trucoPlayer.Name, trucoPlayer.Hand.ToString()));
            }
        }

        private static string ConfigurePlayerName()
        {
            Console.WriteLine("What is your name?");
            return Console.ReadLine();
        }

        private static int ConfigureNumberOfPlayers()
        {
            Console.WriteLine("What in 4 or 6 players?");
            ConsoleKeyInfo inputNumberOfPlayers = Console.ReadKey();
            while (!inputNumberOfPlayers.Equals(ConsoleKey.D4) && 
                   !inputNumberOfPlayers.Equals(ConsoleKey.D6))
            {
            Console.WriteLine("What in 4 or 6 players?");
            inputNumberOfPlayers = Console.ReadKey();
            }
            if (inputNumberOfPlayers.Equals(ConsoleKey.D4))
            {
                return 4;
            }
            else
            {
                return 6;
            }
           

        }

    }
}
