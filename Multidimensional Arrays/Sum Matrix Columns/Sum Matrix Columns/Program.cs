using System;
using System.Linq;
using System.Collections.Generic;

namespace Sum_Matrix_Columns
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ColsAndRows = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int rols = ColsAndRows[0];
            int cols = ColsAndRows[1];
            int[,] matrix = new int[rols, cols];
            var sumOfColons = new List<int>();
            InputElementsInMatrix(rols, cols, matrix);
            FindSumOfColons(matrix, rols, cols,sumOfColons);
            PrintElements(sumOfColons);
        }

        private static void PrintElements(List<int> sumOfColons)
        {
            foreach (var items in sumOfColons)
            {
                Console.WriteLine(items);
            }
        }

        private static List<int> FindSumOfColons(int[,] matrix, int rols, int cols,List<int>sumOfColons)
        {
            
            int sum = 0;
            for (int col = 0; col < cols; col++)
            {
                for (int rol = 0; rol < rols; rol++)
                {
                    sum += matrix[rol, col];
                }
                sumOfColons.Add(sum);
                sum = 0;
            }
            return sumOfColons;
        }

        private static int[,] InputElementsInMatrix(int rols, int cols, int[,] matrix)
        {
            for (int rol = 0; rol <rols; rol++)
            {
                int[] elements = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[rol, col] = elements[col];
                }
            }
            return matrix;
        }
    }
}
