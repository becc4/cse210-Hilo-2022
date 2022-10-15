using System;
using System.Collections.Generic;


namespace Unit03.Game
{
    public class Director
    {
        //Attributes
        bool _answercorrect = true;
        string _userChoice = "";
        bool _isPlaying = true;
        //int _cardOne = 0;
        //int _cardTwo = 0;
        Card _cardOne = new Card();
        Card _cardTwo = new Card();
        int points = 300;

        public void StartGame()
        {
            while (_isPlaying)
            {
                GetInputs();
                DoUpdates();
                DoOutputs();
            }
        }
        private void GetInputs() 
        {
            //Card _cardOne = new Card();
            //Card _cardTwo = new Card();
            _cardOne.Draw();
            _cardTwo.Draw(); 

            Console.WriteLine($"The card is: {_cardOne.cardnum}");
            Console.Write("Higher or lower? [h/l] ");
            _userChoice = Console.ReadLine();
        }
        private void DoUpdates()
        {
            if (_cardOne.cardnum > _cardTwo.cardnum && _userChoice == "l") {
                _answercorrect = true;
            } else if (_cardOne.cardnum < _cardTwo.cardnum && _userChoice == "h") {
                _answercorrect = true;
            } else {
                _answercorrect = false;
            }

            if (_answercorrect) {
                points += 100;
            } else {
                points -= 75;
            }
        }
        private void DoOutputs()
        {
            Console.WriteLine($"The card is: {_cardTwo.cardnum}");
            Console.WriteLine($"Your score is: {points}");
            Console.Write("Play again? [y/n] ");
            string userplaying = Console.ReadLine();

            if (userplaying == "n") {
                _isPlaying = false;
            } else if (userplaying == "y") {
                _isPlaying = true;
            }
        }
    }
}