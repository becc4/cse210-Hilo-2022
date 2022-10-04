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
        int _cardOne = 0;
        int _cardTwo = 0;

        public void StartGame()
        {
            while (_isPlaying)
            {
                GetInputs();
                DoUpdates();
                DoOutputs();
            }
        }
        public void GetInput() 
        {
            Card _cardOne = new Card();
            Card _cardTwo = new Card();

            Console.Write($"The card is: {_cardOne}");
            Console.Write("Higher or lower? [h/l] ");
            _userChoice = Console.ReadLine();
        }
        public void GetUpdate()
        {
            if (_cardOne > _cardTwo) && (_userChoice = "l") {
                _answercorrect = true;
            }
        }
        public void DoOutput()
        {

        }
    }
}