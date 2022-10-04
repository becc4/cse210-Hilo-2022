# cse210-Hilo-2022
Unit 2 cse210, Fall 2022

Specifications: 
    - The player starts the game with 300 points.
    - Individual cards are represented as a number from 1 to 13.
    - The current card is displayed.
    - The player guesses if the next one will be higher or lower.
    - The the next card is displayed.
    - The player earns 100 points if they guessed correctly.
    - The player loses 75 points if they guessed incorrectly.
    - If a player reaches 0 points the game is over.
    - If a player has more than 0 points they decide if they want to keep     - playing.
    - If a player decides not to play again the game is over.

Project Structure - Classes
    Program - Entry Point, calls Director
    Director 
        Attributes:
        - _cardOne int = first instance of Card.Card
        - _cardTwo int = second instance of Card.Card
        - _Score int = player points (starts as 300)
        - ContinuePlaying Bool =  player playing (starts as true)
        Methods:
        - Public Input()
        - Public Update()
        - Public Output()
    Card (public)
        Attributes:
        - _card (will be number from 1-13)
        Methods:
        - Randomizes card number (1-13)