using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Simple_Text_Editor
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOperation = int.Parse(Console.ReadLine());
            string text = string.Empty;
            var stack = new Stack<string>();
            
            for (int i = 0; i < countOperation; i++)
            {
                var currentElemnt = Console.ReadLine().Split();
                var command = currentElemnt[0];
                switch (command)
                {
                    case "1":
                         text = AddText(currentElemnt,text);
                        stack.Push(text);
                        break;
                    case "2":
                        text = RemoveElemnts(currentElemnt, text);
                        stack.Push(text);
                        break;
                    case "3":
                        ReturnElement(currentElemnt, text);
                         break;
                    case "4":
                        
                       text = UndoOperation(stack, text);
                        break;
                }            
            }
        }

        private static string UndoOperation(Stack<string> stack, string text)
        {
            stack.Pop();
            if (stack.Count > 0)
            {
                text = stack.Peek();
            }
            else
            {
                text = string.Empty;
            }
            return text;

        }

        private static string RemoveElemnts(string[] currentElemnt, string text)
        {
            int countElemnts = int.Parse(currentElemnt[1]);
           
                for (int i = countElemnts; i > 0; i--)
                {
                    text = text.Remove(text.Length - 1);
                }
           
            return text;
        }

        private static void ReturnElement(string[] currentElemnt, string text)
        {
            var index = int.Parse(currentElemnt[1]);
           
                Console.WriteLine(text[index - 1]);
          
        }  

        private static string AddText(string[] currentElemnt, string text)
        {
            StringBuilder str = new StringBuilder();
            str.Append(currentElemnt[1]);
            text += str;
            return text;

        }
    }
}
