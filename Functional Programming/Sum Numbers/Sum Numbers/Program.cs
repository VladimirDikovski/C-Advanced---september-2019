using System;
using System.Collections.Generic;
using System.Linq;

namespace Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var digits = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();          
            Console.WriteLine(digits.Count);
            Console.WriteLine(digits.Sum());
        }
       
    }
}
