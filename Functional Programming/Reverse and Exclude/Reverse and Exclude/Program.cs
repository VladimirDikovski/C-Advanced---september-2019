using System;
using System.Linq;
using System.Collections.Generic;

namespace Reverse_and_Exclude
{
    class Program
    {
        static void Main(string[] args)
        {
            var Digits = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            int Divader = int.Parse(Console.ReadLine());
            Func<int, bool> FindDivader = x => x % Divader != 0;
            Digits.Where(FindDivader).Reverse().ToList().ForEach(x => Console.Write(x + " "));
        }
    }
}
