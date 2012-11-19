
namespace CardGameFramework.Model.Card
 
{
    /// <summary>
    /// Card suit values
    /// </summary>
    public enum Suit
    {
        Clubs,
        Diamonds,
        Hearts,
        Spades
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

    public class Card: ICard
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


        public override bool Equals(System.Object obj)
        {
            if (obj == null)
            {
                return false;
            }

            Card c = obj as Card;
            if ((System.Object)c == null)
            {
                return false;
            }
            return (Suit == c.Suit) && (FaceVal == c.FaceVal);
        }

        public bool Equals(Card c)
        {
            if ((object)c == null)
            {
                return false;
            }
            return (Suit == c.Suit) && (FaceVal == c.FaceVal);
        }

        public override int GetHashCode()
        {
            return (int) (FaceVal ^ (FaceValue) Suit);
        }
    }
}