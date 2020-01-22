using System;
using System.Collections.Generic;
using System.Linq;

namespace Custom_Min_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<List<int>, int> FindMinValue = x => x.Min();
            var listDigits = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

            Console.WriteLine(FindMinValue(listDigits));
        }

      
    }
}
