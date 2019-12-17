using System;
using System.Collections.Generic;

namespace LeetCodeProblems.Easy
{
    //You are given an array of strings words and a string chars.
    //A string is good if it can be formed by characters from chars (each character can only be used once).
    //Return the sum of lengths of all good strings in words.
    //Input: words = ["cat","bt","hat","tree"], chars = "atach"
    //Output: 6
    //Explanation: 
    //The strings that can be formed are "cat" and "hat" so the answer is 3 + 3 = 6.

    public class WordsFromCharacters
    {
        public static int CountCharacters(string[] words, string chars)
        {
            Dictionary<char, int> characters = new Dictionary<char, int>();
            HashSet<string> goodWords = new HashSet<string>();
            int goodWordsLength = 0;

            foreach (var item in chars)
            {
                if (!characters.ContainsKey(item))
                {
                    characters.Add(item, 1);
                }
                else
                {
                    characters[item] += 1;
                }
            }

            foreach (var item in words)
            {
                foreach (var letter in item)
                {
                    int counter = 0; 
                    if (characters.ContainsKey(letter))
                    {
                        if (characters[letter] == 0)
                        {
                            break;
                        }
                        else
                        {
                            characters[letter] -= 1;
                            counter++;
                        }
                    }
                    if (counter == item.Length)
                    {
                        goodWords.Add(item);
                    }
                }
            }

            foreach (var item in goodWords)
            {
                goodWordsLength += item.Length;
            }

            return goodWordsLength;
        }
    }
}
