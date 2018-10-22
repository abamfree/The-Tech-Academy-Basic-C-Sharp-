using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodMath
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2.In the Main() method of the console app, instantiate the class and call the one method, passing in an integer, such as 12. Then display the result to the screen.

            ClassA addition = new ClassA();

            int result1 = addition.Method1(12);

            Console.WriteLine(result1);

            Console.ReadLine();



            //4. In the Main() method of the console app, instantiate the class and call the second method, passing in a decimal. Display the result to the screen.

            ClassA division = new ClassA();

            decimal result2 = division.Method1(.5M);

            Console.WriteLine(result2);

            Console.ReadLine();



            //6. In the Main() method of the console app, instantiate the class and call the third method, passing in a string that equates to an integer. Display the result to the screen.

            ClassA multiplication = new ClassA();

            int result3 = multiplication.Method1(10);

            Console.WriteLine(result3);

            Console.ReadLine();
        }
    }
}
