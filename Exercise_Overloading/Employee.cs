using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Overloading
{
    public class Employee :Person
    {
        public int Id { get; set; }



        public new void SayName()

        {

            base.SayName();

        }

        public static bool operator ==(Employee employee1, Employee employee2)

        {

            if (employee1.Id == employee2.Id)

            {



                return true;



            }

            else return false;





        }

        public static bool operator !=(Employee employee1, Employee employee2)

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
