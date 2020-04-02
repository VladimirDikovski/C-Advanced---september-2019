using System;
using System.Collections.Generic;
using System.Linq;

namespace Froggy
{
   public class StartUp
    {
       public static void Main(string[] args)
        {
            List<int> inputStones = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse).ToList();
            Lake NewLake = new Lake(inputStones);

            Console.WriteLine(String.Join(", ", NewLake));
        }
    }
}
