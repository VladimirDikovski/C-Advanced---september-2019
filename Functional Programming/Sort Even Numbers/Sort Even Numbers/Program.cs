using System;
using System.Collections.Generic;
using System.Linq;

namespace Sort_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var digits = Console.ReadLine().Split(new char[] {',',' '},StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            digits = digits.Where(x => x % 2 == 0).OrderBy(x => x).ToList();
            Console.WriteLine(string.Join(", ",digits));
        }
    }
}
