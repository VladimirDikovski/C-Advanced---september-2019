using System;
using System.Collections.Generic;
using System.Linq;

namespace Fast_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            int quontityFood = int.Parse(Console.ReadLine());
            var orders = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            var ordersqueue = new Queue<int>(orders);
            int maxValue = orders.Max();
           
            while (true)
            {
                if (ordersqueue.Count > 0)
                {
                    int nextOrder = ordersqueue.Peek();
                    if (nextOrder <= quontityFood)
                    {
                        quontityFood -= nextOrder;
                        ordersqueue.Dequeue();
                    }
                    else
                    {
                        break;
                    }
                    
                }
                else
                {
                    break;
                }
               
            }
            if (ordersqueue.Count == 0)
            {
                Console.WriteLine(maxValue);
                Console.WriteLine("Orders complete");
            }
            else
            {
                Console.WriteLine(maxValue);
                Console.WriteLine($"Orders left: {string.Join(" ", ordersqueue)}");
            }

        }
    }
}
