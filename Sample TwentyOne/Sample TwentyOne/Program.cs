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
            TwentyOne game = new TwentyOne();
            game.Players = new List<string>() { "jesse", "doe", "Bill" };
            Deck deck = new Deck();
            deck.Shuffle(3);

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();



        }



   
    }

}
