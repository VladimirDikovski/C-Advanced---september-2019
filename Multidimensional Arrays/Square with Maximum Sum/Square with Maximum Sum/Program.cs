using System;
using System.Linq;

namespace Square_with_Maximum_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizeOfMatrix = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int rows = sizeOfMatrix[0];
            int cols = sizeOfMatrix[1];
            int[,] matrix = new int[rows, cols];
            ReadTheMatrix(matrix);
            Find2X2sumElements(matrix);
        }

        private static void Find2X2sumElements(int[,] matrix)
        {
            
            int maxValue = int.MinValue;
            int rowMax = 0;
            int colMax = 0;
            for (int rol = 0; rol < matrix.GetLength(0)-1; rol++)
            {
                
                for (int col = 0; col < matrix.GetLength(1)-1; col++)
                {
                    int sumOf2X2 = 0;
                    sumOf2X2 += matrix[rol, col] + matrix[rol, col + 1] + matrix[rol + 1, col] + matrix[rol + 1, col + 1];
                    if (sumOf2X2 > maxValue)
                    {
                        maxValue = sumOf2X2;
                        rowMax = rol;
                        colMax = col;
                    }
                   
                }
            }
            Console.WriteLine($"{matrix[rowMax,colMax]} {matrix[rowMax, colMax+1]}");
            Console.WriteLine($"{matrix[rowMax+1, colMax]} {matrix[rowMax+1, colMax + 1]}");
            Console.WriteLine(maxValue);
        }

        private static int[,] ReadTheMatrix(int[,] matrix)
        {
            for (int rol = 0; rol < matrix.GetLength(0); rol++)
            {
                int[] elements = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[rol, col] = elements[col];
                }
            }

            return matrix;
        }
    }
}
