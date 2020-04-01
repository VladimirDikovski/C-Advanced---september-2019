using System;
using System.Collections.Generic;

namespace Stack
{
   public class StartUp
    {
      public static void Main(string[] args)
        {
            Stack newStack = new Stack();
            while (true)
            {
                string []input = Console.ReadLine().Split( new char[]{' ',','},StringSplitOptions.RemoveEmptyEntries);
                string command = input[0];
                if (command == "Push")
                {
                    InputElements(input,newStack);
                }
                else if(command== "Pop")
                {
                    newStack.Pop(); 
                }
                else if (command == "END")
                {
                    foreach (var item in newStack)
                    {
                        Console.WriteLine(item);
                    }
                    foreach (var item in newStack)
                    {
                        Console.WriteLine(item);
                    }
                    break;
                }
            }
        }

        private static void InputElements(string[] input,Stack NewStack)
        {
            for (int i = 1; i < input.Length; i++)
            {
                NewStack.Push(int.Parse(input[i]));
            }
        }
    }
}
