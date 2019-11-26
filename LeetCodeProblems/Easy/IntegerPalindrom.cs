using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Easy
{
    //Determine whether an integer is a palindrome.An integer is a palindrome when it reads the same backward as forward.
    //-121=>false 10=>false
    class IntegerPalindrom
    {
        public bool IsPalindrome(int x)
        {
            if (x < 0)
            {
                return false;
            }
            int number = x;
            int rebuild = 0;

            while (number > 0)
            {
                int remainder = number % 10;
                rebuild = (rebuild * 10) + remainder;
                number = number / 10;
            }
            if (rebuild == x)
            {
                return true;
            }
            else
            {
                return false;
            }


        }
    }
}
