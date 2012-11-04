using System.Collections.Generic;
using NUnit.Framework;
using TechTalk.SpecFlow;
using TrucoCmd;

namespace TrucoSpecs.Features.Steps
{
    [Binding]
    public class GameInitializationSteps
    {
        private TrucoGame trucoGame;
        private List<TrucoPlayer> trucoPlayers;

        [Given(@"There are (.*) players")]
        public void GivenThereArePlayers(string numberOfPlayers)
        {
            //ScenarioContext.Current.Pending();
//            trucoPlayers = new List<TrucoPlayer>();
//            for (int i = 0; i <  int.Parse(numberOfPlayers); i++)
//            {
//                trucoPlayers.Add(new TrucoPlayer());
//            }
        }


        [When(@"Truco game starts")]
        public void WhenTrucoGameStarts()
        {
//            trucoGame = new TrucoGame(trucoPlayers.Count);
//            trucoGame.StartGame();
        }


        [Then(@"players should have their partners")]
        public void ThenPlayersShouldHaveTheirPartners()
        {
            ICollection<TrucoPlayer> partners;
            foreach (TrucoPlayer trucoPlayer in trucoPlayers)
            {
                partners = trucoPlayer.Partners;
                Assert.NotNull(partners);
            }
        }

        [Then(@"score should be reset")]
        public void ThenScoreShouldBeReset()
        {
            TrucoScore score;
            score = trucoGame.Score;
            Assert.Equals(score.TeamA, 0);
            Assert.Equals(score.TeamB, 0);
        }
    }
}