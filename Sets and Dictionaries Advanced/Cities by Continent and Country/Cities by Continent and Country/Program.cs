using System;
using System.Collections.Generic;
using System.Linq;

namespace Cities_by_Continent_and_Country
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var dict = new Dictionary<string, Dictionary<string, List<string>>>();
            InputElements(n, dict);
            PrintElements(dict);
           
        }

        private static void PrintElements(Dictionary<string, Dictionary<string, List<string>>> dict)
        {
            foreach (var continent in dict)
            {
                Console.WriteLine($"{continent.Key}:");

                foreach (var country in continent.Value)
                {
                    Console.WriteLine($"{country.Key} -> {string.Join(", ",country.Value)}");
                }
            }
        }

        private static void InputElements(int n, Dictionary<string, Dictionary<string, List<string>>> dict)
        {
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ");
                string continent = input[0];
                string country = input[1];
                string city = input[2];

                if (!dict.ContainsKey(continent))
                {
                    dict[continent] = new Dictionary<string, List<string>>();
                }

                if (!dict[continent].ContainsKey(country))
                {
                    dict[continent][country] = new List<string>();
                }

                dict[continent][country].Add(city);

            }
        }
    }
}
