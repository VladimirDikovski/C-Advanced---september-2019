using System;
using System.Collections.Generic;
using System.Linq;

namespace Reverse_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var stack = new Stack<char>();
            ReverseStrings(stack,input);
            PoolString(stack);

           
        }

        private static void PoolString(Stack<char> stack)
        {
            while (stack.Count > 0)
            {
                Console.Write(stack.Pop());
            }
        }

        private static Stack<char> ReverseStrings(Stack<char> stack,string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                stack.Push(input[i]);
            }
            return stack;
        }
    }
}
