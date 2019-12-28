using System;
using System.Collections.Generic;
using System.Linq;

namespace Fashion_Boutique
{
    class Program
    {
        static void Main(string[] args)
        {
            var clothes = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int capacityOfRack = int.Parse(Console.ReadLine());
            var stack = new Stack<int>(clothes);
            int sumClothes = 0;
            int countRack = 1;

            while (true)
            {
                if (stack.Count > 0)
                {
                    sumClothes += stack.Peek();
                    if (sumClothes <= capacityOfRack)
                    {
                        stack.Pop();
                    }
                    else
                    {
                        countRack++;
                        sumClothes = 0;
                    }
                }
                else
                {
                    break;
                }
               
            }
            Console.WriteLine(countRack);

        }
    }
}
