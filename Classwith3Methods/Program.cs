using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWithVoidMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. In the Main() method of the console app, instantiate the class.
           ClassA multiplication = new ClassA();
            
          //3. Call the method in the class, passing in two numbers.
            multiplication.Method1(9, 45);
            
        //4. Call the method in the class, specifying the parameters by name.

            multiplication.Method1(num03: 6, num04: 100);

            Console.ReadLine();
        }
    }
}
