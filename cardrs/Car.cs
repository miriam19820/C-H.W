using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace cardrs
{
    public class Car
    {
  

        public string Id { get; set; } = "";
        public int Idd { get; set; }
        public ConsoleColor Color { get; set; }
        public DateTime Date { get; set; }
        public string Name { get; set; } = "";
        public string Company { get; set; } = "";
        public string Supplier { get; set; } = "";
        private decimal price;
        public decimal Price
        {
            get => price;
            set
            {
                if (value > 0)
                    price = value;
                else
                    throw new Exception("מחיר לא תקין");
            }
        }


        public Car(int idd, string name, string company, string supplier, decimal price)
        {
            Idd = idd;
            Name = name;
            Company = company;
            Supplier = supplier;
            Price = price;

            Id = "";
            Color = ConsoleColor.White;
            Date = DateTime.Now;


        }
        public override string ToString() =>
            $"{Name} מאת {Company}, צבע: {Color}, תאריך: {Date:dd/MM/yyyy}, מחיר: {Price:N2} ₪";
    }
}








