using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Const_Var
{
    class Program
    {
        static void Main(string[] args)
        { 

            //1. Create a const variable

            // const string firstName = "Abraham";

        private const string productName = "Visual C#";

        //2.Create a variable using the keyword "var".

        // var myString = "foo";
        Console.WriteLine("Please enter your name.");

            string name = Console.ReadLine();

        Console.WriteLine("Please enter your favorite number.");

            int number = Convert.ToInt32(Console.ReadLine());

        FavoriteNumber object1 = new FavoriteNumber(name, number);

        FavoriteNumber object2 = new FavoriteNumber(name);

        Console.WriteLine(object1.userName +" is the name " + object1.userNumber + " is the number");

            Console.WriteLine(object2.userName + " is the same name " + object2.userNumber + " is the other number");

            Console.ReadLine();

        }

}




       