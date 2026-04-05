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

        //Reverse a Number
        //LOGIC:
        //take number from user. extract last digit from number using %.
        // reverse number: rev = (rev * 10) + digit.
        //remove last digit using /.
        public int ReverseNumber(int number)
        {
            int rev = 0;
            while (number != 0)
            {
                int digit = number % 10;
                rev = (rev * 10) + digit;
                number = number / 10;
            }
            return rev;
        }

        //check whether the number is palindrome or not.
        //LOGIC:
        //take number from user. store copy of if to the variable.
        //now reverse the number. if reverse number is same as 
        //original number, then it is palindrome otherwise it is not.
        //here we use ReverseNumber method to reverse number.
        // then compare it with original number. it is is same,
        // then it is palindrome otherwise not.
        public bool isPalindrome(int number)
        {
            Basic_Programs Basic_ProgramsObj = new Basic_Programs();
            int reverse = Basic_ProgramsObj.ReverseNumber(number);
            if (number == reverse)
            {
                return true;
            }
            return false;
        }
    }
}
