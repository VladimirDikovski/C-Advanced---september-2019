using System;
using System.Linq;

namespace Miner
{
   
    class Program
    {
        static char[,] matrix;
        static int coals;
        static int starttRow;
        static int starttCol;
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            string[] directions = Console.ReadLine().Split(" ");
            matrix = new char [size, size];
            InpitElements();
           
            foreach (var item in directions)
            {
                switch (item)
                {
                    case "left":
                        Moves(0, -1);
                        break;
                    case "right":
                        Moves(0, +1);
                        break;
                    case "up":
                        Moves(-1, 0);
                        break;
                    case "down":
                        Moves(+1, 0);
                        break;

                }
            }
            Console.WriteLine($"{coals} coals left. ({starttRow}, {starttCol})");

        }

        private static void Moves(int row, int col)
        {
           
            if(isValid(starttRow+row,starttCol+col))
            {
                starttRow += row;
                starttCol += col;

                if(matrix[starttRow,starttCol]=='e')
                {
                    Console.WriteLine($"Game over! ({starttRow}, {starttCol})");
                    System.Environment.Exit(0);
                }
                else if(matrix[starttRow, starttCol] == 'c')
                {
                    coals--;
                    matrix[starttRow,starttCol] = '*';
                    if (coals == 0)
                    {
                        Console.WriteLine($"You collected all coals! ({starttRow}, {starttCol})");
                        System.Environment.Exit(0);
                    }
                }
            }
        }

        private static bool isValid(int starttRow, int starttCol)
        {
            return starttRow >= 0 && starttRow < matrix.GetLength(0) && starttCol >= 0
                && starttCol < matrix.GetLength(1);
        }

        private static void InpitElements()
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] elements = Console.ReadLine().Split(" ").Select(char.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = elements[col];
                    if (matrix[row,col] == 'c')
                    {
                        coals++;
                    }
                    if (matrix[row, col] == 's')
                    {
                        starttRow = row;
                        starttCol = col;
                    }
                }
            }
        }
    }
}
