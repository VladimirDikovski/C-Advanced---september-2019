using System;
using System.Collections.Generic;
using System.Linq;

namespace Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(" ");
            var stack = new Stack<string>(input.Reverse());
            var result = 0;

            while (stack.Count>0)
            {
                var element = stack.Pop();
                if (element == "+")
                {
                    var number = stack.Pop();
                    result += int.Parse(number);
                }
                else if (element == "-")
                {
                    var number = stack.Pop();
                    result -= int.Parse(number);
                }
                else
                {
                    result = int.Parse(element);
                }
            }
            Console.WriteLine(result);
        }

        
        
    }
}
