using System;
using System.Collections.Generic;
using System.Linq;

namespace IteratorsAndComparators
{
    class Program
    {
        static void Main(string[] args)
        {
            Book bookOne = new Book("Animal Farm", 2003, "George Orwell");
            Book bookThree = new Book("The Documents in the Case", 1930);
            Book bookTwo = new Book("The Documents in the Case", 2003, "Dorothy Sayers", "Robert Eustace");
          

            Library libraryOne = new Library();
            Library libraryTwo = new Library(bookOne, bookTwo, bookThree);

            
            foreach (var item in libraryTwo)
            {
                Console.WriteLine(item);
            }

            

        }
    }
}
