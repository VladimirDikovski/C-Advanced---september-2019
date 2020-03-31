using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Cars
{
   public class CarCatalog: IEnumerable<Car>
    {
        private List<Car> cars;
        

        public CarCatalog(params Car[] cars)
        {
            this.cars = new List<Car>(cars);
        }


        public IEnumerator<Car> GetEnumerator()
        {
            for (int i = cars.Count-1; i >= 0; i--)
            {
                yield return cars[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

  
}
