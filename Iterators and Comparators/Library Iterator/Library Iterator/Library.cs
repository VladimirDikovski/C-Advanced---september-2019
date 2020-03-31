using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace IteratorsAndComparators
{
   public class Library: IEnumerable<Book>
    {
        private List<Book> books;

        public Library(params Book[] books)
        {
            this.books = new List<Book>(books);
        }

        public IEnumerator<Book> GetEnumerator()
        {
            return new LibraryIterator(books);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public class LibraryIterator : IEnumerator<Book>
        {
            private List<Book> books;
            private int curentIndex =-1;
            public LibraryIterator(List<Book> books)
            {
                this.books = books;
            }
            public Book Current
            {
                get
                {
                    return this.books[curentIndex];
                }
            }

            object IEnumerator.Current =>this.Current;

            public void Dispose()
            {
                
            }

            public bool MoveNext()
            {
                this.curentIndex++;
                if (curentIndex >= books.Count)
                {
                    return false;
                }
                return true;
            }

            public void Reset()
            {
                this.curentIndex = -1;
            }
        }
    }

}
