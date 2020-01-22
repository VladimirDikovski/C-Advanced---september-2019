using System;
using System.Collections.Generic;
using System.Linq;

namespace Action_Point
{
    class Program
    {
        static void Main(string[] args)
        {

            Action<string> PrintResult = x => Console.WriteLine(x);
            Console.ReadLine()
                .Split()
                .ToList()
                .ForEach(PrintResult);


        }
    }

      
}
