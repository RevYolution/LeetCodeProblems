using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Easy
{
//    Roman numerals are represented by seven different symbols: I, V, X, L, C, D and M.

//Symbol Value
//I             1
//V             5
//X             10
//L             50
//C             100
//D             500
//M             1000
//For example, two is written as II in Roman numeral, just two one's added together. Twelve is written as, XII, which is simply X + II. The number twenty seven is written as XXVII, which is XX + V + II.

//Roman numerals are usually written largest to smallest from left to right.However, the numeral for four is not IIII. Instead, the number four is written as IV.Because the one is before the five we subtract it making four. The same principle applies to the number nine, which is written as IX.There are six instances where subtraction is used:

//I can be placed before V (5) and X(10) to make 4 and 9. 
//X can be placed before L(50) and C(100) to make 40 and 90. 
//C can be placed before D(500) and M(1000) to make 400 and 900.
//Given a roman numeral, convert it to an integer.Input is guaranteed to be within the range from 1 to 3999.

    public class RomanInt
    {
        public static void RomanInteger()
        {
            Console.WriteLine("Please input a Roman Numeral");
            string userInput = Console.ReadLine();
            string numeralInput = userInput.ToLower();

            Dictionary<char, int> numerals = new Dictionary<char, int>();
            numerals.Add('i', 1);
            numerals.Add('v', 5);
            numerals.Add('x', 10);
            numerals.Add('l', 50);
            numerals.Add('c', 100);
            numerals.Add('d', 500);
            numerals.Add('m', 1000);

            int builder = 0;

            if (numeralInput.Contains("iv"))
            {
                numeralInput = numeralInput.Replace("iv", "");
                builder += 4;
            }

            if (numeralInput.Contains("ix"))
            {
                numeralInput = numeralInput.Replace("ix", "");
                builder += 9;
            }

            if (numeralInput.Contains("xl"))
            {
                numeralInput = numeralInput.Replace("xl", "");
                builder += 40;
            }

            if (numeralInput.Contains("xc"))
            {
                numeralInput = numeralInput.Replace("xc", "");
                builder += 90;
            }

            if (numeralInput.Contains("cd"))
            {
                numeralInput = numeralInput.Replace("cd", "");
                builder += 400;
            }

            if (numeralInput.Contains("cm"))
            {
                numeralInput = numeralInput.Replace("cm", "");
                builder += 900;
            }

            foreach (char item in numeralInput)
            {
                builder += numerals[item];
            }

            Console.WriteLine($"{builder}");
        }

        public static void RomanIntegerIfElse()
        {
            Console.WriteLine("Please input a Roman Numeral");
            string userInput = Console.ReadLine();
            string lowerInput = userInput.ToLower();
            //int stringLength = lowerInput.Length
            char[] letter = new char[lowerInput.Length];
            int builder = 0;
            int counter = 0;

            for (int i = 0; i < letter.Length; i++)
            {
                letter[i] = lowerInput[i];
            }

            //Console.WriteLine($"{letter[0]}, {letter[1]}, {letter[2]}");

            while (counter < letter.Length)
            {
                if (counter == (letter.Length - 1))
                {
                    if (letter[counter] == 'i')
                    {
                        builder += 1;
                        counter++;
                    }
                    else if (letter[counter] == 'v')
                    {
                        builder += 5;
                        counter++;
                    }
                }
                else
                {

                    //m block
                    if (letter[counter] == 'm')
                    {
                        builder += 1000;
                        counter++;
                    }
                    //d block
                    if (letter[counter] == 'd')
                    {
                        builder += 500;
                        counter++;
                    }
                    //c block
                    if (letter[counter] == 'c')
                    {
                        if (letter[counter + 1] == 'd')
                        {
                            builder += 400;
                            counter = +2;
                        }
                        else if (letter[counter + 1] == 'm')
                        {
                            builder += 900;
                            counter += 2;
                        }
                        else
                        {
                            builder += 100;
                            counter++;
                        }
                    }
                    //l block
                    if (letter[counter] == 'l')
                    {
                        builder += 50;
                        counter++;
                    }
                    //x block
                    if (letter[counter] == 'x')
                    {
                        if (letter[counter + 1] == 'c')
                        {
                            builder += 90;
                            counter += 2;
                        }
                        else if (letter[counter + 1] == 'l')
                        {
                            builder += 40;
                            counter += 2;
                        }
                        else
                        {
                            builder += 10;
                            counter++;
                        }
                    }
                    //v block
                    if (letter[counter] == 'v')
                    {
                        builder += 5;
                        counter++;
                    }
                    //i block
                    if (letter[counter] == 'i')
                    {
                        if (letter[counter + 1] == 'x')
                        {
                            builder += 9;
                            counter += 2;
                        }
                        else if (letter[counter + 1] == 'v')
                        {
                            builder += 4;
                            counter += 2;
                        }
                        else
                        {
                            builder += 1;
                            counter++;
                        }
                    }
                }
            }
            Console.WriteLine($"{builder}"
                );
        }

    }
}
