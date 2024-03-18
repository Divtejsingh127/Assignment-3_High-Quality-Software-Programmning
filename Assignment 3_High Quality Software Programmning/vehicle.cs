using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3_High_Quality_Software_Programmning

{
    public abstract class Vehicle
    {
        public string Model { get; set; }
        public string Menufacturer { get; set; }
        public int Year { get; set; }
        public double RentalPrice { get; set; }

        public Vehicle(string model, string menufacturer, int year, double rentalPrice)
        {
            Model = model;
            Menufacturer = menufacturer;
            Year = year;
            RentalPrice = rentalPrice;
        }
        public virtual void DisplayDetails()
        {
            Console.WriteLine($"The Model Name: {Model}");
            Console.WriteLine($"Manufacturer: {Menufacturer}");
            Console.WriteLine($"Year Of Vehicle: {Year}");
            Console.WriteLine($"Rental price is: {RentalPrice}");
        }
    }
}
