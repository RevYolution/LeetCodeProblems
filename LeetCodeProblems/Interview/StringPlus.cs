using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Interview
{
    public class StringPlus
    {
        public char[,] MakeSign(string input)
        {
            char[,] sign = new char[input.Length, input.Length];

            if (input.Length<3)
            {
                return null;
            }
            else
            {
                for (int i = 0; i < input.Length; i++)
                {
                    sign[input.Length / 2, i] = input[i];
                }

                for (int i = 0; i < input.Length; i++)
                {
                    sign[i, input.Length / 2] = input[i];
                }
                return sign;
            }

        }

    }
}
