using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_struct
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. In the Main() method, create an object of data type Number and assign an amount to it.

            Number number = new Number();

            number.Amount = 503;
        //3. Print this amount to the console.

            Console.WriteLine(" Here you got an amount of\n " + number.Amount);

            Console.ReadLine();
        }
    }
}
