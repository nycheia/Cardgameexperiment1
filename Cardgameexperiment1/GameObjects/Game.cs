using System;
using System.Collections.Generic;
using System.Text;

namespace Cardgameexperiment1.GameObjects
{
    public class Game
    {
        private int TurnCounter;
        //List of players.

        public Game()
        {
            Player p1 = new Player("John");
            Player p2 = new Player("xXgameR");

            //Using our create method to return a shuffled deck
            var cards = Deck.CreateDeck();

            var hand = p1.Deal(cards);
            p2.Hand = hand;
        }

        public bool EndCondition()
        {
            //Can do a switch or an if else statement
            //e.g. turncount > 50 return true;
            return false;
        }
    }
}
