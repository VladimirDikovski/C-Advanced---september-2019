using System;
using System.Collections.Generic;
using System.Linq;

namespace Count_Uppercase_Words
{
    class Program
    {
        static void Main(string[] args)
        {

            var Text = Console.ReadLine().Split(" ").ToList();

            Func<string, bool> filterList = x => char.IsUpper(x[0]);
            Text.Where(filterList).ToList().ForEach(Console.WriteLine);
          
        }
    }
}
