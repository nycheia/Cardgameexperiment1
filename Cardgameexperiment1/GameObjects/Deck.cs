using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cardgameexperiment1.GameObjects
{
    public static class Deck
    {
        public static Queue<Card> CreateDeck()
        {
            Queue<Card> cards = new Queue<Card>();
            for(int i=2; 1<=14; i++)
            {
                foreach(Suit suit in Enum.GetValues(typeof(Suit))){
                    cards.Enqueue(new Card()
                    {
                        Suit = suit,
                        Value = i,
                        //GetName
                    });
                }
            }
            //return cards shuffled around
        }

        //Using the Fisher-Yates shuffle algorithm. Modified by Matthew Jones. 
        private static Queue<Card> ShuffleDeck(Queue<Card> cards)
        {
            //Shuffling the cards using Fisher-Yates
            List<Card> tCards = cards.ToList();
            Random r = new Random(DateTime.Now.Millisecond);
            for(int c = tCards.Count - 1; c > 0; --c)
            {
                //Pick an unshuffled card at random
                int u = r.Next(c + 1);

                //Swap the unshuffled card with the last unshuffled card in the list
                Card t = tCards[c];
                tCards[c] = tCards[u];
                tCards[u] = t;
            }
            Queue<Card> shuffledCards = new Queue<Card>();
            foreach(var card in tCards)
            {
                shuffledCards.Enqueue(card);
            }
            return shuffledCards;
        }
    }
}
