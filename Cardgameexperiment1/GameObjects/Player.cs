using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cardgameexperiment1.GameObjects
{

        public class Player
    {
        public string Name { get; set; }
        public Queue<Card> Hand { get; set; }

        public Player(string Name)
        {
            this.Name = Name;
        }

        public Queue<Card> Deal(Queue<Card> cards)
        {
            //adding two decks as an example. Not very dynamic, could be done better.
            Queue<Card> p1hand = new Queue<Card>();
            Queue<Card> p2hand = new Queue<Card>();

            while (cards.Any())
            {
                if(p1hand.Count < 26)
                {
                    p1hand.Enqueue(cards.Dequeue());
                }
                else
                {
                    p2hand.Enqueue(cards.Dequeue());
                }
            }
            Hand = p1hand;
            return p2hand;
        }
    }
}
