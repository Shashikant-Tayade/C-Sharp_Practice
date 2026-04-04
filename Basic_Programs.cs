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

        //Reverse String inplace.
        //LOGIC:
        //as a string is immutable, we cannot actually reverse original string inplace.
        //we take a string from user, convert it to character array,
        // set first to start and end to the end of the array element. then 
        // swap the first with last element till start is less than end.

        public string ReverseStringInplace(string ipstring)
        {
            char[] charArray = ipstring.ToCharArray();
            int start = 0;
            int end = ipstring.Length - 1;
            while (start < end)
            {
                char temp = charArray[start];
                charArray[start] = charArray[end];
                charArray[end] = temp;
                start++;
                end--;
            }
            return new string(charArray);
        }

    }
}
