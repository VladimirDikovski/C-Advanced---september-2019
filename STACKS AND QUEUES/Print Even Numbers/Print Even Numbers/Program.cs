using System;
using System.Collections.Generic;
using System.Linq;

namespace Print_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var digit = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            var queues = new Queue<int>();
            TakeEvenNumber(digit, queues);
            PrintResult(queues);
          
        }

        private static void PrintResult(Queue<int> queues)
        {
            Console.WriteLine(string.Join(", ",queues));
        }

        private static Queue<int> TakeEvenNumber(int[] digit, Queue<int> queues)
        {
            for (int i = 0; i < digit.Length; i++)
            {
                if (digit[i] % 2 == 0)
                {
                    queues.Enqueue(digit[i]);
                }
            }
            return queues;
        }
    }
}
