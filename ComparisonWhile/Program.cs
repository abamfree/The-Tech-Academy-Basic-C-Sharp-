using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparisonWhile
{
    class Program
    {
        static void Main(String[] args)
        {
            string name = "abraham";
            int i = 0;
            bool boolVariable = false;
            while (i < 5) 
            {
                Console.WriteLine("What is your name");
                string userInput = Console.ReadLine();
                if (name == userInput)
                {
                    Console.WriteLine("Congratz");
                    boolVariable = true;
                    break;
                }
                else if (name != userInput)
                {
                    Console.WriteLine("try again");
                    i = i + 1;
                }
                if (i == 3 && boolVariable == false)
                {
                    Console.WriteLine("BINGO!");
                    break;
                }
            }
            
            Console.ReadLine();
        }

    }

}






