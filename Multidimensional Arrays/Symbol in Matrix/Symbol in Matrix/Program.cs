using System;
using System.Linq;

namespace Symbol_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeOfMatrix = int.Parse(Console.ReadLine());
            char[,] Symbols = new char[sizeOfMatrix, sizeOfMatrix];
            InputInMatrix(Symbols);
            char searchingSymbol = char.Parse(Console.ReadLine());
            FindSymbolInMatrix(Symbols, searchingSymbol);
        }

        private static void FindSymbolInMatrix(char[,] symbols, char searchingSymbol)
        {
            bool isFound = false;
            int indexRol = 0;
            int indexCol =0;
            for (int rol = 0; rol < symbols.GetLength(0); rol++)
            {
               
                for (int col = 0; col < symbols.GetLength(1); col++)
                {
                    if (symbols[rol, col] == searchingSymbol)
                    {
                        isFound = true;
                        indexRol = rol;
                        indexCol = col;
                        break;
                    }
                }
                if (isFound)
                {
                    break;
                }
            }
            if (isFound)
            {
                Console.WriteLine($"({indexRol}, {indexCol})");
            }
            else
            {
                Console.WriteLine($"{searchingSymbol} does not occur in the matrix ");
            }
        }

        private static char[,] InputInMatrix(char[,] symbols)
        {
            for (int rol = 0; rol < symbols.GetLength(0); rol++)
            {
                string elements = Console.ReadLine();
                for (int col = 0; col < symbols.GetLength(1); col++)
                {
                    symbols[rol, col] = elements[col];
                }
            }
            return symbols;
        }
    }
}
