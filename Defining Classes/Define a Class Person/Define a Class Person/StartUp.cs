using System;

namespace DefiningClasses
{
  public class StartUp
    {
       public static void Main(string[] args)
        {
            var person = new Person();
            person.Name = "Pesho";
            person.Year = 2000;

            Console.WriteLine($"{person.Name} {person.Year}");
        }
    }
}
