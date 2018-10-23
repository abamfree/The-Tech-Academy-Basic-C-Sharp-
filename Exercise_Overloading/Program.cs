using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee() { FirstName = "Bob", LastName = "Hay", Id = 2 };

            Employee employee2 = new Employee() { FirstName = "Henry", LastName = "Jones", Id = 3 };



            //List<Employee> employeeList = new List<Employee>();

            //employeeList.Add(new Employee() { FirstName = "Abraham", LastName = "Beyene", Id = 2 });

            //employeeList.Add(new Employee() { FirstName = "Henry", LastName = "Jones", Id = 3 });



            bool compareId = (employee1.Id == employee2.Id);

            Console.WriteLine(compareId);

            employee1.SayName();

            employee2.SayName();



            Console.ReadLine();



            //1. Overload the "==" operator so it checks if two Employee objects are equal by comparing their Id property.


        }
    }
}
