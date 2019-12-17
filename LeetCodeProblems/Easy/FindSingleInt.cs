using System;
using System.Collections.Generic;

namespace LeetCodeProblems.Easy
{
    public class FindSingleInt
    {
        public int SingleNumber(int[] nums)
        {
            Dictionary<int, int> single = new Dictionary<int, int>();

            int key = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (single.ContainsKey(nums[i]))
                {
                    single[nums[i]] += 1;
                }
                else
                {
                    single.Add(nums[i], 1);
                }
            }

            foreach (var item in single)
            {
                if (item.Value == 1)
                {
                    return item.Key;
                }
            }

            return key;
        }
    }
}
