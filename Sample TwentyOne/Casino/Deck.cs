using System;
using System.Collections.Generic;


namespace Casino
{
    public class Deck
    {
        // List of Cards (enums)
        public List<Card> Cards { get; set; }

        // Deck Constructor
        public Deck()
        {
            this.Cards = new List<Card>();
            for (int i = 0; i < 13; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Card card = new Card();
                    card.Face = (Face)i;
                    card.Suit = (Suit)j;
                    Cards.Add(card);
                }
            }
            
        }

        public void Shuffle(int times = 3)
        {
            for (int i = 0; i < times; i++)
            {
                List<Card> TempList = new List<Card>();
                Random random = new Random();

                while (this.Cards.Count > 0)
                {
                    int randomIndex = random.Next(0, Cards.Count);
                    TempList.Add(Cards[randomIndex]);
                    Cards.RemoveAt(randomIndex);
                }
              this.Cards = TempList;
            }
            //return this;
        }
    }
    
}
