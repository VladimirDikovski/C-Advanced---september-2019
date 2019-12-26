using System;
using System.Collections.Generic;
using System.Linq;

namespace Matching_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var stack = new Stack<int>();
            FindBrackets(input, stack);
        }

        private static void FindBrackets(string input, Stack<int> stack)
        {
            for (int i = 0; i <input.Length; i++)
            {
                var symbol = input[i];
                if (symbol =='(')
                {
                    stack.Push(i);
                }
                else if (symbol ==')')
                {
                    var closeBraketindex = stack.Pop();
                    var result = input.Substring(closeBraketindex, i-closeBraketindex+1);
                    Console.WriteLine(result);
                }
            }
        }
    }
}
