using System;
using System.Collections.Generic;

namespace deck_of_cards
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck pokerDeck = new Deck();
            Player dustin = new Player("Dustin");

            pokerDeck.Shuffle(pokerDeck.Cards);
            
            dustin.Draw(pokerDeck);
            dustin.Draw(pokerDeck);
            dustin.Draw(pokerDeck);
            dustin.Draw(pokerDeck);
            dustin.Draw(pokerDeck);

            dustin.Discard(3);
        }
    }

    class Card
    {
        public string StringVal {get;}
        public string Suit {get;}
        public int Val {get;}

        public Card(string stringVal, string suit, int val)
        {
            StringVal = stringVal;
            Suit = suit;
            Val = val;
        }
    }

    class Deck 
    {
        public List<Card> Cards {get;}

        public Deck()
        {
            Cards = new List<Card>()
            {
                new Card("Ace", "Hearts", 1),
                new Card("Two", "Hearts", 2),
                new Card("Three", "Hearts", 3),
                new Card("Four", "Hearts", 4),
                new Card("Five", "Hearts", 5),
                new Card("Six", "Hearts", 6),
                new Card("Seven", "Hearts", 7),
                new Card("Eight", "Hearts", 8),
                new Card("Nine", "Hearts", 9),
                new Card("Ten", "Hearts", 10),
                new Card("Jack", "Hearts", 11),
                new Card("Queen", "Hearts", 12),
                new Card("King", "Hearts", 13),

                new Card("Ace", "Clubs", 1),
                new Card("Two", "Clubs", 2),
                new Card("Three", "Clubs", 3),
                new Card("Four", "Clubs", 4),
                new Card("Five", "Clubs", 5),
                new Card("Six", "Clubs", 6),
                new Card("Seven", "Clubs", 7),
                new Card("Eight", "Clubs", 8),
                new Card("Nine", "Clubs", 9),
                new Card("Ten", "Clubs", 10),
                new Card("Jack", "Clubs", 11),
                new Card("Queen", "Clubs", 12),
                new Card("King", "Clubs", 13),

                new Card("Ace", "Diamonds", 1),
                new Card("Two", "Diamonds", 2),
                new Card("Three", "Diamonds", 3),
                new Card("Four", "Diamonds", 4),
                new Card("Five", "Diamonds", 5),
                new Card("Six", "Diamonds", 6),
                new Card("Seven", "Diamonds", 7),
                new Card("Eight", "Diamonds", 8),
                new Card("Nine", "Diamonds", 9),
                new Card("Ten", "Diamonds", 10),
                new Card("Jack", "Diamonds", 11),
                new Card("Queen", "Diamonds", 12),
                new Card("King", "Diamonds", 13),

                new Card("Ace", "Spades", 1),
                new Card("Two", "Spades", 2),
                new Card("Three", "Spades", 3),
                new Card("Four", "Spades", 4),
                new Card("Five", "Spades", 5),
                new Card("Six", "Spades", 6),
                new Card("Seven", "Spades", 7),
                new Card("Eight", "Spades", 8),
                new Card("Nine", "Spades", 9),
                new Card("Ten", "Spades", 10),
                new Card("Jack", "Spades", 11),
                new Card("Queen", "Spades", 12),
                new Card("King", "Spades", 13),
            };
        }

        public Card Deal()
        {
            Card card = Cards[0];
            Cards.Remove(card);
            return card;
        }

        public void Reset()
        {
            new Deck();
        }

        private Random rng = new Random();
        public void Shuffle<Temp>(List<Temp> cards) 
        {
            int n = cards.Count;
            while (n > 1) {
                n--;
                int k = rng.Next(n + 1);
                Temp card = cards[k];
                cards[k] = cards[n];
                cards[n] = card;
            }
        }
    }

    class Player
    {
        public string Name {get;}
        public List<Card> Hand {get;}

        public Player(string name)
        {
            Name = name;
            Hand = new List<Card>();
        }

        public Card Draw(Deck deck)
        {
            Card card = deck.Deal();
            Hand.Add(card);
            return card;
        }

        public Card Discard(int index) 
        {
            if (index < Hand.Count) {
                Card discardedCard = Hand[index];
                Hand.Remove(discardedCard);
                return discardedCard;
            }
            return null;
        }
    }
}
