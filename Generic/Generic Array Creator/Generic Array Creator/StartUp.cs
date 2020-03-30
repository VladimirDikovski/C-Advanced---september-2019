using System;

namespace GenericArrayCreator
{
  public  class StartUp
    {
      public  static void Main(string[] args)
        {
            int[] massiv = ArrayCreator.Create<int>(5, 5);
            string[] stringMasiv = ArrayCreator.Create<string>(5, "Pesho");
        }
    }
}
