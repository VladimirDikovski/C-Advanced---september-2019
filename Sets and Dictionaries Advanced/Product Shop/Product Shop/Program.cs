using System;
using System.Collections.Generic;
using System.Linq;

namespace Product_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new SortedDictionary<string, Dictionary<string,double>>();
            while (true)
            {
                string input = Console.ReadLine();
                if(input=="Revision")
                {
                    break;
                }
                var parts = input.Split(new char[] {',',' '},StringSplitOptions.RemoveEmptyEntries).ToArray();
                string shop = parts[0];
                string product = parts[1];
                double price = double.Parse(parts[2]);
                if (!dict.ContainsKey(shop))
                {
                    dict[shop] = new Dictionary<string, double>();
                }

                
                if (!dict[shop].ContainsKey(product))
                {
                    dict[shop][product] = price;
                }
                dict[shop][product] = price;

            }
            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key}->");
                foreach(var shops in item.Value)
                {
                    Console.WriteLine($"Product: {shops.Key}, Price: {shops.Value}");
                }
            }
  
           
        }
    }
}
