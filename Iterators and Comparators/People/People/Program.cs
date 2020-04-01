using System;
using System.Collections.Generic;

namespace People
{
  public class Program
    {
      public static void Main(string[] args)
        {

            Person personOne = new Person("Pesho", 23, "Vraca");
            Person personTwo= new Person("Gosho", 31, "Sofia");
            Person personThree = new Person("Ivan", 36, "Stara Zagora");
            Person personFour = new Person("Vladi", 29, "Vraca");
            Person personFive = new Person("Boiko", 25, "Krepost");
            

            People listOFpeople = new People();
            listOFpeople.AddMembers(personOne);
            listOFpeople.AddMembers(personTwo);
            listOFpeople.AddMembers(personThree);
            listOFpeople.AddMembers(personFour);
            listOFpeople.AddMembers(personFive);

            foreach (var item in listOFpeople)
            {
                Console.Write($"{item.Name} {item.Age} {item.City}");
                Console.WriteLine();
            }

        }
    }
}
