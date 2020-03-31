using System;
using System.Collections.Generic;

namespace IteratorsAndComparators
{
   public class Program
    {
       public static void Main(string[] args)
        {

            Book bookOne = new Book("1984", 1920, "Pesho", "Gosho", "Vlad4i");
            Book bookTwo = new Book("The Lord of the rings", 1854, "J.R Tolkin");
            Book bookThree = new Book("The pussy is a great", 2000);

            Library libaroOne = new Library();
            Library libaryTwo = new Library(bookOne, bookTwo, bookThree);

            foreach (var item in libaryTwo)
            {
              Console.WriteLine($"{string.Join(", ",item.Authors)} {item.Title} {item.Year}");
              
            }
        }
    }
}
