using System.Collections.ObjectModel;
using TrucoCmd;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using TrucoCmd.Mocks;

namespace TrucoUnit
{
    
    
    /// <summary>
    ///This is a test class for TrucoTeamTest and is intended
    ///to contain all TrucoTeamTest Unit Tests
    ///</summary>
    [TestClass()]
    public class TrucoTeamTest
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


        #region IsPlayerFromTeam

        /// <summary>
        ///A test for isPlayerFromTeam
        ///</summary>
        [TestMethod()]
        public void IsPlayerFromTeamGivenPlayerNullTeamNullThenReturnFalse()
        {
            ICollection<TrucoPlayer> players = null;
            TrucoTeam target = new TrucoTeam(players);
            TrucoPlayer trucoPlayer = null;
            bool actual = target.isPlayerFromTeam(trucoPlayer);
            Assert.AreEqual(false, actual);
        }

        [TestMethod()]
        public void IsPlayerFromTeamGivenPlayerP1InTeamT1ThenReturnTrue()
        {
            TrucoPlayer trucoPlayer = FakeTrucoPlayer.createPlayer("P1");
            ICollection<TrucoPlayer> players = new Collection<TrucoPlayer>{
                trucoPlayer
            };
            TrucoTeam target = new TrucoTeam(players);
            bool actual = target.isPlayerFromTeam(trucoPlayer);
            Assert.AreEqual(true, actual);
        }

        [TestMethod()]
        public void IsPlayerFromTeamGivenPlayerP1NotInTeamT1ThenReturnFalse()
        {
            TrucoPlayer trucoPlayer = FakeTrucoPlayer.createPlayer("P1");
            ICollection<TrucoPlayer> players = new Collection<TrucoPlayer>{
                FakeTrucoPlayer.createPlayer("P2")
            };
            TrucoTeam target = new TrucoTeam(players);
            bool actual = target.isPlayerFromTeam(trucoPlayer);
            Assert.AreEqual(false, actual);
        }

        [TestMethod()]
        public void IsPlayerFromTeamGivenPlayerP1InTeamT1With1MorePlayerThenReturnTrue()
        {
            TrucoPlayer trucoPlayer = FakeTrucoPlayer.createPlayer("P1");
            ICollection<TrucoPlayer> players = new Collection<TrucoPlayer>{
                trucoPlayer,
                FakeTrucoPlayer.createPlayer("P2")
            };
            TrucoTeam target = new TrucoTeam(players);
            bool actual = target.isPlayerFromTeam(trucoPlayer);
            Assert.AreEqual(true, actual);
        }

        [TestMethod()]
        public void IsPlayerFromTeamGivenPlayerP1InTeamT1With2MorePlayerThenReturnTrue()
        {
            TrucoPlayer trucoPlayer = FakeTrucoPlayer.createPlayer("P1");
            ICollection<TrucoPlayer> players = new Collection<TrucoPlayer>{
                trucoPlayer,
                FakeTrucoPlayer.createPlayer("P2"),
                FakeTrucoPlayer.createPlayer("P3"),
            };
            TrucoTeam target = new TrucoTeam(players);
            bool actual = target.isPlayerFromTeam(trucoPlayer);
            Assert.AreEqual(true, actual);
        }

        [TestMethod()]
        public void IsPlayerFromTeamGivenPlayerP1InTeamT1With1MorePlayerReverseOrderThenReturnTrue()
        {
            TrucoPlayer trucoPlayer = FakeTrucoPlayer.createPlayer("P1");
            ICollection<TrucoPlayer> players = new Collection<TrucoPlayer>{
                FakeTrucoPlayer.createPlayer("P2"),
                trucoPlayer
            };
            TrucoTeam target = new TrucoTeam(players);
            bool actual = target.isPlayerFromTeam(trucoPlayer);
            Assert.AreEqual(true, actual);
        }

        [TestMethod()]
        public void IsPlayerFromTeamGivenPlayerP1InTeamT1With2MorePlayerReverseOrderThenReturnTrue()
        {
            TrucoPlayer trucoPlayer = FakeTrucoPlayer.createPlayer("P1");
            ICollection<TrucoPlayer> players = new Collection<TrucoPlayer>{
                FakeTrucoPlayer.createPlayer("P3"),
                FakeTrucoPlayer.createPlayer("P2"),
                trucoPlayer
            };
            TrucoTeam target = new TrucoTeam(players);
            bool actual = target.isPlayerFromTeam(trucoPlayer);
            Assert.AreEqual(true, actual);
        }


        [TestMethod()]
        public void IsPlayerFromTeamGivenPlayerP1NotInTeamT1With1MorePlayerThenReturnFalse()
        {
            TrucoPlayer trucoPlayer = FakeTrucoPlayer.createPlayer("P1");
            ICollection<TrucoPlayer> players = new Collection<TrucoPlayer>{
                FakeTrucoPlayer.createPlayer("P2"),
                FakeTrucoPlayer.createPlayer("P3")
            };
            TrucoTeam target = new TrucoTeam(players);
            bool actual = target.isPlayerFromTeam(trucoPlayer);
            Assert.AreEqual(true, actual);
        }

        [TestMethod()]
        public void IsPlayerFromTeamGivenPlayerP1NotInTeamT1With2MorePlayerThenReturnFalse()
        {
            TrucoPlayer trucoPlayer = FakeTrucoPlayer.createPlayer("P1");
            ICollection<TrucoPlayer> players = new Collection<TrucoPlayer>{
                FakeTrucoPlayer.createPlayer("P2"),
                FakeTrucoPlayer.createPlayer("P3"),
                FakeTrucoPlayer.createPlayer("P4")
            };
            TrucoTeam target = new TrucoTeam(players);
            bool actual = target.isPlayerFromTeam(trucoPlayer);
            Assert.AreEqual(true, actual);
        }
        #endregion
    }
}
