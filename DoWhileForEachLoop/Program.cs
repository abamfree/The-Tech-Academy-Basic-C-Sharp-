using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileForEachLoop
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int k = 0;

                //WHILE LOOP

                while (k < 10)

                {

                    if (k == 7)

                    {

                        k++;

                        continue;

                    }



                    if (k == 9)

                    {

                        break;

                    }



                    if ((k % 2 > 0))

                    {

                        Console.WriteLine(k);

                    }

                    k++;

                }



                string guess;

                //DO-WHILE LOOP

                do

                {

                    Console.WriteLine("GUESS A NUMBER: ");

                   guess = Console.ReadLine();



                } while (!guess.Equals("15"));



                //FOR LOOP

                for (int i = 0; i < 10; i++)

                {

                    if ((i % 2) > 0)

                    {

                        Console.WriteLine(i);

                    }

                }



                //FOREACH LOOP

                string randStr = "This is a string.";



                foreach (char c in randStr)

                {

                    Console.WriteLine(c);

                }

            }

        }

    }
