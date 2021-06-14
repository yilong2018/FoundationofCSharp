using System;
using System.Collections.Generic;
using System.Linq;

namespace M06L08HcardGameApp
{
    public abstract class Deck
    {
        protected List<CardModel> fullCards = new List<CardModel>();
        protected List<CardModel> drawPile = new List<CardModel>();
        protected List<CardModel> discardCards = new List<CardModel>();
        protected void CreateDeck()
        {
            fullCards.Clear();
            for (int suit = 0; suit < 3; suit++)
            {
                for (int val = 0; val < 13; val++)
                {
                    fullCards.Add(new CardModel
                    {
                        CardSuit = (CardSuit)suit,
                        CardValue = (CardValue)val
                    });
                }
            }
        }
        protected void ShuffleDeck()
        {
            var rnd = new Random();
            drawPile = fullCards.OrderBy(c => rnd.Next()).ToList();
        }
        public abstract List<CardModel> DealCards();
        public virtual CardModel DrawOneCard()
        {
            CardModel output = new CardModel();
            output = fullCards.Take(1).First();
            fullCards.Remove(output);
            return output;
        }

    }
}
