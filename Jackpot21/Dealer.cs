using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jackpot21
{
    public class Dealer
    {
        public string Name { get; set; }
        public Deck Deck { get; set; }
        public int Balance { get; set; }
        public void Deal (List<Card> Hand)
        {
            Hand.Add(Deck.cards.First());
            Console.WriteLine(Deck.cards.First().ToString() + "\n");
            Deck.cards.RemoveAt(0);
        }
    }
}
