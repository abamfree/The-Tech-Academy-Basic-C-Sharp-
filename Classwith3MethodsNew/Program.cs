using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwith3MethodsNew
{
    class Program
    {
      
            static void Main(string[] args)
            {
                Class1 addition = new Class1();
                Console.WriteLine("Please enter a number to have math operations performed on it.");
                int num1 = Convert.ToInt32(Console.ReadLine());
                int result = addition.Method1(num1);
                Console.WriteLine(result);
                //Console.ReadLine();

            Class1 multiplication = new Class1();
            Console.WriteLine("Please enter a number to have math operations performed on it.");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int result2 = multiplication.Method2(num2);
            Console.WriteLine(result2);
            // Console.ReadLine();

            Class1 division = new Class1();
            Console.WriteLine("Please enter a number to have math operations performed on it.");
            decimal num3 = Convert.ToDecimal(Console.ReadLine());
            decimal result3 = division.Method3(num3);
            Console.WriteLine(result3);
            Console.ReadLine();




        }
    }
}
