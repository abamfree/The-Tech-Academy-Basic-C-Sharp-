using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Interface
{
    class Employee : IQuittable
    {
        public void Quit()
        {
            Console.WriteLine("Hello World");
        }
    }
}