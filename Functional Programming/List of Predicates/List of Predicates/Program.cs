using System;
using System.Collections.Generic;
using System.Linq;

namespace List_of_Predicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var dividers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            bool isDivede = false;
            var result = new List<int>();
            FindDividers(n, dividers, isDivede, result);



        }

        private static void FindDividers(int n, int[] dividers, bool isDivede, List<int> result)
        {


            for (int i = 1; i <= n; i++)
            {

                for (int j = 0; j < dividers.Length; j++)
                {
                    if (i % dividers[j] == 0)
                    {
                        isDivede = true;
                    }
                    else
                    {
                        isDivede = false;
                        break;

                    }
                }
                if (isDivede)
                {
                    result.Add(i);
                }
            }

            Console.WriteLine(string.Join(" ",result));
        }
    }
}
