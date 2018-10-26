using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_DateTime
{
    class Program
    {
        static void Main(string[] args)
        {
          

                //1.Prints the current date and time to the console.

                DateTime currentDateTime = DateTime.Now;

                Console.WriteLine(currentDateTime);



                //2.Asks the user for a number.

                Console.WriteLine("Please enter in a number");

                double userNumber = Convert.ToDouble(Console.ReadLine());





                //3.Prints to the console the exact time it will be in X hours, X being the number the user entered in step 2.



      Console.WriteLine("The time will be {0} after adding {1} as number of hours.", currentDateTime.AddHours(userNumber), userNumber);

                Console.ReadLine();

            }
        }
    }

