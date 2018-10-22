using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwith3Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number to have math operations performed on it.");

            int userInput = Convert.ToInt32(Console.ReadLine());
            Classwith3Methods.Class1.Method1(userInput);
            Classwith3Methods.Class1.Method2(userInput);
            Classwith3Methods.Class1.Method3(userInput);

            Console.ReadLine();
        }
    }
}