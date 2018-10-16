using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInsurance
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("What is your age?");
            string age = Console.ReadLine();
            int age1 = Convert.ToInt32(age);
            Console.WriteLine("Have you ever had a DUI and please type true or false?");
            string DUI = Console.ReadLine();
            bool correct = Convert.ToBoolean(DUI);
           Console.WriteLine("Let's go on you might be Qualified");
            Console.WriteLine("How many speeding tickets do you have?");
            string noOfTickets = Console.ReadLine();
            int noOfTickets1 = Convert.ToInt32(noOfTickets);

            if (age1 > 15 && noOfTickets1 < 3 && correct==false)
            {
                Console.WriteLine(" Congrats you're Qualified");
            }
            else
            {
                Console.WriteLine("SORRY!");
            }

            Console.ReadLine();


        }
    }
}
