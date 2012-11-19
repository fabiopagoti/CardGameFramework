using TrucoCmd;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CardGameFramework.Model.Game;
using CardGameFramework.Model.Deck;
using CardGameFramework.Model.Player;
using System.Collections.Generic;

namespace CardGameFrameworkTest
{


    [TestClass()]
    public class TrucoDealerTest
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

        [TestMethod()]
        public void DistributeCardsToSinglePlayerTest()
        {
            TrucoDealer target = new TrucoDealer(); // TODO: Initialize to an appropriate value
            ICardGame cardGame = null; // TODO: Initialize to an appropriate value
            IDeck deck = null; // TODO: Initialize to an appropriate value
            IPlayer player = null; // TODO: Initialize to an appropriate value
            target.DistributeCardsToSinglePlayer(cardGame, deck, player);
        }

        [TestMethod()]
        public void DistributeCardsTest()
        {
            TrucoDealer target = new TrucoDealer(); // TODO: Initialize to an appropriate value
            ICardGame cardGame = null; // TODO: Initialize to an appropriate value
            IDeck deck = null; // TODO: Initialize to an appropriate value
            ICollection<IPlayer> players = null; // TODO: Initialize to an appropriate value
            target.DistributeCards(cardGame, deck, players);
        }
    }
}
