
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;


namespace cardrs
{
    class Program
    {
        public static int CompareStuByCompany(Car s1, Car s2)
            => string.Compare(s1.Company, s2.Company);
        public static List<Car> SearchCars(List<Car> cars, Func<Car, bool> condition)
        {
            List<Car> result = new List<Car>();
            foreach (var car in cars)
            {
                if (condition(car))
                    result.Add(car);
            }
            return result;
        }
    


    static void Main(string[] args)
        {
            Garage garage = new Garage();
            garage.AddCar(new Car(1, "Oil Filter", "Toyota", "YossiParts", 150));
            garage.AddCar(new Car(2, "Tire", "Mazda", "Michelin", 600));
            garage.AddCar(new Car(3, "Battery", "Toyota", "YossiParts",500));


            var michelinParts = garage.Search( c => c.Supplier == "Michelin");

           
            var toyotaParts = garage.Search( c => c.Company == "Toyota");
            var yossiToyota = garage.Search( c => c.Supplier == "YossiParts" && c.Company == "Toyota");



            var expensiveToyota = garage.Search(c => c.Company == "Toyota" && c.Price > 500);

            Console.WriteLine("Michelin parts:");
            michelinParts.ForEach(c => Console.WriteLine($"{c.Name} - {c.Company} - {c.Supplier} - {c.Price}"));

            Console.WriteLine("\nToyota parts:");
            toyotaParts.ForEach(c => Console.WriteLine($"{c.Name} - {c.Company} - {c.Supplier} - {c.Price}"));

            Console.WriteLine("\nExpensive Toyota parts:");
            expensiveToyota.ForEach(c => Console.WriteLine($"{c.Name} - {c.Company} - {c.Supplier} - {c.Price}"));

            //Array.Sort(cars, Program.CompareStuByCompany);

            //foreach (var c in cars)
            //    Console.WriteLine($"{c.Name} - {c.Company} - {c.Supplier}");
            Console.ReadLine();
        }
    }
}

