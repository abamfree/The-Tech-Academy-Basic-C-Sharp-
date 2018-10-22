using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassOverloadStatic
{
    class Class1
    {
        public void Method1(int num01)

        {

            //1. Create a class. In that class, create a void method that outputs an integer. Have the method divide the data passed to it by 2.

            int num02 = num01 / 2;

            Console.WriteLine("What is half of " + num01 + "? " + num02);

            Console.ReadLine();

        }



        //4. Create a method with output parameters.

        public void Method2(out int num01, out int num02)

        {

            Console.WriteLine("Enter a number.");

            num01 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter another number.");

            num02 = Convert.ToInt32(Console.ReadLine());

        }



        //5. Overload a method.

        public void Method2(out int num01, out int num02, out int num03)

        {

            Console.WriteLine("Enter a number.");

            num01 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter another number.");

            num02 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter another number.");

            num03 = Convert.ToInt32(Console.ReadLine());

        }

    }

}
    