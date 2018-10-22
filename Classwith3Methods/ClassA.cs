using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWithVoidMethod
{
    class ClassA
    {
        public void Method1(int num03, int num04)

        {

            //1. Create a class. In that class, create a void method that takes two integers as parameters.
            //Have the method do a math operation on the first integer and display the second integer to the screen.

            int product = num03 * 10;
            //Console.WriteLine(num03 + " is the First number entered.");
            Console.WriteLine(num04 + " is the second number entered.");
            Console.ReadLine();
        }
    }
}
