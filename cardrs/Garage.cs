using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cardrs
{
    public class Garage
    {
        public int NumOfCars { get; set; } = 10;
        public List<Car> Cars { get; } = new List<Car>();

        public Garage() { }

        public Garage(List<Car> cars)
        {
            Cars = cars;
        }

        public bool AddCar(Car c)
        {
            if (Cars.Count < NumOfCars)
            {
                Cars.Add(c);
                return true;
            }
            return false;
        }
        public List<Car> Search(Func<Car, bool> predicate)
        {
            List<Car> result = new List<Car>();
            foreach (var car in Cars)
            {
                if (predicate(car))
                    result.Add(car);
            }
            return result;
        }
    }
}