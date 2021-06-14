using System.Collections.Generic;

namespace M06L08HcardGameApp
{
    public class BlackJack : Deck
    {
        public BlackJack()
        {
            CreateDeck();
            ShuffleDeck();
        }

        public override List<CardModel> DealCards()
        {
            var output = new List<CardModel>();
            for (int num = 0; num < 2; num++)
            {
                output.Add(DrawOneCard());
            }
            return output;
        }


    }
}
