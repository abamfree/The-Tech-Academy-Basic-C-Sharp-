using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jackpot21
{
    public class Deck
    {
       
        public Deck()
        {
            cards = new List<Card>(); //refering to the property of the class
            List<string> Suits = new List<string>() { "clubs", "Diamonds", "hearts", "Spades" };
            List<string> Faces = new List<string>()
            { "ace", "Two", "Three", "Four", "Five", "six", "seven",
                "eight", "nine", "Ten", "Jack", "Queen", "King" };
            foreach (string face in Faces)
            {
                foreach (string suit in Suits)
                {
                    Card card = new Card();
                    card.Suit = suit;
                    card.Face = face;
                    cards.Add(card);
                }
            }
        }
        public List<Card> cards { get; set; }
    }
}