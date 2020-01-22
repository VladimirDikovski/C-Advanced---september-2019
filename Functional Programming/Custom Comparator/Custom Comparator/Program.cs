using System;
using System.Linq;
using System.Collections.Generic;

namespace Custom_Comparator
{
    class Program
    {
        static void Main(string[] args)
        {
            var digits = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            Func<int, int, int> sortFuct = (a, b) => a.CompareTo(b);
            var evenDigits = digits.Where(x => x % 2 == 0).OrderBy(y => y).ToArray();
            var oldDigits = digits.Where(x => x % 2 != 0).OrderBy(y => y).ToArray();
            Action<int[], int[]> Print = (x, y) => Console.WriteLine($"{string.Join(" ",x)} {string.Join(" ",y)}");
            Array.Sort(evenDigits, new Comparison<int>(sortFuct));
            Array.Sort(oldDigits, new Comparison<int>(sortFuct));
            Print(evenDigits,oldDigits);

          

            

          


        }
    }
}
