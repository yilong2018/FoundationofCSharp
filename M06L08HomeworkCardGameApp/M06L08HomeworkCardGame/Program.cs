using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M06L08HomeworkCardGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Pocker pocker = new Pocker();
            var cards = pocker.DealCard();
            foreach (var card in cards)
            {
                Console.WriteLine($"{card.CardSuit} {card.CardValue}");
            }

            Console.ReadLine();
        }
    }

    public abstract class Deck
    {
        protected List<CardModel> fullDeck = new List<CardModel>();
        protected List<CardModel> drawPile = new List<CardModel>();
        protected List<CardModel> discardPile = new List<CardModel>();

        protected void CreatDeck()
        {
            fullDeck.Clear();

            for (int suit = 0; suit < 4; suit++)
            {
                for (int val = 0; val < 13; val++)
                {
                    fullDeck.Add(
                        new CardModel
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
            fullDeck = fullDeck.OrderBy(c => rnd.Next()).ToList();
        }
        public abstract List<CardModel> DealCard();
        public CardModel DrawOneCard()
        {
            var output = new CardModel();
            output = fullDeck.Take(1).First();
            fullDeck.Remove(output);
            return output;
        }
    }

    public class Pocker : Deck
    {
        public Pocker()
        {
            CreatDeck();
            ShuffleDeck();
        }
        public override List<CardModel> DealCard()
        {
            List<CardModel> output = new List<CardModel>();
            for (int num = 0; num < 5; num++)
            {
                output.Add(DrawOneCard());
            }
            return output;
        }
    }

    public class BlackJack : Deck
    {
        public BlackJack()
        {
            CreatDeck();
            ShuffleDeck();
        }
        public override List<CardModel> DealCard()
        {
            List<CardModel> output = new List<CardModel>();
            for (int i = 0; i < 2; i++)
            {
                output.Add(DrawOneCard());
            }
            return output;
        }
    }

    public class CardModel
    {
        public CardSuit CardSuit { get; set; }
        public CardValue CardValue { get; set; }
    }
    public enum CardSuit
    {
        Hearts,
        Diamonds,
        Spades,
        Clubs
    }
    public enum CardValue
    {
        Ace,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Night,
        Ten,
        Jack,
        Queen,
        King
    }
}
