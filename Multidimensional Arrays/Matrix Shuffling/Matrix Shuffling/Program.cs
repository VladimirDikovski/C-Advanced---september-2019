using System;
using System.Linq;

namespace Matrix_Shuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimension = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int rows = dimension[0];
            int cols = dimension[1];
            string[,] matrix = new string[rows, cols];
            InputElements(matrix);
            SwatElementsInMatrix(matrix);
            

        }

        private static void SwatElementsInMatrix(string[,] matrix)
        {
            bool isValidCordinati = false;
            while (true)
            {
                string[] commands = Console.ReadLine().Split(" ");
                string swap = commands[0];
                if (commands[0] == "END")
                {
                    break;
                }
                if (commands.Length!= 5)
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }
                if (swap != "swap")
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }
                
                int row1 = int.Parse(commands[1]);
                int col1 = int.Parse(commands[2]);
                int row2 = int.Parse(commands[3]);
                int col2 = int.Parse(commands[4]);
                 isValidCordinati= iIsValid(row1, col1, row2, col2, matrix);
                if (!isValidCordinati)
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }

                MatrixSwap(matrix, row1, col1, row2, col2);

            }
        }

        private static void MatrixSwap(string[,] matrix, int row1, int col1, int row2, int col2)
        {
            string Temp = matrix[row1,col1];
            matrix[row1, col1] = matrix[row2, col2];
            matrix[row2, col2] = Temp;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
               
                for (int col = 0; col < matrix.GetLength(1); col++)
                {       
                   Console.Write(matrix[row,col]+" ");
                }
                Console.WriteLine();
            }


        }

        private static bool iIsValid(int row1, int col1, int row2, int col2,string[,]matrix)
        {
            return  row1 >= 0 && row1 < matrix.GetLength(0) && col1 >= 0 && col1 < matrix.GetLength(1) &&
                   row2 >= 0 && row1 < matrix.GetLength(0) && col1 >= 0 && col2 < matrix.GetLength(1);
        }

        private static void InputElements(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] elements = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = elements[col];
                }
            }
        }
    }
}
