using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Interview
{
    public class HighestOccurance
    {
        public static int MostFrequent(int[] input)
        {
            int key = 0;
            int value = 0;
            Dictionary<int, int> check = new Dictionary<int, int>();

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
