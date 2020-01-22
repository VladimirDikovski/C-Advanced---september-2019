using System;
using System.Collections.Generic;
using System.Linq;

namespace Find_Evens_or_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            var RangeValue = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            int start = RangeValue[0];
            int end = RangeValue[1];
            var list = new List<int>();
            PutElements(start, end, list);
            var Type = Console.ReadLine();
            Func<int, bool> PredicateOld = x => x % 2 != 0;
            Func<int, bool> PredicateEven = x => x % 2 == 0;
            Action<int> Print = x => Console.Write(x+" ");
            if (Type== "odd")
            {
                list.Where(PredicateOld).ToList().ForEach(Print);
            }
            else
            {
                list.Where(PredicateEven).ToList().ForEach(Print);
            }
            
            
        }

        private static void PutElements(int start, int end, List<int> list)
        {
            for (int i = start; i <= end; i++)
            {
                list.Add(i);
            }
        }
    }
}
