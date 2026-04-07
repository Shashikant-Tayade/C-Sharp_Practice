using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice
{
    internal class ExplicitConDemo
    {
        // Explicit constructor is defined by programmer. 
        // and called when created class object.
        public ExplicitConDemo()
        {
            Console.WriteLine("Explicit Constructor called");
        }
        static void Main(string[] args)
        {
            ExplicitConDemo explicitConDemoObj = new ExplicitConDemo();

        }
    }
}
