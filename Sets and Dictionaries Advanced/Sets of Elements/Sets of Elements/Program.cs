using System;
using System.Collections.Generic;
using System.Linq;

namespace Sets_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nANDm = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int n = nANDm[0];
            int m = nANDm[1];
            var setN = new HashSet<int>();
            var setM= new HashSet<int>();

            for (int i = 0; i < n; i++)
            {
                int digits = int.Parse(Console.ReadLine());
                setN.Add(digits);
            }
            for (int i = 0; i < m; i++)
            {
                int digits = int.Parse(Console.ReadLine());
                setM.Add(digits);
            }

            foreach (var digit in setN)
            {
                if (setM.Contains(digit))
                {
                    Console.Write(digit+ " ");
                }
            }

        }
    }
}
