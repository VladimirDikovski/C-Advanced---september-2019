using System;
using System.Collections.Generic;
using System.Linq;

namespace Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var dict = new Dictionary<string,Dictionary<string,int>>();
            PutElements(n, dict);
            string[] findElements = Console.ReadLine().Split(" ");
            FindElementsInDress(findElements, dict);
            
        }

        private static void FindElementsInDress(string[] findElements, Dictionary<string, Dictionary<string, int>> dict)
        {
            string findColor = findElements[0];
            string findClothes = findElements[1];
                foreach (var color in dict)
                {
                    Console.WriteLine($"{color.Key} clothes:");
                    foreach (var dress in color.Value)
                    {
                        if(color.Key == findColor && dress.Key==findClothes)
                        {
                            Console.WriteLine($"* {dress.Key} - {dress.Value} (found!)");
                        }
                        else
                        {
                            Console.WriteLine($"* {dress.Key} - {dress.Value}");
                        }
                        
                    }
                }                    
        }
        private static void PutElements(int n, Dictionary<string, Dictionary<string, int>> dict)
        {
            for (int i = 0; i < n; i++)
            {
                string[] elements = Console.ReadLine().Split(new string[] { ",", " -> " }, StringSplitOptions.RemoveEmptyEntries);

                string color = elements[0];
                if (!dict.ContainsKey(color))
                {
                    dict[color] = new Dictionary<string, int>();
                }

                for (int j = 1; j < elements.Length; j++)
                {
                    string dress = elements[j];
                    if (!dict[color].ContainsKey(dress))
                    {
                        dict[color][dress] = 0;
                    }
                    dict[color][dress]++;

                }


            }
        }
    }
}
