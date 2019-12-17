using System;

namespace LeetCodeProblems
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] words = { "cat", "cats", "aaa", "at" };
            string chars = "cata";
            //int[] input = { 1, 2, 1, 3, 2, 5, 8, 1 };
            //LeetCodeProblems.Easy.RomanInt.RomanInteger();
            //LeetCodeProblems.Easy.ValidParentheses.CheckParentheses();
            //LeetCodeProblems.Interview.HighestOccurance.MostFrequent(input);
            //LeetCodeProblems.Interview.StringPlus.MakeSign(input);
            LeetCodeProblems.Easy.WordsFromCharacters.CountCharacters(words, chars);
        }
    }
}
