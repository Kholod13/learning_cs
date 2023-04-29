using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static cs_collections.CardDeck;

namespace cs_collections
{
    public class CardDeck
    {
        public enum Suit { Hearts, Deamods, Clubs, Spades }
        public enum Rank { Ace, Six, Seven, Eight, Nine, Ten, Jack, Queen, King }

        public struct Cards
        {
            public Suit Suit;
            public Rank Rank;
            
            public Cards(Suit s, Rank r)
            {
                Suit= s;
                Rank= r;
            }
        }

        private Queue<Cards> deck;

        public CardDeck()
        {
            deck = new Queue<Cards>();

            foreach (Suit s in Enum.GetValues(typeof(Suit)))
            {
                foreach (Rank r in Enum.GetValues(typeof(Rank)))
                {
                    deck.Enqueue(new Cards(s, r));
                }
            }

        }

        public Cards DrawCard()
        {
            if (deck.Count == 0)
            {
                throw new InvalidOperationException("Deck is empty!");
            }
            return deck.Dequeue();
        }

        public List<Cards> DistributionSixCards()
        {
            List<Cards> dCards = new List<Cards>();

            for (int i = 0; i < 6; i++)
            {
                if (deck.Count == 0)
                {
                    throw new InvalidOperationException("Deck is empty!");
                }

                dCards.Add(deck.Dequeue());
            }

            return dCards;
        }

        public void Shuffle()
        {
            List<Cards> shuffledDeck = new List<Cards>(deck);

            Random rand = new Random();

            int i = shuffledDeck.Count;
            while (i > 1)
            {
                i--;
                int a = rand.Next(i + 1);
                Cards temp = shuffledDeck[a];
                shuffledDeck[a] = shuffledDeck[i];
                shuffledDeck[i] = temp;
            }

            deck = new Queue<Cards>(shuffledDeck);
        }

        public void ShowDeck()
        {
            Console.WriteLine("Deck: ");
            
            int i = 1;

            foreach (Cards card in deck)
            {
                Console.WriteLine($"#{i} {card.Rank} of {card.Suit}");
                i++;
            }
        }
    }
}
