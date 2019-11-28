using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Easy
{

//Given a string containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.
//An input string is valid if:
//Open brackets must be closed by the same type of brackets.
//Open brackets must be closed in the correct order.
//Note that an empty string is also considered valid.
    class ValidParentheses
    {
        public static void CheckParentheses() 
        {
            Console.WriteLine("Please input a series of characters that only contains '(', ')', '[', ']', '{' or '}. They do not have to close off the function will tell if they are closed or not.");
            string UserInput = Console.ReadLine();

            Stack ParensStack = new Stack();
            Stack SquareStack = new Stack();
            Stack CurlyStack = new Stack();

            int counter = 0;
            bool endReturn = false;

            while (counter < UserInput.Length)
            {
                if (UserInput[counter] == '(' || UserInput[counter] == ')')
                {
                    if(ParensStack.Count == 0)
                    {
                        ParensStack.Push(UserInput[counter]);
                        counter++;
                    }
                    else
                    {
                        char checkParens = Convert.ToChar(ParensStack.Peek());
                        if (UserInput[counter] == checkParens)
                        {
                            ParensStack.Push(UserInput[counter]);
                            counter++;
                        }
                        else
                        {
                            ParensStack.Pop();
                            counter++;
                        }
                    }
                }
                else if (UserInput[counter] == '[' || UserInput[counter] == ']')
                {
                    if (SquareStack.Count == 0)
                    {
                        SquareStack.Push(UserInput[counter]);
                        counter++;
                    }
                    else
                    {
                        char checkSquare = Convert.ToChar(SquareStack.Peek());
                        if (UserInput[counter] == checkSquare)
                        {
                            SquareStack.Push(UserInput[counter]);
                            counter++;
                        }
                        else
                        {
                            SquareStack.Pop();
                            counter++;
                        }
                    }
                }
                else 
                {
                    if (CurlyStack.Count == 0)
                    {
                        CurlyStack.Push(UserInput[counter]);
                        counter++;
                    }
                    else
                    {
                        char checkCurly = Convert.ToChar(CurlyStack.Peek());
                        if (UserInput[counter] == checkCurly)
                        {
                            CurlyStack.Push(UserInput[counter]);
                            counter++;
                        }
                        else
                        {
                            CurlyStack.Pop();
                            counter++;
                        }
                    }
                }
            }
            if (ParensStack.Count != 0 || SquareStack.Count != 0 || CurlyStack.Count != 0)
            {
                Console.WriteLine(endReturn);
            }
            else
            {
                endReturn = true;
                Console.WriteLine(endReturn);
            }
        }
    }
}
