using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparison
{
    class Program
    {
        static void Main()
        {

          
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person1");
            Console.WriteLine("Hourly Rate");
            string num1 = Console.ReadLine();
            byte nnum1 = Convert.ToByte(num1);
            Console.WriteLine("Hours worked per week?");
            string hhrsPerWeek1 = Console.ReadLine();
            byte hrsPerWeek1 = Convert.ToByte(hhrsPerWeek1);
            Console.WriteLine("Person2");
           Console.WriteLine("Hourly Rate2");
            string num2 = Console.ReadLine();
            byte nnum2 = Convert.ToByte(num2);
            Console.WriteLine("Hours worked per week?");
            string hhrsPerWeek2 = Console.ReadLine();
            byte hrsPerWeek2 = Convert.ToByte(hhrsPerWeek2);
           Console.WriteLine("Annual salary of person 1");
          // string salaryPerson1 = Console.ReadLine();
          //int salaryPerson11 = Convert.ToInt32(salaryPerson1);
           int salaryPerson1 = nnum1 * hrsPerWeek1 * 52 ;
          Console.WriteLine(salaryPerson1);
          Console.WriteLine("Annual salary of person 2");
          //  string salryPerson2 = Console.ReadLine();
          int salaryPerson2 = nnum2 * hrsPerWeek2 * 52;
            Console.WriteLine(salaryPerson2);
           Console.WriteLine("Does Person 1 make more money than Person 2");
           // string number = Console.ReadLine();
            //int checkSalary = Convert.ToInt32(number);
            bool grater = salaryPerson1 > salaryPerson2;
            Console.WriteLine(grater);
            Console.ReadLine();
        }
    }
}
