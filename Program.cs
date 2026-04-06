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

            //Console.WriteLine("Enter the string to reverse : ");
            //string ipstring = Console.ReadLine();

            //uncomment to execute ReverseStringUsingBlankString method.
            //string RevString = Basic_Programs_Obj.ReverseStringUsingBlankString(ipstring);

            //uncomment to execute ReverseStringInPlace method.
            //string RevString = Basic_Programs_Obj.ReverseStringInplace(ipstring);

            //Console.WriteLine($"Reversed String = {RevString}");

            //uncomment to execute ReverseNumber method.
            //Console.WriteLine("Ente the Number to Reverse it : ");
            //int number = Convert.ToInt32(Console.ReadLine());
            //int revNo = Basic_Programs_Obj.ReverseNumber(number);
            //Console.WriteLine($"Reversed Number = {revNo}");
            //Console.ReadLine();

            //uncomment to execute isPalindrome method.
            //Console.WriteLine("Enter the number to check for Palindrome : ");
            //int number = Convert.ToInt32(Console.ReadLine());

            //bool result = Basic_Programs_Obj.IsPalindrome(number);
            //if (result == true)
            //{
            //    Console.WriteLine($"{number} is Palindrome");
            //}
            //else
            //{
            //    Console.WriteLine($"{number} is not Palindrome");
            //}

            //Uncomment to run CalculateFactorial code.
            //Console.WriteLine("Enter the Number to calculate it's Factorial : ");
            //int number = Convert.ToInt32(Console.ReadLine());
            //int fact = Basic_Programs_Obj.CalculateFactorial(number);
            //Console.WriteLine($"{number} ! = {fact}");

            Console.WriteLine("Enter the term till you want to print fibonacci series : ");
            int term = Convert.ToInt32(Console.ReadLine());
            int[] fibseries = Basic_Programs_Obj.PrintFibonacci(term);
            Console.WriteLine("fibonacci series : ");
            Console.WriteLine(string.Join(", ", fibseries));




            Console.ReadLine();
        }
    }
}
