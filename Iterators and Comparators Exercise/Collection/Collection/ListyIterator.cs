using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Collection
{
   public class ListyIterator <T> :IEnumerable<T>
    {
        private List<T> collection;
        private int index;

        public ListyIterator()
        {

        }
        public ListyIterator(List<T> collection)
        {
            this.collection = new List<T>(collection);
        }

        public bool Move()
        {
           
            if (index < collection.Count-1)
            {
               index++;
                return true;
            }
          
                return false;         
        }

        public bool HasNext()
        {
            if (this.index == collection.Count-1 || this.index>collection.Count)
            {
                return false;
            }
            return true;
        }
        public string Print()
        {
            if (collection.Count < 1)
            {
                throw new ArgumentException("Invalid Operation!");
            }
            return $"{collection[index]}";

        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < collection.Count; i++)
            {
                yield return collection[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
