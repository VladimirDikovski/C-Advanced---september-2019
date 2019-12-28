using System;
using System.Collections.Generic;
using System.Linq;

namespace Truck_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberPetrolPump = int.Parse(Console.ReadLine());
            var stackPetrol = new Queue<int>();
            var distance = new Queue<int>();

            for (int i = 0; i < numberPetrolPump; i++)
            {
                int[]digit = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                  stackPetrol.Enqueue(digit[0]);
                   distance.Enqueue(digit[1]);
              

            }
           
            
        }
    }
}
