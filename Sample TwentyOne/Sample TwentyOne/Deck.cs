using System;
using System.Collections.Generic;


namespace Sample_TwentyOne
{
    public class Deck
    {
        public Deck()
        {
            Cards = new List<Card>();
            for (int i = 0; i < 13; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Card card = new Card();
                    card.Face = (Face)j;
                    card.Suit = (Suit)i;
                    Cards.Add(card);
                }
            }
        }
            
        public List<Card> Cards { get; set; }


        public void Shuffle(int times = 1)
        {

            for (int i = 0; i < times; i++)
            {

                List<Card> TempList = new List<Card>();
                Random random = new Random();
            
            while (Cards.Count > 0)
                {
                    int randomIndex = Random.Next(0, Cards.Count);
                    TempList.Add(Cards[randomIndex]);
                    Cards.RemoveAt(randomIndex);
                }
              Cards = TempList;
                
            }

            
        }
    }
    
}
