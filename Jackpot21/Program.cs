using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jackpot21
{
    class Program
    {
        static void Main(string[] args)
        {
            /*List<Game> games = new List<Game>();
            TwentyOneGame game = new TwentyOneGame();
            games.Add(game); 
            Game game = new TwentyOneGame(); */
            // the Above Example of Polymorphysim
            Deck deck = new Deck();
           // deck = shuffle(deck); // if wanna shuffle the card uncomment this and use the method called shuffle
            //deck = shuffle(3);  // if you you need to shuffle the Deck 3 times
            foreach (Card card in deck.cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.cards.Count);

            Console.ReadLine();
        }
        public static Deck shuffle(Deck deck)
        {
            List<Card> TempList = new List<Card>();
            Random random = new Random();
        
        while (deck.cards.Count > 0)
            {
            int randomIndex = random.Next(0, deck.cards.Count);
            TempList.Add(deck.cards[randomIndex]);
            deck.cards.RemoveAt(randomIndex);
            }
      deck.cards = TempList;
        return deck;
       }
    }
}
            
    
