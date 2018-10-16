using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concatenate
{
    class Program
    {
        static void Main(string[] args)
        {   
            /* basic concatenation of strings using addition*/
            string name = "abam";
            string fname = "roe";
            string lname = "leo";
            string pname = name + fname + lname;
            Console.WriteLine(pname);

            /* Concatination of strings using different C# built in */

            string quote = "I love my laptop, \"abraham\", hey.";
            String Alex = " hello \n abraham \t C'mon please!";
            Console.WriteLine(Alex);
            Console.WriteLine(quote);

            /* UPPER CASE */

          string  plname = "PETer";
            plname = plname.ToUpper();
            Console.WriteLine(plname); 
            /*String builder*/
            StringBuilder sb = new StringBuilder();
            sb.Append("My name is Abraham \n i live in portland oregon\n born and raised mama africa\n almost 2019");
            Console.WriteLine(sb);
            Console.ReadLine();

        }
    }
}
