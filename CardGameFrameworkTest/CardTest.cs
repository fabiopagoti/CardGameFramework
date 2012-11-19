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
        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get { return testContextInstance; }
            set { testContextInstance = value; }
        }

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

        /// <summary>
        ///A test for Equals
        ///</summary>
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


        /// <summary>
        ///A test for Equals
        ///</summary>
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


        /// <summary>
        ///A test for GetHashCode
        ///</summary>
        [TestMethod()]
        public void GetHashCodeTest()
        {
            Suit suit = new Suit(); // TODO: Initialize to an appropriate value
            FaceValue faceVal = new FaceValue(); // TODO: Initialize to an appropriate value
            Card target = new Card(suit, faceVal); // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.GetHashCode();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ToString
        ///</summary>
        [TestMethod()]
        public void ToStringTest()
        {
            Suit suit = new Suit(); // TODO: Initialize to an appropriate value
            FaceValue faceVal = new FaceValue(); // TODO: Initialize to an appropriate value
            Card target = new Card(suit, faceVal); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.ToString();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Card Constructor
        ///</summary>
        [TestMethod()]
        public void CardConstructorTest()
        {
            Suit suit = new Suit(); // TODO: Initialize to an appropriate value
            FaceValue faceVal = new FaceValue(); // TODO: Initialize to an appropriate value
            Card target = new Card(suit, faceVal);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }
    }
}