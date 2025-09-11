using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace cardrs
{

    public class Program

    {
        static void Main(string[] args)
        {
            Car[] cars = {
    new Car { Id = "123456789", Name="Ford Focus", Date = new DateTime(2009, 1, 1), Color=ConsoleColor.Red, Price = 35000m },
    new Car { Id = "3678952148", Name="Honda Civic", Date = new DateTime(2020, 1, 1), Color= ConsoleColor.Black, Price = 85000m},
    new Car { Id = "102782022", Name="Toyota Corolla", Date = new DateTime(2019, 1, 1), Color=ConsoleColor.Yellow, Price = 95000m}
};
            //שאילתה ראשונה שליפת רכב ששנת היצור גדולה מ2019
            //            Car[] crecentCars = (from c in cars
            //                                 where c.Date.Year > 2019
            //                                 select new Car() { Id = c.Id, Name = c.Name, Date = c.Date }).ToArray();

            //            foreach (var car in crecentCars)
            //            {
            //                Console.WriteLine($"Id: {car.Id}, Name: {car.Name}, Year: {car.Date.Year}");
            //                Console.ReadLine();
            //            }
            //        }
            //    }
            //}
            //שליפת רכב שהצבע שלו אדום שאילתה שניה
            //            Car[] createcolor = (from c in cars
            //                                 where c.Color == ConsoleColor.Red
            //                                 select c).ToArray();
            //            foreach (var car in createcolor)
            //            {
            //                Console.WriteLine($"Id: {car.Id}, Year: {car.Date.Year}, Color: {car.Color.ToString()}");
            //                Console.ReadLine();
            //            }

            //        }
            //    }
            //}

            //            // שאילתה שלישית - שליפת רכב ששם החברה מתחיל ב-T
            //            var CreateName = (from c in cars
            //                              where c.Name.StartsWith("T")
            //                              select new { c.Name, Id = c.Id, first = c.Name[0] }).ToArray();
            //            foreach (var car in CreateName)
            //            {
            //                Console.WriteLine($"Id: {car.Id}, Name: {car.Name}, First Letter: {car.first}");
            //                Console.ReadLine();
            //            }
            //        }
            //    }

            //}
            //            // שישלוף את הרכב עם מחיר שגדול מ80 אלף שקל שאילת רביעית 
            //            var Createbigprice = (from c in cars
            //                                  where c.Price > 80000m
            //                                  select new { c.Name, Id = c.Id, Price = c.Price }).ToArray();
            //            foreach (var car in Createbigprice)
            //            {
            //                Console.WriteLine($"Id: {car.Id}, Name: {car.Name}, Price: {car.Price:C}");

            //            }
            //            Console.ReadLine();
            //        }
            //    }
            //}    
            //שאילת חמישית 
            var oldCheapCars = (from c in cars
                                where c.Date.Year < 2015 && c.Price < 50000m
                                select new { c.Name, c.Id, c.Date, c.Price }).ToArray();

            foreach (var car in oldCheapCars)
            {
                Console.WriteLine($"Id: {car.Id}, Name: {car.Name}, Year: {car.Date.Year}, Price: {car.Price:C}");
            }
            Console.ReadLine();
        }
    }
}




