using System;
using System.Collections.Generic;
using System.Linq;


namespace Cups_and_Bottles
 
{
    class Program
    {
        static void Main(string[] args)
        {
            var queenOFCups = new Queue<int>(Console.ReadLine().Split(" ").Select(int.Parse));
            var stackOFBottle =new Stack<int>(Console.ReadLine().Split(" ").Select(int.Parse));
            int wastedWater = 0;
            FillCups(queenOFCups, stackOFBottle, wastedWater);
            


        }

        private static void PrintRemaintBottleOrCups(Queue<int> queenOFCups, Stack<int> stackOFBottle, int wastedWater)
        {
            if (queenOFCups.Count > 0)
            {
                Console.WriteLine($"Cups: {string.Join(" ",queenOFCups)}");
                Console.WriteLine($"Wasted litters of water: { wastedWater}");
            }
            else 
            {
                Console.WriteLine($"Bottles: {string.Join(" ", stackOFBottle)}");
                Console.WriteLine($"Wasted litters of water: { wastedWater}");
            }
        }

        private static void FillCups(Queue<int> queenOFCups, Stack<int> stackOFBottle, int wastedWater)
        {
            while (queenOFCups.Count > 0 && stackOFBottle.Count > 0)
            {
                int currentBottle = stackOFBottle.Peek();
                int currentCups = queenOFCups.Peek();
                if (currentBottle >= currentCups)
                {
                    wastedWater += currentBottle - currentCups;
                    queenOFCups.Dequeue();
                    stackOFBottle.Pop();
                }
                else
                {
                    while (currentCups>currentBottle)
                    {
                        currentCups -= currentBottle;
                        stackOFBottle.Pop();
                        currentBottle = stackOFBottle.Peek();
                    }
                    wastedWater += currentBottle - currentCups;
                    queenOFCups.Dequeue();
                    stackOFBottle.Pop();
                }
            }
            PrintRemaintBottleOrCups(queenOFCups, stackOFBottle, wastedWater);
            
        }
    }
}
