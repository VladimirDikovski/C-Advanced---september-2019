using System;
using System.Collections.Generic;
using System.Text;

namespace GenericScale
{
   public class EqualityScale<T> where T : IComparable<T>
    {
        private T left;
        private T right;

        public EqualityScale(T left ,T right)
        {
            this.left = left;
            this.right = right;
        }
      public T AreEqual()
        {
            var comparison = left.CompareTo(right);

            if (comparison > 0)
            {
                return left;
            }
            else if (comparison < 0)
            {
                return right;
            }

            return default(T);

        }
    }
}
