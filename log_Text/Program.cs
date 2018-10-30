using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace log_Text
{
    class Program
    {
        static void Main(string[] args)
        {


            //1. Ask a user for a number.

            Console.WriteLine("Please enter a number.");

            int userNumber = Convert.ToInt32(Console.ReadLine());


            //2. Log that number to a text file.
            using (StreamWriter file = new StreamWriter(@"C:\Users\Abraham\source\repos\log_Text\log.txt", true))
            {
                file.WriteLine(userNumber);
            }
            //3. Print the text file back to the user.

            using (StreamReader file = new StreamReader(@"C:\Users\Abraham\source\repos\log_Text\log.txt"))

            {

                string line;

                while ((line = file.ReadLine()) != null)

                {

                    Console.WriteLine("Here is the number you entered: " + line);

                }

            }

            Console.ReadLine();

        }
    }
}










   



              
