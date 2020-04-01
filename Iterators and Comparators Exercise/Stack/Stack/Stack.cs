using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Stack
{
   public class Stack : IEnumerable<int>
    {
        private List<int> elements;

       
        public Stack()
        {
            this.elements = new List<int>();
        }

        public void Push(int digit )
        {
            elements.Add(digit);
        }
        public void Pop()
        {
          
            if (elements.Count < 1)
            {
                Console.WriteLine("No elements");
                return;
            } 
           int lastElements = elements[elements.Count - 1];
            elements.Remove(lastElements);
            
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = elements.Count-1; i >= 0; i--)
            {
                yield return elements[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
