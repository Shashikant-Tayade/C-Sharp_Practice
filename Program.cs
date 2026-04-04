using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Basic_Programs Basic_Programs_Obj = new Basic_Programs();

            Console.WriteLine("Enter the string to reverse : ");
            string ipstring = Console.ReadLine();

            //string RevString = Basic_Programs_Obj.ReverseStringUsingBlankString(ipstring);
            string RevString = Basic_Programs_Obj.ReverseStringInplace(ipstring);
            Console.WriteLine($"Reversed String = {RevString}");

            Console.ReadLine();
        }
    }
}
