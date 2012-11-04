Feature: GameInitialization
	In order to start a truco game
	As a truco player
	I want to have all teams ready and score reseted

@game
Scenario: StartGame
	Given There are a players
	When Truco game starts
	Then players should have their partners
	And score should be reset
