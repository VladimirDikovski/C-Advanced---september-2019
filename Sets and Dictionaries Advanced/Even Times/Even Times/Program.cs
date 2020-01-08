using System;
using System.Collections.Generic;
using System.Linq;

namespace Even_Times
{
    class Program
    {
        static void Main(string[] args)
        {
            int nDigits = int.Parse(Console.ReadLine());
            var evenDigits = new Dictionary<int, int>();

            PutElements(nDigits, evenDigits);
            PrintEvenNumber(evenDigits);
        }

        private static void PrintEvenNumber(Dictionary<int, int> evenDigits)
        {
            foreach (var item in evenDigits)
            {
                if (item.Value % 2 == 0)
                {
                    Console.WriteLine(item.Key);
                }
            }
        }

        private static void PutElements(int nDigits, Dictionary<int, int> evenDigits)
        {
            for (int i = 0; i < nDigits; i++)
            {
                int digit = int.Parse(Console.ReadLine());

                if (!evenDigits.ContainsKey(digit))
                {
                    evenDigits[digit] = 0;
                }
                evenDigits[digit]++;
            }
        }
    }
}
