using System;
using System.IO;

namespace Slice_a_File
{
    class Program
    {
        static void Main(string[] args)
        {
            var filesInfo = new FileInfo("sliceMe.txt");
            var SizePerfile = (int)Math.Ceiling(filesInfo.Length / 5.0);
            using (var r =new FileStream("SliceMe.txt", FileMode.Open))
            {
                for (int i = 1; i <= 5; i++)
                {
                    var buffer = new byte[SizePerfile];
                    var readBytes = r.Read(buffer, 0, SizePerfile);
                    using(var w =new FileStream($"file-{i}.txt", FileMode.OpenOrCreate))
                    {
                        w.Write(buffer, 0, readBytes);
                    }

                }
                
                
            }

        }
    }
}
