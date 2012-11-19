Feature: SortDeck
	In order to sort a deck of cards
	As a dealer
	I want a deck to be sorted

@mytag
Scenario: Sort deck of cards
	Given I have a deck
	And a deck is not sorted
	When I sort the deck
	Then the deck should be sorted from A to 10m J,Q,K
