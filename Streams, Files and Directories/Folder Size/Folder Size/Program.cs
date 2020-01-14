using System;
using System.IO;

namespace Folder_Size
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] files = Directory.GetFiles("TestFolder");
            double sum = 0;
            foreach (var file in files)
            {
                var fileInfo = new FileInfo(file);
                sum += fileInfo.Length;
            }

            sum = sum / 1024 / 1024;
            File.WriteAllText("output.txt", sum.ToString());
           
        }
    }
}
