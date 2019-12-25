using System;
using System.Collections.Generic;
using System.Linq;
namespace justTesti
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(" ").ToArray();
            var stack = new Stack<string>(input);

            while (stack.Count>0)
            {
                Console.WriteLine(stack.Pop());
                stack.Push("tati");
                stack.Pop();
            }
        }
    }
}
