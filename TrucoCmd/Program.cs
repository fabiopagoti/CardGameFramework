using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrucoCmd
{
    class Program
    {
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
                TrucoGame game = new TrucoGame(4);
                game.StartGame();
            }
        }

        private static void WriteWelcome()
        {
            Console.WriteLine("Welcome to Truco");
        }

        private static void WriteMenu()
        {
            Console.Write("Press any key to start a new Game");
        }
    }
}
