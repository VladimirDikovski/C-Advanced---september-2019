using System;
using System.Collections.Generic;
using System.Linq;

namespace MatrixMultiplication
{
    class Program
    {
        static void Main(string[] args)
        {
         
            int[,] matrixi1 = new int[3, 3];
            int[,] matrixi2 = new int[3, 3];
           
            Console.WriteLine("Input Element of the first Matrix ");
            matrixi1 = InputElementsInMatrix(matrixi1);
            Console.WriteLine();
            Console.WriteLine("Input Element of the second Matrix ");
            matrixi2 = InputElementsInMatrix(matrixi2);
            Console.WriteLine();
            Console.WriteLine("firstMatrix" );
            PrintMaxtrix(matrixi1);
            Console.WriteLine();
            Console.WriteLine("secondMatrix");
            PrintMaxtrix(matrixi2);
            MatrixMultiplication(matrixi1, matrixi2);
        }

        private static void MatrixMultiplication(int[,] matrixi1, int[,] matrixi2)
        {
            int[,] resultMatrix = new int[3, 3];
           
            for (int rol = 0; rol < matrixi1.GetLength(0); rol++)
            {
                for (int col = 0; col < matrixi2.GetLength(1); col++)
                {
                    resultMatrix[rol,col] = matrixi1[rol,col] * matrixi2[col, rol];
                   
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Result of multiplication of matrix is");
            PrintMaxtrix(resultMatrix);
        }

      

        private static void PrintMaxtrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row,col]+" ");
                }
                Console.WriteLine();

            }
        }

        private static int[,] InputElementsInMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] elements = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = elements[col];
                }
            }
            return matrix;
        }
          
    }
    
}
