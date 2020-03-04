using System;
using System.Collections.Generic;
using System.Text;
using Cardgameexperiment1.GameObjects;
namespace Cardgameexperiment1
{
    public static class QueueExtension
    {
        public static void Enqueue(this Queue<Card> cards, Queue<Card> newCards)
        {
            foreach(var card in newCards)
            {
                cards.Enqueue(card);
            }

        }
    }
}
