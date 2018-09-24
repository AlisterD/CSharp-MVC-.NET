using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            int timesShuffle = 0;
            deck = Shuffle(deck, out timesShuffle, 3);
            

            foreach( Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();
            Console.WriteLine("Times shuffle {0}", timesShuffle);

        }

        public static Deck Shuffle(Deck deck,out int timesShuffle,  int times = 1)
        {
            timesShuffle = 0;

            for (int i = 0; i < times ; i++)
            {
                timesShuffle++;
                List<Card> TempList = new List<Card>();
                Random random = new Random();
            }
            

            while (deck.Cards.Count > 0)
            {
                int randomIndex = random.Next(0, deck.Cards.Count);
                TempList.Add(deck.Cards[randomIndex]);
                deck.Cards.RemoveAt(randomIndex);
            }
            deck.Cards = TempList;
            return deck;

        }



    }

}
