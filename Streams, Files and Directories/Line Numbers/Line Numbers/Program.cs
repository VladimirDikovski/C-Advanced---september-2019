using System;
using System.IO;

namespace Line_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var reader = new StreamReader("Input.txt"))
            {
                using (var writter = new StreamWriter("Output.txt"))
                {
                    int index = 1;
                    while (true)
                    {
                        var line = reader.ReadLine();

                        if (line == null)
                        {
                            break;
                        }
                        writter.WriteLine($"{index} {line}");
                       
                        index++;
                    }
                }
                
            }
        }
    }
}
