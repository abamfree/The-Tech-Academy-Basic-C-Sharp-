using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_enum
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. Prompt the user to enter the current day of the week.

            Console.WriteLine("Please enter the day of the week.");



            //3. Assign the value to a variable of that enum data type you just created.

            string userInput = Console.ReadLine();



            //4. Wrap the above statement in a try/catch block and have it print "Please enter an actual day of the week." to the console if an error occurs.

            try

            {

                Days daysDays = new Days();

                DayOfWeek day = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), userInput);



                if (day == DayOfWeek.Monday || day == DayOfWeek.Tuesday || day == DayOfWeek.Wednesday || day == DayOfWeek.Thursday || day == DayOfWeek.Friday || day == DayOfWeek.Saturday || day == DayOfWeek.Sunday)

                {

                    Console.WriteLine("That is a day of the week");

                    Console.ReadLine();

                }

            }

            catch

            {

                Console.WriteLine("Please enter an actual day of the week.");

                Console.ReadLine();

            }
        }
    }
}
