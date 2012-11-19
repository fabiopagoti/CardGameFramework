using CardGameFramework.Model.Card;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CardGameFrameworkTest
{
    /// <summary>
    ///This is a test class for CardTest and is intended
    ///to contain all CardTest Unit Tests
    ///</summary>
    [TestClass()]
    public class CardTest
    {

        #region Additional test attributes

        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //

        #endregion

        #region Equals(ICard)

        [TestMethod()]
        public void EqualsTestAceClubsNullReturnsFalse()
        {
            Card target = new Card(Suit.Clubs, FaceValue.Ace);
            Card c = null;
            bool actual = target.Equals(c);
            Assert.AreEqual(false, actual);
        }

        [TestMethod()]
        public void EqualsTestAceClubsAceClubsReturnsTrue()
        {
            Card target = new Card(Suit.Clubs, FaceValue.Ace);
            Card c = new Card(Suit.Clubs, FaceValue.Ace);
            bool actual = target.Equals(c);
            Assert.AreEqual(true, actual);
        }

        [TestMethod()]
        public void EqualsTestAceClubsAceSpadesReturnsFalse()
        {
            Card target = new Card(Suit.Clubs, FaceValue.Ace);
            Card c = new Card(Suit.Spades, FaceValue.Ace);
            bool actual = target.Equals(c);
            Assert.AreEqual(false, actual);
        }

        [TestMethod()]
        public void EqualsTestAceClubsTwoClubsReturnsFalse()
        {
            Card target = new Card(Suit.Clubs, FaceValue.Ace);
            Card c = new Card(Suit.Clubs, FaceValue.Two);
            bool actual = target.Equals(c);
            Assert.AreEqual(false, actual);
        }


        [TestMethod()]
        public void EqualsTestAceClubsSameReferenceAceClubsReturnsTrue()
        {
            Card target = new Card(Suit.Clubs, FaceValue.Ace);
            Card c = target;
            bool actual = target.Equals(c);
            Assert.AreEqual(true, actual);
        }

        #endregion

        #region Equals(Obj)

        [TestMethod()]
        public void EqualsTestObjAceClubsNullObjectReturnsFalse()
        {
            Card target = new Card(Suit.Clubs, FaceValue.Ace);
            object obj = null;
            bool actual = target.Equals(obj);
            Assert.AreEqual(false, actual);
        }

        [TestMethod()]
        public void EqualsTestObjAceClubsCardObjectAceClubsReturnsTrue()
        {
            Card target = new Card(Suit.Clubs, FaceValue.Ace);
            object obj = new Card(Suit.Clubs, FaceValue.Ace);
            bool actual = target.Equals(obj);
            Assert.AreEqual(true, actual);
        }

        [TestMethod()]
        public void EqualsTestObjAceClubsCardObjectAceSpadesReturnsFalse()
        {
            Card target = new Card(Suit.Clubs, FaceValue.Ace);
            object obj = new Card(Suit.Spades, FaceValue.Ace);
            bool actual = target.Equals(obj);
            Assert.AreEqual(false, actual);
        }

        [TestMethod()]
        public void EqualsTestObjAceClubsCardObjectTwoClubsReturnsTrue()
        {
            Card target = new Card(Suit.Clubs, FaceValue.Ace);
            object obj = new Card(Suit.Clubs, FaceValue.Two);
            bool actual = target.Equals(obj);
            Assert.AreEqual(false, actual);
        }

        [TestMethod()]
        public void EqualsTestObjAceClubsCardObjectSameReferenceAceClubsReturnsTrue()
        {
            Card target = new Card(Suit.Clubs, FaceValue.Ace);
            object obj = target;
            bool actual = target.Equals(obj);
            Assert.AreEqual(true, actual);
        }

        #endregion

        #region GetHashCode

        [TestMethod()]
        public void GetHashCodeAceClubs1ReturnsTrue()
        {
            Card target = new Card(Suit.Clubs, FaceValue.Ace);
            int expected = 1;
            int actual = target.GetHashCode();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetHashCodeAceClubs14ReturnsTrue()
        {
            Card target = new Card(Suit.Spades, FaceValue.King);
            int expected = 14;
            int actual = target.GetHashCode();
            Console.Write(actual);
            Assert.AreEqual(expected, actual);
        }

        #endregion

        #region ToString

        [TestMethod()]
        public void ToStringAce()
        {
            Card target = new Card(Suit.Clubs, FaceValue.Ace);
            String actual = target.ToString();
            Assert.AreEqual("The Ace of Clubs", actual);
        }

        #endregion

    }
}