@dealer
Feature: CardsDistribution
	In order to play Truco
	As a player
	I want to be able to distribute the right number of cards for each player before each round

Scenario: Distribute 3 cards to each layer
	Given I have a deck of truco cards
	When I distribute cards to each player
	Then all players should have 3 cards

Scenario: Show trump card
	Given all players have 3 cards
	When I show trump card
	Then trump card should be shown for all players

@cut
Scenario: Give deck to foot cut
	Given it is my time to distribute cards
	When I finish shuffling the deck
	Then Foot play should slice it
	And determ if card distribution is up or down


