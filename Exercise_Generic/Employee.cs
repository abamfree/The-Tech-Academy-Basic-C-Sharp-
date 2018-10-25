using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Generic
{
    
    
        //1. Make the Employee class take a generic type parameter.

        class Employee<T> : Person

        {

        //2. Add a property to the Employee class called "things" and 
        //have its data type be a generic list matching the generic type of the class.

            public List<T> Things { get; set; }



            public int Id { get; set; }



            public new void SayName()

            {

                base.SayName();//

            }

            public static bool operator ==(Employee<T> employee1, Employee<T> employee2)

            {

                if (employee1.Id == employee2.Id)

                {



                    return true;



                }

                else return false;





            }

            public static bool operator !=(Employee<T> employee1, Employee<T> employee2)

            {

                if (employee1.Id != employee2.Id)

                {

                    return false;

                }

                else return true;

            }



            public override int GetHashCode()

            {

                return base.GetHashCode();

            }



            public override bool Equals(object obj)

            {

                return base.Equals(obj);



            }
        }
}
