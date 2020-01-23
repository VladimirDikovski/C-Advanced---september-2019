using System;
using System.Collections.Generic;
using System.Linq;

namespace TriFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int charLenght = int.Parse(Console.ReadLine());
            var listOfNames = Console.ReadLine().Split(" ").ToList();
           
            Func<string, int, bool> IsGrater = (x, y) => x.Sum(c=>c) >= y;
            Func<Func<string, int, bool>, List<string>, string> returnFirst = (a, b) => b.FirstOrDefault(s => a(s, charLenght));
            string result = returnFirst(IsGrater, listOfNames);
            if (result != null)
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine(String.Empty);
            }
        }

      
    }
}
