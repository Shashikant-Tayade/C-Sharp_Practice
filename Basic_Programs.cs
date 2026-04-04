using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Practice
{
    internal class Basic_Programs
    {
        // calling methods from this main method.
        //Reverse String using blank string.

        //Logic: take a string from user. populate string in for loop in 
        // reverse direction from last to first. store it in blank string.
        public string ReverseStringUsingBlankString(string ipstring)
        {
            string RevString = "";

            for (int i = ipstring.Length - 1; i >= 0; i--)
            {
                RevString = RevString + ipstring[i];
            }
            return RevString;
        }
    }
}
