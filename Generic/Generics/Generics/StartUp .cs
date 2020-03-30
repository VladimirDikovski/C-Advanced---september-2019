using System;

namespace BoxOfT
{
    public class StartUp
    {
      public   static void Main(string[] args)
        {
            var list = new Box<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            Console.WriteLine(list.Remove());
            list.Add(4);
            list.Add(5);
            Console.WriteLine(list.Remove());

        }
    }
}
