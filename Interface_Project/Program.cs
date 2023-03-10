using System;

namespace Interface_Project
{
    public class Program
    {
        static void Main(string[] args)
        {
            Vehicle hondaObj = new Honda("Honda", "Civic", 2021);

        }
    }
    abstract class Vehicle
    {
        public Vehicle(string brand, string model, int year)
        {
            Brand = brand;
            Model = model;
            Year = year;
        }

        protected string Brand { get; set; }
        protected string Model { get; set; }
        protected int Year { get; set; }
    }
    class Honda : Vehicle
    {
        public Honda(string brand, string model, int year) : base(brand, model, year)
        {

        }
    }
    class Caterpillar : Vehicle
    {
        public Caterpillar(string brand, string model, int year) :base(brand, model, year)
        {

        }
    }
}
