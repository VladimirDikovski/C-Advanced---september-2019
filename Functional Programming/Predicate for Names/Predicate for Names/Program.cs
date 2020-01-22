using System;
using System.Collections.Generic;
using System.Linq;

namespace Predicate_for_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            int LenghtOfString = int.Parse(Console.ReadLine());
            var names = Console.ReadLine().Split(" ");
            Func<string, bool> FilterName = x => x.Length <= LenghtOfString;
            Action<string> Print = x => Console.WriteLine(x);
            names.Where(FilterName).ToList().ForEach(Print);
        }
    }
}
