using System.Collections.Generic;
using CardGameFramework.Model.Card;
using CardGameFramework.Model.Deck;
using CardGameFramework.Model.Player;
using NUnit.Framework;
using TechTalk.SpecFlow;
using TrucoCmd;

namespace TrucoSpecs.Features.Steps
{
    [Binding]
    public class CardsDistributionSteps
    {
        private IDeck deck;
        private Dealer dealer;
        private List<TrucoPlayer> trucoPlayers;
        private Card trump;

        #region Given

        [Given(@"I have a deck of truco cards")]
        public void GivenIHaveADeckOfTrucoCards()
        {
            deck = new Deck();
        }

        [Given(@"all players have (.*) cards")]
        public void GivenAllPlayersHaveCards(int p0)
        {

            ScenarioContext.Current.Pending(); 
//            dealer = new Dealer();
//            dealer.DistributeCards(new TrucoGame(), deck, trucoPlayers);
        }


        #endregion

        #region When

        [When(@"I distribute cards to each player")]
        public void WhenIDistributeCardsToEachPlayer()
        {
//            Dealer dealer = new Dealer();
//            trucoPlayers = new List<TrucoPlayer>();
//            dealer.DistributeCards(new TrucoGame(), deck, trucoPlayers);
        }

        [When(@"I show trump card")]
        public void WhenIShowTurnCar()
        {
            ScenarioContext.Current.Pending();
//            trump = dealer.showTrumpCard(deck);
        }

        [When(@"I finish shuffling the deck")]
        public void WhenIFinishShufflingTheDeck()
        {
            ScenarioContext.Current.Pending();
        }

        #endregion

        #region Then

        [Then(@"all players should have (.*) cards")]
        public void ThenAllPlayersShouldHaveCards(int numberOfCards)
        {
            ScenarioContext.Current.Pending();
//            Assert.AreEqual(Player.numberOfCardsWithEachPlayer(trucoPlayers), numberOfCards);
        }

        [Then(@"trump card should be shown for all players")]
        public void ThenOneCardShouldBeShownForAllPlayers()
        {
            ScenarioContext.Current.Pending();
            deck = new Deck();
//            Assert.IsTrue(deck.isCardVisible(trump));
        }

        [Then(@"Foot play should slice it")]
        public void ThenFootPlayShouldSliceIt()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"determ if card distribution is up or down")]
        public void ThenDetermIfCardDistributionIsUpOrDown()
        {
            ScenarioContext.Current.Pending();
        }

        #endregion
    }
}