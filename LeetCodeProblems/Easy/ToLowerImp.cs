using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Easy
{
    public class ToLowerImp
    {
        public string ToLowerCase(string str)
        {
            Dictionary<char, char> toLower = new Dictionary<char, char>();

            toLower.Add('A', 'a');
            toLower.Add('B', 'b');
            toLower.Add('C', 'c');
            toLower.Add('D', 'd');
            toLower.Add('E', 'e');
            toLower.Add('F', 'f');
            toLower.Add('G', 'g');
            toLower.Add('H', 'h');
            toLower.Add('I', 'i');
            toLower.Add('J', 'j');
            toLower.Add('K', 'k');
            toLower.Add('L', 'l');
            toLower.Add('M', 'm');
            toLower.Add('N', 'n');
            toLower.Add('O', 'o');
            toLower.Add('P', 'p');
            toLower.Add('Q', 'q');
            toLower.Add('R', 'r');
            toLower.Add('S', 's');
            toLower.Add('T', 't');
            toLower.Add('U', 'u');
            toLower.Add('V', 'v');
            toLower.Add('W', 'w');
            toLower.Add('X', 'x');
            toLower.Add('Y', 'y');
            toLower.Add('Z', 'z');

            StringBuilder returnString = new StringBuilder();

            for (int i = 0; i < str.Length; i++)
            {
                char replaceChar = ' ';
                if (toLower.TryGetValue(str[i], out replaceChar))
                {
                    returnString.Append(replaceChar);
                }
                else
                {
                    returnString.Append(str[i]);
                }
            }

            return returnString.ToString();
        }
    }
}
