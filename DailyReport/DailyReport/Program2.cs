using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReport
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy");
             Console.WriteLine("Student Daily Report");
             Console.WriteLine("What Course Are You On ?");
             string currentCourse = Console.ReadLine();
             Console.WriteLine("currentCourse: " + currentCourse);
             Console.WriteLine("What page number are you on?");
            string pageNumber = Console.ReadLine();
            int pageNo = Convert.ToInt32(pageNumber);
            Console.WriteLine("pageNumber: "+ pageNumber);
            Console.WriteLine("Do you need help with anything?");
            Console.WriteLine("Please answer True or False");
            string answer = Console.ReadLine();
            //bool help = true;
           // string helpStatus = Convert.ToString(help);
           // Console.WriteLine(helpStatus);
            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string specfic = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string feedBack = Console.ReadLine();
            Console.WriteLine("How Many Hours Did You Study");
            string hoursStudy = Console.ReadLine();
            int hrStudy = Convert.ToInt32(hoursStudy);
            Console.WriteLine("HoursStudy : " + hoursStudy);
            //Console.ReadLine();
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();
        }
    }
}
