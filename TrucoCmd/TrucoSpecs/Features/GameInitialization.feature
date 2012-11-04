Feature: GameInitialization
	In order to start a truco game
	As a truco player
	I want to have all teams ready and score reseted

@game
Scenario: StartGame
	Given There are [4|6] players
	When Truco game starts
	Then players should have their partners
	And score should be reset

@game
Scenario: StartRound
	Given Truco game is started
	When a round starts
	Then all players should have 3 cards
	And trump card should be shown for all players

