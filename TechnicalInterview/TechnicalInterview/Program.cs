using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalInterview
{
    class Program
    {
        
      //Method for exercise 1
        public int AddOdds(Array array)
        {
            int total = 0;
            foreach (int i in array)
            {
                if (i % 2 != 0)
                {
                    total += i;
                }
            }
            return total;
        }

        //Method for exercise 2
        public double AddArray(Array array)
        {
            double total = 0;
            foreach (double i in array)
            {
                total += i;
            }
            return total;
        }

        //Method for exercise 3
        public string ReverseString(string x)
        {
            string gibberish = "";
            for (int i = x.Length - 1; i > -1; i--)
            {
                gibberish += x[i];
            }
            return gibberish;
        }

        //Method for exercise 4
        public string RemoveExtras(string x)
        {
            return new string(x.ToCharArray().Distinct().ToArray());
        }

        //Method for exercise 5
        public void FizzBuzz(int num1, int num2)
        {
            for (int i = num1; i <= num2; i++)
            {
                if (i % 3 == 0 && i % 5 == 0) Console.WriteLine("FizzBuzz");

                else if (i % 3 == 0) Console.WriteLine("Fizz");

                else if (i % 5 == 0) Console.WriteLine("Buzz");

                else Console.WriteLine(i);
            }
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            Program p = new Program();

            //1. Given an array of integers, write a method to total the odd numbers.
            int[] array1 = new int[] { 1, 2, 3, 4, 5 };
            int output1 = p.AddOdds(array1);
            Console.Write(output1);
            Console.ReadLine();

            /*2. Given an array of integers, write a method to sum the elements in the array, knowing that some of the elements may be 
                 very large integers.*/
            double[] array2 = new double[] { 1, 5000, 90000, 400000, 7000000 };
            double output2 = p.AddArray(array2);
            Console.Write(output2);
            Console.ReadLine();

            //3.Given a string, reverse it.
            string notGibberish = "Psycolgoicalorder";
            string output3 = p.ReverseString(notGibberish);
            Console.Write(output3);
            Console.ReadLine();

            //4.Given a string, remove any repeated letters. 
            string output4 = p.RemoveExtras(notGibberish);
            Console.Write(output4);
            Console.ReadLine();

            /*5.FizzBuzz. Count from 1 - 100 and every time a number is divisible by 3, call "fizz". Divisble by 5 then call "buzz". 
             Divisible by both call "fizzbuzz".*/
            p.FizzBuzz(1, 13);

        }
    }
}