using CardGameFramework.Model.Card;
using TrucoCmd;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CardGameFramework.Model.Game;
using CardGameFramework.Model.Deck;
using CardGameFramework.Model.Player;
using System.Collections.Generic;
using TrucoCmd.Mocks;
using System;

namespace TrucoUnit
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
        public void DistributeCardsTest()
        {
            TrucoDealer target = new TrucoDealer(); // TODO: Initialize to an appropriate value
            ICardGame cardGame = null; // TODO: Initialize to an appropriate value
            IDeck deck = null; // TODO: Initialize to an appropriate value
            ICollection<IPlayer> players = null; // TODO: Initialize to an appropriate value
//            target.DistributeCards(cardGame, deck, players);
        }


        [TestMethod()]
        public void DistributeCardsToSinglePlayerTest()
        {
            TrucoDealer target = FakeTrucoDealer.CreateDealer();
            TrucoDeck deck = new TrucoDeck();
            TrucoPlayer player = FakeTrucoPlayer.createPlayer("Bob");
            target.DistributeCardsToSinglePlayer(deck, player);
            Assert.AreEqual(player.Hand.NumCards,3);
        }

        [TestMethod()]
        public void DrawCardsIntoHandOfPlayerTest()
        {
            TrucoDealer target = FakeTrucoDealer.CreateDealer();
            TrucoDeck deck = FakeTrucoDeck.CreateDeckOfSpadesInOrder();
            TrucoPlayer player = FakeTrucoPlayer.createPlayer("Bob");
            Hand actual = target.DrawCardsIntoHandOfPlayer(deck, player);
            Hand expected = new Hand();
            expected.Cards.Add(new Card(Suit.Spades, FaceValue.Ace));
            expected.Cards.Add(new Card(Suit.Spades, FaceValue.Two));
            expected.Cards.Add(new Card(Suit.Spades, FaceValue.Three));
            Assert.AreEqual(expected.ToString(), actual.ToString()); // Implements Equals into Deck
        }
    }
}