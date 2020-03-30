using System;
using System.Collections.Generic;
using System.Text;

namespace BoxOfT
{
   public class  Box <T>
    {
        public Stack<T> data = new Stack<T>();
        public void Add(T elemnent)
        {
            data.Push(elemnent);
        }
        public  T Remove()
        {
            return data.Pop();
        }
        public int Count
        {
            get
            {
                return this.data.Count;
            }
        }
    }
}
