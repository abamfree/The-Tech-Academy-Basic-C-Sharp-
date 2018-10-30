using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    class Program
    {
        static void Main(string[] args)
        {
            try

            {

               // 1.Ask the user for his age.


               Console.WriteLine("What is your age?");

               int userAge = Convert.ToInt32(Console.ReadLine());



                if (userAge == 0 || userAge < 0)

                {

                    throw new ArgumentOutOfRangeException();

                }



               // 2.Display the year user born.

                DateTime userBirthYear = DateTime.Now.AddYears(-userAge);
                Console.WriteLine("Dear user you were born in");

                Console.WriteLine(userBirthYear.Year);

               // Console.WriteLine(userBirthYear.ToString("yyyy")); Another option for having only the year displayed.

                Console.ReadLine();



              //  3.Exceptions must be handled using "try .. catch".



            }

            catch (ArgumentOutOfRangeException)

            {

                Console.WriteLine("0 or negative numbers are not excepted.");

                Console.ReadLine();

                return;

            }

            catch (Exception)

            {

                Console.WriteLine("Something you entered caused an error.");

                Console.ReadLine();

                return;

            }
        }
    }
}
