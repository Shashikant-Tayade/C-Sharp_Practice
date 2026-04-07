using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice
{
    public class ImplicitConDemo
    {
        int x;
        bool b;
        // Here we have not written any constructor but still the values of x, and y are initialized with their
        // default values because of the implicit constructor is created by compiler to initialize the variables.
        // ant it is called when we create object of the class. 
        static void Main(string[] args)
        {
            ImplicitConDemo ImplicitConDemoObj = new ImplicitConDemo();
            Console.WriteLine("value of x : " + ImplicitConDemoObj.x);
            Console.WriteLine("value of b : " + ImplicitConDemoObj.b);
        }

    }
}
