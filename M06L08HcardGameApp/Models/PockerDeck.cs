using System.Collections.Generic;

namespace M06L08HcardGameApp
{
    public class PockerDeck : Deck
    {
        public PockerDeck()
        {
            CreateDeck();
            ShuffleDeck();
        }

        public override List<CardModel> DealCards()
        {
            var output = new List<CardModel>();
            for (int num = 0; num < 5; num++)
            {
                output.Add(DrawOneCard());
            }
            return output;
        }

        public List<CardModel> RequestCards(List<CardModel> cardsToDiscard){
            List<CardModel> output = new List<CardModel>();
            foreach (var card in cardsToDiscard)
            {
                output.Add(DrawOneCard());
                discardPile.Add(card);
            }
            return output;
        }


    }
}
