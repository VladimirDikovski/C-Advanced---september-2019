using System;
using System.Collections.Generic;
using System.Linq;

namespace Basic_Queue_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            var comand = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            var diggits = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            var queue = new Queue<int>();

            AddAndRemove(comand, diggits, queue);
        }



        private static void AddAndRemove(int[] comand, int[] diggits, Queue<int> queue)
        {
            int add = comand[0];
            int delete = comand[1];
            int containtElement = comand[2];

            PushElementsInQueue(add, queue, diggits);
            PoopElementInQueue(delete, queue);
            if (queue.Count > 0)
            {
                IsContainElemnt(containtElement, queue);
            }
            else
            {
                Console.WriteLine(0);
            }
        }

        private static void IsContainElemnt(int containtElement, Queue<int> queue)
        {
            if (queue.Contains(containtElement))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(queue.Min());
            }
        }

        private static Queue<int> PoopElementInQueue(int delete, Queue<int> queue)
        {
            for (int i = 0; i < delete; i++)
            {
                queue.Dequeue();
            }
            return queue;
        }

        private static Queue<int> PushElementsInQueue(int add, Queue<int> queue, int[] diggits)
        {
            for (int i = 0; i < add; i++)
            {
                queue.Enqueue(diggits[i]);
            }
            return queue;
        }
    }
}