using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterationLoops
{
    class Program
    {
        static void Main()

            {

            /* 1. Create a one-dimensional Array of strings.*/
                string[] titles = { "lecturer", "Queen", "bro", "father", "sis", "boss" };
                Console.WriteLine("Enter any text.");
                string userName = Console.ReadLine();
                foreach (string title in titles)

                {

                Console.WriteLine(title + " " + userName);

                }



            Console.ReadLine();



            // 2. Create an infinite loop.



            //int i = 1;

           // while (i > 0)

           // {

               // Console.WriteLine("Oh no it's infinite!");

           // }

           // Console.ReadLine();



            // 3. Fix the infinite loop so it will execute.

            int j = 1;

            while (j > 0)

            {

                Console.WriteLine("Oh no it's infinite!");

                j--;

                Console.WriteLine("this one is gonna be finite");

            }

            Console.ReadLine();



            // 4. Create a loop where the comparison used to determine whether to continue iterating the loop is a “<” operator.

            int a = 1;

            while (a < 5)

            {

                Console.WriteLine("abraham.");

                a++;

            }

            Console.ReadLine();



            // 5. Create a loop where the comparison used to determine whether to continue iterating the loop is a “<=” operator.

            int b = 1;

            while (b <= 5)

            {

                Console.WriteLine("abraham.");

                b++;

            }

            Console.ReadLine();



            /* 6. Create a List of strings where each item in the list is unique. Ask the user to select text to search for in the List. 

                  Create a loop that iterates through the loop and then displays the index of the array that contains matching text on the screen. */



            List<string> animals = new List<string> { "Tiger", "Rhino", "Bobcat", "Bat" };



            Console.WriteLine("Enter one of the following animals: Tiger, Rhino, Bobcat, or Bat.");

            string userPick = Console.ReadLine();



            foreach (string animal in animals)

            {

                if (animal == userPick)

                {

                    Console.WriteLine(animals.IndexOf(userPick));

                }

            }

            Console.ReadLine();



            // 7. Add code to that above loop that tells a user if they put in text that isn’t in the List.



            List<string> animals1 = new List<string> { "Tiger", "Rhino", "Bobcat", "Bat" };



            Console.WriteLine("Enter one of the following animals: Tiger, Rhino, Bobcat, or Bat.");

            string userPick1 = Console.ReadLine();



            foreach (string animal1 in animals1)

            {

                if (animal1 == userPick1)

                {

                    Console.WriteLine(animals1.IndexOf(userPick1));

                }

                else Console.WriteLine("Sorry, but what you entered is not on the list.");



            }

            Console.ReadLine();



            // 8. Add code to that above loop that stops it from executing once a match has been found.

            List<string> animals2 = new List<string> { "Tiger", "Rhino", "Bobcat", "Bat" };



            Console.WriteLine("Enter one of the following animals: Tiger, Rhino, Bobcat, or Bat.");

            string userPick2 = Console.ReadLine();



            foreach (string animal2 in animals2)

            {

                if (animal2 == userPick2)

                {

                    Console.WriteLine(animals2.IndexOf(userPick2));

                    break;

                }

            }

            Console.ReadLine();



            /* 9. Create a List of strings that has at least two identical strings in the List. Ask the user to select text to search for in the List. 

                  Create a loop that iterates through the loop and then displays the indices of the array that contain matching text on the screen. */



            List<string> animals3 = new List<string> { "Bear", "Bear", "Cougar", "Eagle" };



            Console.WriteLine("Enter one of the following animals: Bear, Cougar or Eagle.");

            string userPick3 = Console.ReadLine();



            for (int c = 0; c < animals.Count; c++)

            {

                if (userPick3 == animals[c])

                {

                    Console.WriteLine("The index location is: " + animals3.IndexOf(userPick3));

                }

            }

            Console.ReadLine();



            // 10. Add code to that above loop that tells a user if they put in text that isn’t in the List.



            List<string> animals4 = new List<string> { "Bear", "Bear", "Cougar", "Eagle" };



            Console.WriteLine("Enter one of the following animals: Bear, Cougar or Eagle.");

            string userPick4 = Console.ReadLine();



            for (int d = 0; d < animals.Count; d++)

            {

                if (userPick4 == animals[d])

                {

                    Console.WriteLine("The index location is: " + animals4.IndexOf(userPick4));

                }

                else Console.WriteLine("What you entered is not on the list.");

            }

            Console.ReadLine();



            /* 11. Create a List of strings that has at least two identical strings in the List. Create a foreach loop that evaluates each item in the list, 

                    and displays a message showing the string and whether or not it has already appeared in the list. */



            List<StringBuilder> presidents = new List<StringBuilder>(); //{ "Bush", "Clinton", "Bush", "Obama" };

            presidents.Add(new StringBuilder("Bush"));

            presidents.Add(new StringBuilder("Clinton"));

            presidents.Add(new StringBuilder("Bush"));

            presidents.Add(new StringBuilder("Obama"));

            presidents.Add(new StringBuilder("Lincoln"));

            presidents.Add(new StringBuilder("Washington"));

            presidents.Add(new StringBuilder("Bush"));

            presidents.Add(new StringBuilder("Kennedy"));

            presidents.Add(new StringBuilder("Carter"));

            presidents.Add(new StringBuilder("Clinton"));



            int count = 0;



            foreach (StringBuilder president in presidents)

            {

                for (int k = 0;  k< presidents.Count(); k++)

                {

                    if (presidents.ElementAt(k).ToString().Contains(president.ToString())) count++;

                }



                if (count > 1) president.Append(" (REDUNDANT)");

                count = 0;

            }

            foreach (StringBuilder president in presidents)

            {

                Console.WriteLine(president + "\n");

            }

            Console.ReadLine();

        }

    }

}


