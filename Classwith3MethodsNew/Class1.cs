using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwith3MethodsNew
{
    class Class1
    {
        public int Method1(int num01)

        {
            int result = num01 + 20;
            //Console.WriteLine("Your number was added to 10 resulting in: " + (num01 + 10));
            return result;
        }

        public int Method2(int num01)

        {
            int result = num01 * 10;
            return result;

            //Console.WriteLine("Your number was multiplied by 10 resulting in: " + num01 * 10);

        }

        public decimal Method3(decimal num01)

        {
            decimal result = num01 / 10;
            return result;

            // Console.WriteLine("Your number was divided by 10 resulting in: " + num01 / 10);

        }

    }

}
  
 
