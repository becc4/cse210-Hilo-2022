﻿using System;
using System.Collections.Generic;


namespace Unit03.Game
{
    ///Card is for drawing the first card from the deck
    public class Card
    {
    public Card() {}
        public int cardnum = 0;

        public void Draw()
        {
            Random rnd = new Random();
            cardnum = rnd.Next(1,13);
        }
    }
}