using System;
using CardGameFramework.Model.Card;

namespace CardWritter
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Card card = null;
            Suit? suit = null;
            FaceValue? faceValue = null;
            
            GameIntro();
            while (Console.ReadKey().Key != ConsoleKey.Escape)
            {
                suit = InputSuit(suit);
                faceValue = InputFaceValue(faceValue);
                card = new Card((Suit) suit, (FaceValue) faceValue);
                PrintCard(card);
                GameIntro();
            }
        }


        private static void GameIntro()
        {
            Console.Clear();
            Console.WriteLine("Welcome to CardWritter! [Any key] to start [Esq] To exit\n");
            Console.Beep();
        }


        private static void PrintCard(Card card)
        {
            Console.WriteLine(card.ToString() + Environment.NewLine);
            Console.WriteLine("Pres any key to go back to menu");
            Console.Read();
        }

        private static Suit InputSuit(Suit? suit)
        {
            Console.WriteLine("Select Suit\n1-Diamonds\n2-Spades\n3-Clubs\n4-Hearts\n\n");

            ConsoleKey? keyInfo = null;

            while (keyInfo != ConsoleKey.D1 &&
                   keyInfo != ConsoleKey.D2 &&
                   keyInfo != ConsoleKey.D3 &&
                   keyInfo != ConsoleKey.D4)
            {
                keyInfo = Console.ReadKey(true).Key;

                switch (keyInfo)
                {
                    case ConsoleKey.D1:
                        suit = Suit.Diamonds;
                        break;

                    case ConsoleKey.D2:
                        suit = Suit.Spades;
                        break;

                    case ConsoleKey.D3:
                        suit = Suit.Clubs;
                        break;

                    case ConsoleKey.D4:
                        suit = Suit.Hearts;
                        break;
                }
            }
            return (Suit) suit;
        }
        
        private static FaceValue InputFaceValue(FaceValue? faceValue)
        {
            Console.WriteLine("Select Face Value: A, 2-10, J, Q, K");

            String faceValueString = String.Empty;

            while (
                faceValueString.CompareTo("A") != 0 &&
                faceValueString.CompareTo("2") != 0 &&
                faceValueString.CompareTo("3") != 0 &&
                faceValueString.CompareTo("4") != 0 &&
                faceValueString.CompareTo("5") != 0 &&
                faceValueString.CompareTo("6") != 0 &&
                faceValueString.CompareTo("7") != 0 &&
                faceValueString.CompareTo("8") != 0 &&
                faceValueString.CompareTo("9") != 0 &&
                faceValueString.CompareTo("10") != 0 &&
                faceValueString.CompareTo("J") != 0 &&
                faceValueString.CompareTo("Q") != 0 &&
                faceValueString.CompareTo("K") != 0
                )
            {
                faceValueString = Console.ReadLine();

                switch (faceValueString)
                {
                    case "A":
                        faceValue = FaceValue.Ace;
                        break;
                    case "2":
                        faceValue = FaceValue.Two;
                        break;
                    case "3":
                        faceValue = FaceValue.Three;
                        break;
                    case "4":
                        faceValue = FaceValue.Four;
                        break;
                    case "5":
                        faceValue = FaceValue.Five;
                        break;
                    case "6":
                        faceValue = FaceValue.Six;
                        break;
                    case "7":
                        faceValue = FaceValue.Seven;
                        break;
                    case "8":
                        faceValue = FaceValue.Eight;
                        break;
                    case "9":
                        faceValue = FaceValue.Nine;
                        break;
                    case "10":
                        faceValue = FaceValue.Ten;
                        break;
                    case "J":
                        faceValue = FaceValue.Jack;
                        break;
                    case "Q":
                        faceValue = FaceValue.Queen;
                        break;
                    case "K":
                        faceValue = FaceValue.King;
                        break;
                }
                
            }
            return (FaceValue) faceValue;
        }
    }
}