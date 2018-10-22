using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCombination
{
    class ClassA
    {


        public int Method1(int num01, int num02 = 0)

        {

            // 1. Create a class. In that class, create a method that takes two integers as parameters. Make one of them optional. Have the method do a math operation and return a integer result.

            int result = num01 + num02;

            return result;
        }
    }
}