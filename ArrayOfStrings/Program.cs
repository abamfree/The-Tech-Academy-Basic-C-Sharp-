using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] authors = { "Mike Gold", "Don Box", "Sundar Lal", "Neel Beniwal" };
            List<string> authorsRange = new List<string>(authors);
            Console.WriteLine("Enter any index then the value will be display On the Screen!");
            int userInput1 = Convert.ToInt32(Console.ReadLine());
            if (userInput1 > authors.Length)
            {
                Console.WriteLine("ERROR!");
            }
            ;
            for (int j = 0; j < authorsRange.Count; j++)
            {
                if (j == userInput1)
                {
                    Console.WriteLine(authorsRange[j]);
                }
            }
            // Console.ReadLine();
            /* Array Of Strings **/
            string[] nameArray = { "abraham", "johanna", "danait", "hellen", "henok", "shashawi", "alex" };
            Console.WriteLine("Enter any index then the value will be display On the Screen!");
            int userInput2 = Convert.ToInt32(Console.ReadLine());
            if (userInput2 > nameArray.Length)
            {
                Console.WriteLine("ERROR!");
            }
            ;
            for (int k = 0; k < nameArray.Length; k++)
            {
                if (k == userInput2)
                {
                    Console.WriteLine(nameArray[userInput2]);
                }

            }

            /*Array Of Integers */

            int[] numArray = { 5, 55, 23, 100, 123, 234, 1, 6, 8, 9 };
            Console.WriteLine("Enter any index then the value will be display On the Screen!");
            int userInput = Convert.ToInt32(Console.ReadLine());
            if (userInput > numArray.Length)
            {
                Console.WriteLine("ERROR!");
            };
            for (int i = 0; i < numArray.Length; i++)
            {
                if (i == userInput)
                {
                    Console.WriteLine(numArray[userInput]);
                }

            }


            Console.ReadLine();
        }
    }
}
