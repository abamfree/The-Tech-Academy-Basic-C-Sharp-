using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileBoolean
{
    class Program
    {
        static void Main(string[] args)
        {  
            string name = "abraham";
            int i = 0;
            bool boolVariable = false;
            do
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
               if (i ==3 && boolVariable == false)
                {
                    Console.WriteLine("BINGO!");
                    break;
                }
            }
            while (i < 5);
            Console.ReadLine();
        } 

            
    }
    }

