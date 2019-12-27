using System;
using System.Collections.Generic;
using System.Linq;

namespace Maximum_and_Minimum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOperators = int.Parse(Console.ReadLine());
            var stack = new Stack<int>();
            ManipulationStack(countOperators, stack);
        }

        private static void ManipulationStack(int countOperators, Stack<int> stack)
        {
            for (int i = 0; i < countOperators; i++)
            {
               
                int[] diggits = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                int command = diggits[0];
                switch (command)
                {
                    case 1:
                        int value = diggits[1];
                        stack.Push(value);
                        break;
                    case 2:
                        if (stack.Count > 0)
                        {
                            stack.Pop();
                        }
                        break;
                    case 3:
                        if (stack.Count > 0)
                        {
                            Console.WriteLine(stack.Max());
                        }
                       
                        break;
                    case 4:
                        if (stack.Count > 0)
                        {
                            Console.WriteLine(stack.Min());
                        }
                        break;

                }
            }
            Console.WriteLine(string.Join(", ",stack));
           
        }
    }
}
