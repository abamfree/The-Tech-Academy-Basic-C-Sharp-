using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCombination
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2. In the Main() method of the console app, instantiate the class.

            ClassA addition = new ClassA();



            //3. Ask the user to input two numbers, one at a time. Let them know they need not enter anything for the second number.

            Console.WriteLine("Please enter a number.");

            int userNum1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("If you would like, please enter in another number.");

            string userNum2 = Console.ReadLine();



            //4. Call the method in the class, passing in the one or two numbers entered.

            if (userNum2 == "")

            {

                int result1 = addition.Method1(userNum1);

                Console.WriteLine(userNum1 + " + 0 = " + result1);

                Console.ReadLine();

            }

            else

            {

                int userNumber2 = Convert.ToInt32(userNum2);

                int result2 = addition.Method1(userNum1, userNumber2);

                Console.WriteLine(userNum1 + " + " + userNumber2 + " = " + result2);

                Console.ReadLine();

            }
        }
    }
}
