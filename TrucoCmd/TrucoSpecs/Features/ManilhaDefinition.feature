Feature: ManilhaDefinition
	In order to determine the manilha of the turn
	As a truco player
	I want to be given the trump card and as a consequence discover the joker

@joker
Scenario Outline: Define manilha suit
	Given the turn is about to start
	When I show trump card <turn card>
	Then zap suit should be <zap>
	And copas suit should be <copas>
	And espadilha suit should be <espadilha>
	And pica-fumo suit should be <pica-fumo>
	Examples: 
	| trump card | zap		|	copas	| espadilha | pica-fumo |
	| 4          | Clubs    |  Hearts	| Spades	| Diamonds  |
	| 5          | Clubs    |  Hearts	| Spades	| Diamonds  |
	| 6          | Clubs    |  Hearts	| Spades	| Diamonds  |
	| 7          | Clubs    |  Hearts	| Spades	| Diamonds  |
	| Q          | Clubs    |  Hearts	| Spades	| Diamonds  |
	| J          | Clubs    |  Hearts	| Spades	| Diamonds  |
	| K          | Clubs    |  Hearts	| Spades	| Diamonds  |
	| A          | Clubs    |  Hearts	| Spades	| Diamonds  |
	| 2          | Clubs    |  Hearts	| Spades	| Diamonds  |
	| 3          | Clubs    |  Hearts	| Spades	| Diamonds  |


#Scenario Outline: Define joker face value
