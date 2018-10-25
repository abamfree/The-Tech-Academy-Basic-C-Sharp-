using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerccise_Abstract
{
    public abstract class Person
    {
        public string FirstName;
        public string LastName;


        //1. Create an abstract class called Person with two properties: string firstName and string lastName.


        //2. Give it the method SayName().

        public void SayName()

        {

            Console.WriteLine("Name: " + FirstName + " " + LastName);

        }
    }
}
