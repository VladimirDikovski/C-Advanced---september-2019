using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace Even_Lines
{
    class Program
    {
        static void Main(string[] args)
        {
            var reader = new StreamReader(@"..\..\..\..\text.txt");
            var writter = new StreamWriter("Output.txt");
            var ReverseString = new Stack<string>();

            using (reader)
            {
                using (writter)
                {
                    int lineCount = 0;
                    while (!reader.EndOfStream)
                    {
                        string firstText = reader.ReadLine();
                        firstText = firstText.Replace("-", "@").Replace(",", "@").Replace(".", "@").Replace("!", "@").Replace("?", "@");
  
                        string [] text = firstText.Split(" ");
                       
                       
                        if (lineCount % 2 == 0)
                        {
                            for (int i = 0; i < text.Length; i++)
                            {
                                ReverseString.Push(text[i]);
                                
                            }
                            while (ReverseString.Count > 0)
                            {
                                writter.Write(ReverseString.Pop() + " ");
                            }
                                                        
                            writter.WriteLine();
                        }
                        lineCount++;
                    }
                }
               
            }
        }
    }
}
