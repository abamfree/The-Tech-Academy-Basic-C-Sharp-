using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. In the Main() method, create a list of at least 10 employees. Each employee 
            //should have a first and last name, as well as an Id. At least two employees should have the first name "Joe".

            List<Employee> employeeList = new List<Employee>();

            employeeList.Add(new Employee { FirstName = "Joe", LastName = "Math", Id = 1 });

            employeeList.Add(new Employee { FirstName = "efrata", LastName = "ghi", Id = 2 });

            employeeList.Add(new Employee { FirstName = "leo", LastName = "martha", Id = 3 });

            employeeList.Add(new Employee { FirstName = "eee", LastName = "lTree", Id = 4 });

            employeeList.Add(new Employee { FirstName = "boy", LastName = "raCoon", Id = 5 });

            employeeList.Add(new Employee { FirstName = "fam", LastName = "Awel", Id = 6 });

            employeeList.Add(new Employee { FirstName = "Ea", LastName = "mer", Id = 7 });

            employeeList.Add(new Employee { FirstName = "jetli", LastName = "Luis", Id = 8 });

            employeeList.Add(new Employee { FirstName = "go", LastName = "ptd", Id = 9 });

            employeeList.Add(new Employee { FirstName = "Joe", LastName = "Trump", Id = 10 });



            //2. Using a foreach loop, create a new list of all employees with the first name "Joe".

            List<Employee> joe = new List<Employee>();

            foreach (Employee employee in employeeList)

            {

                if (employee.FirstName == "Joe")

                {

                    joe.Add(employee);

                }

            }

            foreach (Employee emp in joe)

            {

                Console.WriteLine(emp.FirstName + " " + emp.LastName);

            }

            Console.ReadLine();



            //3. Do the same thing again, but this time with a lambda expression.

            List<Employee> lambdaJoe = employeeList.Where(x => x.FirstName == "Joe").ToList();

            foreach (Employee employee in lambdaJoe)

            {

                Console.WriteLine(employee.FirstName + " " + employee.LastName);

            }

            Console.ReadLine();



            //4. Using a lambda expression, make a list of all employees with an Id number greater than 5.

            List<Employee> idBiggerThan5 = employeeList.Where(x => x.Id > 5).ToList();

            foreach (Employee id in idBiggerThan5)

            {

                Console.WriteLine(id.FirstName + " " + id.LastName + " " + id.Id);

            }

            Console.ReadLine();
            //Lambda examples
            //List<int> numberList = new List<int>()
            //{ 1, 2, 3, 56 ,30 };

            //int sum = numberList.Where(x => x > 20).Sum();
            //// int sum = numberList.Sum();
            //Console.WriteLine(sum);
            //Console.ReadLine();


        }

    }

}
           