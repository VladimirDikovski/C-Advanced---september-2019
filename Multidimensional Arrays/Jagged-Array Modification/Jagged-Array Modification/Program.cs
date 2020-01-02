using System;
using System.Linq;

namespace Jagged_Array_Modification
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[][] jaggedArray = new int[size][];
            InputElements(jaggedArray, size);
            ModificationArray(jaggedArray);
            PrintResult(jaggedArray);
        }

        private static void PrintResult(int[][] jaggedArray)
        {

            for (int row = 0; row < jaggedArray.Length; row++)
            {
                for (int index = 0; index < jaggedArray[row].Length; index++)
                {
                    Console.Write(jaggedArray[row][index]+" ");
                }
                Console.WriteLine();
            }
        }

        private static void ModificationArray(int[][] jaggedArray)
        {
            while (true)
            {
                string[] input = Console.ReadLine().Split(" ");
                string command = input[0];
                if (command == "END")
                {
                    break;
                }
                int arayNomber = int.Parse(input[1]);
                int elementIndex = int.Parse(input[2]);
                int value = int.Parse(input[3]);
                if(IsValid(jaggedArray, arayNomber, elementIndex))
                {
                    if (command == "Add")
                    {
                        jaggedArray[arayNomber][elementIndex] += value;

                    }
                    else if (command == "Subtract" && IsValid(jaggedArray, arayNomber, elementIndex))
                    {
                       jaggedArray[arayNomber][elementIndex] -= value;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid coordinates");
                }
             
            }
        }

        private static bool IsValid(int[][] jaggedArray, int arayNomber, int elementIndex)
        {
            return arayNomber >= 0 && arayNomber < jaggedArray.Length
                && elementIndex >= 0 && elementIndex < jaggedArray.Length;
        }

        private static void InputElements(int[][] jaggedArray, int size)
        {
            for (int row = 0; row < jaggedArray.Length; row++)
            {
               
                jaggedArray[row] = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            }
        }
    }
}
