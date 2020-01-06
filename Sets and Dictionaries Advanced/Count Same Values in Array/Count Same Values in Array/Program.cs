using System;
using System.Collections.Generic;
using System.Linq;

namespace Count_Same_Values_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<double, int>();
            var digits = Console.ReadLine().Split(" ").Select(double.Parse).ToArray();

            coutElements(dict, digits);
            PrintElements(dict);
           
        }

        private static void PrintElements(Dictionary<double, int> dict)
        {
            foreach (var digit in dict)
            {
                Console.WriteLine($"{digit.Key} - {digit.Value} times");
            }
        }

        private static void coutElements(Dictionary<double, int> dict, double[] digits)
        {
            for (int i = 0; i < digits.Length; i++)
            {
                double firstDigit = digits[i];
                if (!dict.ContainsKey(firstDigit))
                {
                    dict[firstDigit] = 0;
                }
                dict[firstDigit]++;
            }
        }
    }
}
