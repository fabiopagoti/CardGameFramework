﻿
namespace CardGameFramework.Model.Card
 
{
    /// <summary>
    /// Card suit values
    /// </summary>
    public enum Suit
    {
        Diamonds, Spades, Clubs, Hearts
    }

    /// <summary>
    /// Card face values
    /// </summary>
    public enum FaceValue
    {
        Ace = 1,
        Two = 2,
        Three = 3,
        Four = 4,
        Five = 5,
        Six = 6,
        Seven = 7,
        Eight = 8,
        Nine = 9,
        Ten = 10,
        Jack = 11,
        Queen = 12,
        King = 13,
    }

    public class Card: BaseCard
    {
        // Objects for card information
        private readonly Suit suit;
        private readonly FaceValue faceVal;
        //private bool isCardUp;

        public Suit Suit { get { return suit; } }
        public FaceValue FaceVal { get { return faceVal; } }

        /// <summary>
        /// Constructor for a new card.  Assign the card a suit, face value, and if the card is facing up or down
        /// </summary>
        /// <param name="suit"></param>
        /// <param name="faceVal"></param>
        /// <param name="isCardUp"></param>
        public Card(Suit suit, FaceValue faceVal):base()
        {
            this.suit = suit;
            this.faceVal = faceVal;          
        }

        /// <summary>
        /// Return the card as a string (i.e. "The Ace of Spades")
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "The " + faceVal.ToString() + " of " + suit.ToString();
        }
    }
}