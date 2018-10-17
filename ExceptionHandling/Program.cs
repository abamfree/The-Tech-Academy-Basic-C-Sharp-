using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            /*creating a List Of Integers*/
            List<int> numberLists = new List<int>() { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
            /*Ask the user for a number to divide each number in the list by.*/
            Console.WriteLine("Enter a number to divide a list of numbers by ...");
            int numberTwo = Convert.ToInt32(Console.ReadLine());
            /*Write a loop that takes each integer in the list, divides
                it by the number the user entered, and displays the result to the screen.*/
            for (int i = 0; i < numberLists.Count; i++)
            {
                int numberThree = numberLists[i] / 5;
                 Console.WriteLine(numberLists[i] + " divided by " + numberTwo + " equals " + numberThree);
            }
            Console.ReadLine();
            /* Exception Handling */
            try

            {

                Console.Write("Divide 10 by ");

                int num = int.Parse(Console.ReadLine());



                Console.WriteLine("10/ {0} = {1}", num, (10 / num));

            }

            //ex = extra information

            catch (DivideByZeroException ex)

            {

                Console.WriteLine("CANNOT DIVIDE BY ZERO");

                //get error type

                Console.WriteLine(ex.GetType().Name);

                //get error message

                Console.WriteLine(ex.Message);

                throw new InvalidOperationException("OPERATION FAILED", ex);

            }
            catch(FormatException ex)
            {
                Console.WriteLine(" Oops, Wrong Data Type!");
                return;
            }

            catch (Exception ex)

            {

                Console.WriteLine(ex.GetType().Name);

                Console.WriteLine(ex.Message);

            }

            finally
            {
                Console.ReadLine();
            }
        }
    }
}
