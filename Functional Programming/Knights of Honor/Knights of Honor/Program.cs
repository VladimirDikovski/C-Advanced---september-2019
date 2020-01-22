using System;
using System.Collections.Generic;
using System.Linq;

namespace Knights_of_Honor
{
    class Program
    {
        static void Main(string[] args)
        {

            Action<string> ApentSir = x => Console.WriteLine($"Sir {x}"); 
            Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList().ForEach(ApentSir);
        }
    }
}
