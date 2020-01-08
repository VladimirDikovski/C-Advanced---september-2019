using System;
using System.Collections.Generic;
using System.Linq;

namespace Count_Symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            var symbolsCount = new SortedDictionary<char, int>();
            PutElemnts(text, symbolsCount);
            PrintElements(symbolsCount);
        }

        private static void PrintElements(SortedDictionary<char, int> symbolsCount)
        {
            foreach (var symbols in symbolsCount)
            {
                Console.WriteLine($"{symbols.Key}: {symbols.Value} time/s");
            }
        }

        private static void PutElemnts(string text, SortedDictionary<char, int> symbolsCount)
        {
            for (int i = 0; i < text.Length; i++)
            {
                char symbol = text[i];
                if (!symbolsCount.ContainsKey(symbol))
                {
                    symbolsCount[symbol] = 0;
                }
                symbolsCount[symbol] ++;
            }
        }
    }
}
