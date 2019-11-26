using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Easy
{
    //Given an array of integers, return indices of the two numbers such that they add up to a specific target.
    //You may assume that each input would have exactly one solution, and you may not use the same element twice.

    //To find the two numbers use a nested for loop comparing the sum of the held outer loop and the inner loop to the target number. If the sum is equal to the target number return the index of the outer and inner loop.
    class TwoSum
    {
        public int[] TwoSumMethod(int[] nums, int target)
        {

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if ((nums[i] + nums[j]) == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }
            return new int[2];
        }
    }
}
