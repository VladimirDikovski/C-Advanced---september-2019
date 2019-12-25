using System;
using System.Collections.Generic;
using System.Linq;


namespace Stack_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var digits = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            var stack = new Stack<int>(digits);
            StackManipulatin(stack);
            SumAndPrintResult(stack);
        }

        private static void SumAndPrintResult(Stack<int> stack)
        {
           int result = stack.Sum();
            Console.WriteLine($"Sum: {result}");
        }

        private static Stack<int> StackManipulatin(Stack<int> stack)
        {
            while (true)
            {
                var input = Console.ReadLine().ToLower().Split(" ");
                string comand = input[0];
                if (comand =="end")
                {
                    break;
                }
                else if (comand == "add")
                {
                    int digitOne = int.Parse(input[1]);
                    int digitTwo = int.Parse(input[2]);
                    stack.Push(digitOne);
                    stack.Push(digitTwo);
                }
                else if (comand == "remove")
                {
                  
                    int countDigits = int.Parse(input[1]);
                    if (stack.Count >= countDigits)
                    {
                        for (int i = 0; i < countDigits; i++)
                        {
                            stack.Pop();
                        }
                    }
                      
                }
            }
            
            return stack;
        }
    }
}
