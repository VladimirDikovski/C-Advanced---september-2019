using System;
using System.Collections.Generic;
using System.Linq;

namespace Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            var clients = new Queue<string>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }
                else if (input == "Paid")
                {
                    while (clients.Count>0)
                    {
                        var nextClient = clients.Dequeue();
                        Console.WriteLine(nextClient);
                    }
                }
                else
                {
                    clients.Enqueue(input);
                }
            }
            Console.WriteLine($"{clients.Count} people remaining.");
        }
    }
}
