
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
            List<Car> cars = new List<Car>() {
                    new Car { Idd = 1, Name = "Oil Filter", Company = "Toyota", Supplier = "YossiParts", Price = 150 },
            new Car { Idd = 2, Name = "Tire", Company = "Mazda", Supplier = "Michelin", Price = 600 },
            new Car { Idd = 3, Name = "Battery", Company = "Toyota", Supplier = "YossiParts", Price = 550 }
            };

            var michelinParts = SearchCars(cars, c => c.Supplier == "Michelin");

           
            var toyotaParts = SearchCars(cars, c => c.Company == "Toyota");
            var yossiToyota = SearchCars(cars, c => c.Supplier == "YossiParts" && c.Company == "Toyota");



            var expensiveToyota = SearchCars(cars, c => c.Company == "Toyota" && c.Price > 500);

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

