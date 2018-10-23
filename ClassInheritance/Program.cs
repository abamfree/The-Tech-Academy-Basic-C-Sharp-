using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // 4. Inside of the Main method, instantiate and initialize an Employee object
            //with a first name of "Sample" and a last name of "Student"
            
            Employee employee1 = new Employee() { firstName = "Sample", lastName = "Student" };
            employee1.SayName();
            //Console.WriteLine();
            Console.ReadLine();
        }
    }
}
