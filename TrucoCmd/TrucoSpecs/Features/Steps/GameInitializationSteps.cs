using System;
using System.Collections.Generic;
using CardGameFramework.Model.Player;
using TechTalk.SpecFlow;

namespace TrucoSpecs.Features.Steps
{
    [Binding]
    public class GameInitializationSteps
    {
        private List<Player> trucoPlayers;

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
            ScenarioContext.Current.Pending();
        }
        
        [When(@"a round starts")]
        public void WhenARoundStarts()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"players should have their partners")]
        public void ThenPlayersShouldHaveTheirPartners()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"score should be reset")]
        public void ThenScoreShouldBeReset()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
