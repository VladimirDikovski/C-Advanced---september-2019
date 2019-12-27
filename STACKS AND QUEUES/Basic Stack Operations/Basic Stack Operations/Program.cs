using System;
using System.Collections.Generic;
using System.Linq;

namespace Basic_Stack_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            var command = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            var digits =Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            var stack = new Stack<int>();
            PushAndPoopInStack(command,stack,digits);
        }

        private static void PushAndPoopInStack(int[] command, Stack<int> stack,int[]digits)
        {
            int pushElement = command[0];
            int numberPoopElement = command[1];
            int findDigit = command[2];
            for (int i = 0; i < pushElement; i++)
            {

                stack.Push(digits[i]);
            }
            for (int i = 0; i < numberPoopElement; i++)
            {
               
                    stack.Pop();
               
            }
            if (stack.Count > 0)
            {
                if (stack.Contains(findDigit))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine(stack.Min());
                }
            }
            else
            {
                Console.WriteLine(0);
            }

            
        }
    }
}
