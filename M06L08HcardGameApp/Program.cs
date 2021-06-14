using System;
using System.Text;

namespace M06L08HcardGameApp
{
    class Program
    {
        static void Main(string[] args)
        {
            PockerDeck pocker = new PockerDeck();
            var dealCards = pocker.DealCards();
            foreach (var card in dealCards)
            {
                System.Console.WriteLine($"{card.CardValue} of {card.CardSuit}");
            }

            Console.ReadLine();
        }
    }
}
