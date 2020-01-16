using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace Word_Count2
{
    class Program
    {
        static void Main(string[] args)
        {
            var readWords = new StreamReader(@"../../../words.txt");
            var Word = new Dictionary<string, int>();
            using (readWords)
            {
                while (!readWords.EndOfStream)
                {
                    string[] line = readWords.ReadLine().ToLower().Split(" ");
                    foreach (var item in line)
                    {
                        if (!Word.ContainsKey(item))
                        {
                            Word[item] = 0;
                        }
                    }
                }
               
             }
            var readText = new StreamReader(@"../../../text.txt");
            using (readText)
            {
              
                while (!readText.EndOfStream)
                {
                    string SplitSymbols = " ";
                    string line = readText.ReadLine();
                    foreach (var item in line)
                    {
                        if (char.IsPunctuation(item)&& item!='\'')
                        {
                            SplitSymbols += item;
                        }
                    }

                    string[] elements = line.ToLower().Split(SplitSymbols.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                    foreach (var word in elements)
                    {
                        if (Word.ContainsKey(word))
                        {
                            Word[word]++;
                        }
                    }
                }
                            
            }
            Word = Word.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, y => y.Value);
            var Writter = new StreamWriter(@"../../../Output.txt");
            var ReaderexpectedResul = new StreamReader(@"../../../expectedResult.txt");
            using (ReaderexpectedResul)
            {
                bool isEqual = true;

                foreach (var item in Word)
                {
                    string Result = $"{item.Key } - {item.Value}";
                    string line = ReaderexpectedResul.ReadLine();
                    if (Result != line)
                    {
                        isEqual = false;
                        break;
                    }
                }
             
                if (isEqual)
                {
                    Console.WriteLine("True");
                }
                else
                {
                    Console.WriteLine("False");
                }
                
            }
            using (Writter)
            {

                foreach (var item in Word)
                {
                    Writter.WriteLine($"{item.Key } - {item.Value}");
                }
            }


        }
    }
}
