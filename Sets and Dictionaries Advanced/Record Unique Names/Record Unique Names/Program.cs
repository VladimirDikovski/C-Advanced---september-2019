using System;
using System.Collections.Generic;
using System.Linq;

namespace Record_Unique_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            int digits = int.Parse(Console.ReadLine());
            var hashSet = new HashSet<string>();
            for (int i = 0; i < digits; i++)
            {
                string name = Console.ReadLine();
                hashSet.Add(name);

            }

            foreach (var name in hashSet)
            {
                Console.WriteLine(name);
            }
            
        }
    }
}
