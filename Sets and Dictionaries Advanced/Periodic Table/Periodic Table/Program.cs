using System;
using System.Collections.Generic;
using System.Linq;


namespace Periodic_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int nElements = int.Parse(Console.ReadLine());
            var chemicalElements = new SortedSet<string>();
            PutElements(nElements, chemicalElements);
            PrinElements(chemicalElements);
        }

        private static void PrinElements(SortedSet<string> chemicalElements)
        {
            Console.Write(string.Join(" ",chemicalElements));
        }

        private static void PutElements(int nElements, SortedSet<string> chemicalElements)
        {
            for (int i = 0; i < nElements; i++)
            {
                string[]Elements  = Console.ReadLine().Split(" ");
                for (int j   = 0; j < Elements.Length; j++)
                {
                    chemicalElements.Add(Elements[j]);
                }
            }
        }
    }
}
