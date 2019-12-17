using System;
using System.Collections.Generic;

namespace LeetCodeProblems.Easy
{
    //In a array A of size 2N, there are N+1 unique elements, and exactly one of these elements is repeated N times.
    //Return the element repeated N times.
    //Input: [1,2,3,3]
    //Output: 3
    public class NRepetedElements
    {
        public int RepeatedNTimes(int[] A)
        {
            HashSet<int> repeat = new HashSet<int>();

            foreach (var item in A)
            {
                if (!repeat.Contains(item))
                {
                    repeat.Add(item);
                }
                else
                {
                    return item;
                }
            }
            return 0;
        }
    }
}
