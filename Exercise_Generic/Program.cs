using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            //3. Instantiate an Employee object with type "string" as its generic parameter. 
            //Assign a list of strings as the property value of Things.

            Employee<string> EmployeeString = new Employee<string>();

            EmployeeString.Things = new List<string>();

            EmployeeString.Things.Add("xxx");

            EmployeeString.Things.Add("yyy");

            EmployeeString.Things.Add("zzz");



            //4. Instantiate an Employee object with type "int" as its generic parameter. Assign a list of integers as the property value of Things.

            Employee<int> EmployeeInt = new Employee<int>();

            EmployeeInt.Things = new List<int>();

            EmployeeInt.Things.Add(5);

            EmployeeInt.Things.Add(6);

            EmployeeInt.Things.Add(7);



            //5. Create a loop that prints all of the Things to the Console.

            foreach (string thing in EmployeeString.Things)

            {

                Console.WriteLine(thing);



            }



            foreach (int thing in EmployeeInt.Things)

            {

                Console.WriteLine(thing);

            }



            Console.ReadLine();









                   }
    }
}
