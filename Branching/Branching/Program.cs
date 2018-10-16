using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Please enter the package weight:");
            string pwt = Console.ReadLine();
            double pwt1 = Convert.ToDouble(pwt);
            if (pwt1 > 50)
            {
                Console.WriteLine("ERROR, + “Package too heavy to be shipped via Package Express. Have a good day.");
              }
            else
            {
                Console.WriteLine("Please follow the instructions");
            }
            Console.WriteLine("Please enter the package width:");
            string pwd = Console.ReadLine();
            double pwd1 = Convert.ToDouble(pwd);
            Console.WriteLine("Please enter the package height:");
            string pht = Console.ReadLine();
            double pht1 = Convert.ToDouble(pht);
            Console.WriteLine("Please enter the package length:");
            string pl = Console.ReadLine();
            double pl1 = Convert.ToDouble(pl);
            string sum = pwd1 + pht1 + pl;
            double sum1 = Convert.ToDouble(sum);
            if (sum1 > 50)
            {
                Console.WriteLine("ERROR," + "Package too big to be shipped via Package Expres.");
            }
            else
            {
                Console.WriteLine("Your Qoute is gonna be");
                double result = (sum1 * pwt1) / 100; 
                string result1 = String.Format("Order Total: {0:C}", result);
                Console.WriteLine(result1);
                Console.WriteLine("THANK YOU FOR SHIPPING WITH US!");
               
            }
              Console.ReadLine();
        }
    }
}
