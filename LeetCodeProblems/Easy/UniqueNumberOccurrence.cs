using System;
using System.Collections.Generic;

namespace LeetCodeProblems.Easy
{
    //Given an array of integers arr, write a function that returns true if and only if the number of occurrences of each value in the array is unique.
    //Input: arr = [1,2,2,1,1,3]
    //Output: true
    //Explanation: The value 1 has 3 occurrences, 2 has 2 and 3 has 1. No two values have the same number of occurrences.
    public class UniqueNumberOccurrence
    {
        public bool UniqueOccurrences(int[] arr)
        {
            Dictionary<int, int> unique = new Dictionary<int, int>();
            HashSet<int> count = new HashSet<int>();

            foreach (var item in arr)
            {
                if (!unique.ContainsKey(item))
                {
                    unique.Add(item, 1);
                }
                else
                {
                    unique[item] += 1;
                }
            }

            foreach (var item in unique)
            {
                if (count.Contains(item.Value))
                {
                    return false;
                }
                else
                {
                    count.Add(item.Value);
                }
            }
            return true;
        }
    }
}
