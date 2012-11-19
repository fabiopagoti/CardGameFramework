using TrucoCmd;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CardGameFramework.Model.Card;

namespace TrucoSpecs
{
    
    
    /// <summary>
    ///This is a test class for TrucoDeckTest and is intended
    ///to contain all TrucoDeckTest Unit Tests
    ///</summary>
    [TestClass()]
    public class TrucoDeckTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
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
        ///A test for isCardPartOfDeck
        ///</summary>
        [TestMethod()]
        public void IsCardPartOfDeckTest8AllSuitsReturnFalse()
        {
            TrucoDeck target = new TrucoDeck();
            
            Card card = new Card(Suit.Clubs,FaceValue.Eight);
            bool actual = target.isCardPartOfDeck(card);
            Assert.AreEqual(false, actual);

            card = new Card(Suit.Diamonds, FaceValue.Eight);
            actual = target.isCardPartOfDeck(card);
            Assert.AreEqual(false, actual);

            card = new Card(Suit.Hearts, FaceValue.Eight);
            actual = target.isCardPartOfDeck(card);
            Assert.AreEqual(false, actual);

            card = new Card(Suit.Spades, FaceValue.Eight);
            actual = target.isCardPartOfDeck(card);
            Assert.AreEqual(false, actual);

        }

        [TestMethod()]
        public void IsCardPartOfDeckTest9AllSuitsReturnFalse()
        {
            TrucoDeck target = new TrucoDeck();

            Card card = new Card(Suit.Clubs, FaceValue.Nine);
            bool actual = target.isCardPartOfDeck(card);
            Assert.AreEqual(false, actual);

            card = new Card(Suit.Diamonds, FaceValue.Nine);
            actual = target.isCardPartOfDeck(card);
            Assert.AreEqual(false, actual);

            card = new Card(Suit.Hearts, FaceValue.Nine);
            actual = target.isCardPartOfDeck(card);
            Assert.AreEqual(false, actual);

            card = new Card(Suit.Spades, FaceValue.Nine);
            actual = target.isCardPartOfDeck(card);
            Assert.AreEqual(false, actual);

        }

        [TestMethod()]
        public void IsCardPartOfDeckTest10AllSuitsReturnFalse()
        {
            TrucoDeck target = new TrucoDeck();

            Card card = new Card(Suit.Clubs, FaceValue.Ten);
            bool actual = target.isCardPartOfDeck(card);
            Assert.AreEqual(false, actual);

            card = new Card(Suit.Diamonds, FaceValue.Ten);
            actual = target.isCardPartOfDeck(card);
            Assert.AreEqual(false, actual);

            card = new Card(Suit.Hearts, FaceValue.Ten);
            actual = target.isCardPartOfDeck(card);
            Assert.AreEqual(false, actual);

            card = new Card(Suit.Spades, FaceValue.Ten);
            actual = target.isCardPartOfDeck(card);
            Assert.AreEqual(false, actual);

        }


    }
}
