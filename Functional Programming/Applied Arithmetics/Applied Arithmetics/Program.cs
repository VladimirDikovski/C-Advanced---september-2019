using System;
using System.Collections.Generic;
using System.Linq;

namespace Applied_Arithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            var Digits = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            ManipulatinList(Digits);
        }

        private static void ManipulatinList(List<int> digits)
        {
            Func<int, int> Add = x => x += 1;
            Func<int, int> subtract = x => x -= 1;
            Func<int, int> multiply = x => x *= 2;
            Func<List<int>,string> Print = x => string.Join(" ", x);
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }
                else if (input == "add")
                {
                  digits= digits.Select(Add).ToList();
                }
                else if(input== "multiply")
                {
                    digits = digits.Select(multiply).ToList();
                }
                else if(input== "subtract")
                {
                    digits = digits.Select(subtract).ToList();
                }
                else if(input== "print")
                {
                    Console.WriteLine(Print(digits));
                }

            }
        }
    }
}
