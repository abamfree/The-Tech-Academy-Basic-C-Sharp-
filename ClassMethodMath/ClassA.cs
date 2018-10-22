using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodMath
{
    class ClassA
    {
        // 1. Create a class. In that class, create a method that will take in an integer, do a math operation to it and then return the answer as an integer.

        public int Method1(int num01)

        {

            int result = num01 + 20;

            return result;

        }



        //3. Add a second method to the class, with the same name, that will take in a decimal, do a different math operation to it and then return the answer as an integer.

        public decimal Method1(decimal num01)

        {

            decimal result = num01 / 10;

            return result;

        }



        //5. Add a third method to the class, with the same name, that will take in a string, convert it to an integer if possible, do a different math operation to it and then return the answer as an integer.

        public int Method1(string num01)

        {

            int result = Convert.ToInt32(num01);

            result = result * 5;

            return result;
        }
    }
}
