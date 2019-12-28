using System;
using System.Collections.Generic;
using System.Linq;

namespace Balanced_Parentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            string currentInput = Console.ReadLine();
            var SymbolStack = new Stack<char>();
            if (currentInput.Length % 2 != 0)
            {
                Console.WriteLine("NO");
                return;
            }
            for (int i = 0; i < currentInput.Length; i++)
            {
                var symbol = currentInput[i];
                if (symbol == '{'||symbol=='('||symbol=='[')
                {
                    SymbolStack.Push(symbol);
                }
                else
                {
                    var lastBrakets = SymbolStack.Pop();
                    if (symbol == ')' && lastBrakets != '(')
                    {
                        Console.WriteLine("NO");
                        return;
                    }
                    else if (symbol == ']' && lastBrakets != '[')
                    {
                        Console.WriteLine("NO");
                        return;
                    }
                    else if (symbol == '{' && lastBrakets != '}')
                    {
                        Console.WriteLine("NO");
                        return;
                    }
                }
                
            }
            if (SymbolStack.Count == 0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }

        }
    }
}
