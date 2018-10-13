using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBasicApp
{
    class Program
    {
        static void Main()
        {   
            //Total
            Console.WriteLine("Enter Anynumber");
            string num = Console.ReadLine();
            int nnum = Convert.ToInt32(num);
            int product = nnum * 50;
            Console.WriteLine(product);
            Console.WriteLine("Enter Anynumber");
            string nnnum = Console.ReadLine();
            int nnnnum = Convert.ToInt32(nnnum);
            int total = nnnnum + 25;
            Console.WriteLine(total);
           // qoutient
            Console.WriteLine("Enter any number");
            string qn = Console.ReadLine();
            double qotn = Convert.ToDouble(qn);
            double qoutient = qotn / 12.5;
            Console.WriteLine(qoutient);
            //comparison
            Console.WriteLine("check this Number");
            string number = Console.ReadLine();
            int checkNum = Convert.ToInt32(number);
            bool grater = checkNum > 50;
            Console.WriteLine(grater);
            // Remainder
            Console.WriteLine("Check this out");
            string num1 = Console.ReadLine();
            int num2 = Convert.ToInt32(num1);
            int remainder = num2 % 7;
            Console.WriteLine(remainder);
            Console.ReadLine();

        }
    }
}
