using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritance
   {

    /* 3 Create another class called Employee and have it inherit from the Person class. 
     Give the Employee class a property called Id and have it be of data type int.*/
    public class Employee : Person
    {
        public int Id;
    
    //Call the superclass method SayName() on the Employee object.

    //5. Call the superclass method SayName() on the Employee object.

    public void SayName()

            {

                base.SayName();
           // Console.WriteLine("I'm an Employee class.");

            }
       


        }
    }
