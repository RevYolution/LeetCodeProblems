using System;
using System.Collections.Generic;

namespace LeetCodeProblems.Easy
{
    //You're given strings J representing the types of stones that are jewels, and S representing the stones you have.  Each character in S is a type of stone you have.  You want to know how many of the stones you have are also jewels.
    //The letters in J are guaranteed distinct, and all characters in J and S are letters.Letters are case sensitive, so "a" is considered a different type of stone from "A".
    //Input: J = "aA", S = "aAAbbbb"
    //Output: 3
    public class Jewels
    {
        public int NumJewelsInStones(string J, string S)
        {
            HashSet<char> jewels = new HashSet<char>();
            int counter = 0;

            foreach (var item in J)
            {
                jewels.Add(item);
            }

            foreach (var item in S)
            {
                if (jewels.Contains(item))
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
