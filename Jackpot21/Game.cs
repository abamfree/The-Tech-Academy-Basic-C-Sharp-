using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jackpot21
{
    public  class Game // abstract
    {
        public List<string> players { get; set; }
        public string Name  { get; set; }
        public string Dealer { get; set; }
        //public abstract void play(); //only with abstract class and if inhertis they have to use this method
        public void Listplayers()
        {
            foreach (string player in players)
            {
                Console.WriteLine(player);
            }
        }
    }
}
