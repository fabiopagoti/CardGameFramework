using System;
using System.Collections.Generic;
using CardGameFramework.Model.Player;
using NUnit.Framework;
using TechTalk.SpecFlow;
using TrucoCmd;

namespace TrucoSpecs.Features.Steps
{
    [Binding]
    public class GameInitializationSteps
    {
        private List<TrucoPlayer> trucoPlayers;
        private TrucoGame trucoGame;

        [Given(@"There are \[(.*)] players")]
        public void GivenThereArePlayers(int numberOfPlayers)
        {
            trucoPlayers = new List<Player>();
            for (int i = 0; i < numberOfPlayers; i++)
            {
                trucoPlayers.Add(new Player());    
            }
            
        }
        
        [Given(@"Truco game is started")]
        public void GivenTrucoGameIsStarted()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"Truco game starts")]
        public void WhenTrucoGameStarts()
        {
            trucoGame = new TrucoGame(trucoPlayers.Count);
        }
        
        [When(@"a round starts")]
        public void WhenARoundStarts()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"players should have their partners")]
        public void ThenPlayersShouldHaveTheirPartners()
        {
            ICollection<TrucoPlayer> partners;
            foreach (var trucoPlayer in trucoPlayers)
            {
                partners = trucoPlayer.Partners;
                Assert.NotNull(partners);
            }
        }
        
        [Then(@"score should be reset")]
        public void ThenScoreShouldBeReset()
        {
            Score score;
            score = trucoGame.Score();
            Assert.Equals(score.TeamA, 0);
            Assert.Equals(score.TeamB, 0);
        }
    }
}
