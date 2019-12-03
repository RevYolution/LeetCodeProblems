using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Easy
{
    //Given a 32-bit signed integer, reverse digits of an integer.
    //Need to write case for overflow exception with checked or comparison to int.MaxValue
    public class IntegerReverse
    {
        public int Reverse(int x)
        {
            //Need a checked keyword calculation to make sure that the int x is not outside the range of a int. Write a try catch block to return 0 when int x is outside the range. 

            int number = Math.Abs(x);
            int reverse = 0;
            while (number > 0)
            {
                int remainder = number % 10;
                reverse = (reverse * 10) + remainder;
                number = number / 10;
            }
            if (reverse > int.MaxValue)
            {
                return 0;
            }
            if (x < 0)
            {
                int negReturn = -reverse;
                return negReturn;
            }

            return reverse;
        }

    }
}
