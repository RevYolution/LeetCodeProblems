using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Interview
{
    //Write a method that takes in an int[] and returns the int that occurs the most. If only one int is present return that int. If the int[] is greater than 1 and no int occurs more than once return the lowest int. If the array is empty return 0.
    public class HighestOccurance
    {
        public int MostFrequent(int[] input)
        {
            int key = 0;
            int value = 0;
            Dictionary<int, int> check = new Dictionary<int, int>();

            if (input.Length == 0)
            {
                return key;
            }

            if (input.Length == 1)
            {
                return input[0];
            }

            for (int i = 0; i < input.Length; i++)
            {
                if (!check.ContainsKey(input[i]))
                {
                    check.Add(input[i], 1);
                }
                else
                {
                    check[input[i]] += 1;
                }
            }

            foreach (var item in check)
            {
                if (item.Value > value)
                {
                    value = item.Value;
                    key = item.Key;
                }
            }

            return key;
        }
    }
}
